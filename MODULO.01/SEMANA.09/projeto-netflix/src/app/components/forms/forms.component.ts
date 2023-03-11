import { UsuarioService } from './../../services/usuario.service';
import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { WebService } from 'src/app/services/web.service';
import { IUsuario, User } from 'src/app/models/usuario.interface';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.scss'],
})
export class FormsComponent implements OnInit {
  user: User = new User();
  formUser!: FormGroup;
  listUsers: User[] = [];

  constructor(
    private fb: FormBuilder,
    private usuarioService: UsuarioService,
    private router: Router
  ) {}

  ngOnInit() {
    this.iniciarDados();
  }

  iniciarDados() {
    this.getUsersList();
    this.createForm(new User());
    this.createLocalStorage(false);
  }

  createForm(user: User) {
    this.formUser = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: [
        '',
        [
          Validators.required,
          Validators.minLength(6),
          Validators.maxLength(10),
        ],
      ],
    });
  }
  get email() {
    return this.formUser.get('email')!;
  }

  get senha() {
    return this.formUser.get('senha')!;
  }

  createLocalStorage(booleanValue: boolean) {
    localStorage.setItem('logged', `${booleanValue}`);
  }

  getUsersList() {
    this.usuarioService.getUsers().subscribe((users) => {
      this.listUsers = users;
    });
  }

  findUser() {
    this.listUsers.find((user) => {
      if (user.email === this.email.value) {
        this.user = user;
      }
    });

    if (this.user.email === undefined && this.email.value === null) {
      this.email.setErrors({ required: true });
      this.email.markAsTouched();
      return false;
    } else if (this.user.email === undefined && this.email.value != null) {
      this.email.setErrors({ invalid: true });
      this.email.markAsTouched();
      return false;
    } else {
      return true;
    }
  }

  correctPassword() {
    if (this.senha.value === null) {
      this.senha.setErrors({ required: true });
      this.senha.markAsTouched();
    } else {
      if (this.user.password === this.senha.value) {
        return true;
      } else {
        this.senha.setErrors({ invalid: true });
        this.senha.markAsTouched();
        return false;
      }
    }
    return false;
  }
  onSubmit() {
    if (this.findUser()) {
      if (this.correctPassword()) {
        this.createLocalStorage(true);
        this.router.navigate(['/home']);
      } else {
        this.createLocalStorage(false);
      }
    } else {
      this.createLocalStorage(false);
    }
  }
}
