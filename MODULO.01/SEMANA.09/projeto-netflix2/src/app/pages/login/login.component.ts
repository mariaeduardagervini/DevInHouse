import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/models/usuario';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  usuario: Usuario = new Usuario();
  formUsuario!: FormGroup;
  listaUsuarios: Usuario[] = [];

  constructor(
    private fb: FormBuilder,
    private usuarioService: UsuarioService,
    private router: Router
  ) {}

  ngOnInit() {
    this.getUsersList();
    this.criarForm(new Usuario());
    this.createLocalStorage(false);
  }
  criarForm(usuario: Usuario) {
    this.formUsuario = this.fb.group({
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
    return this.formUsuario.get('email')!;
  }

  get senha() {
    return this.formUsuario.get('senha')!;
  }
  createLocalStorage(booleanValue: boolean) {
    localStorage.setItem('logged', `${booleanValue}`);
  }

  getUsersList() {
    this.usuarioService.getUsers().subscribe((usuarios) => {
      this.listaUsuarios = usuarios;
    });
  }

  findUser() {
    this.listaUsuarios.find((usuario) => {
      if (usuario.email === this.email.value) {
        this.usuario = usuario;
      }
    });
  }

  onSubmit() {
    this.createLocalStorage(true);
    this.router.navigate(['/home']);
    //} else {
    // this.createLocalStorage(false);
    //}
  }
}
