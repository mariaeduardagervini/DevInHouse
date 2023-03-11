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
    this.iniciarDados();
  }

  iniciarDados() {
    this.createForm(new Usuario());
  }

  createForm(usuario: Usuario) {
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

  onSubmit() {
    this.router.navigate(['/home']);
  }
}
