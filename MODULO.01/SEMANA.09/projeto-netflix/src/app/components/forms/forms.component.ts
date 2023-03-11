import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { WebService } from 'src/app/services/web.service';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.scss'],
})
export class FormsComponent {
  myForm!: FormGroup;

  constructor(
    private fb: FormBuilder,
    private webService: WebService,
    private router: Router
  ) {}

  ngOnInit() {
    this.myForm = this.fb.group({
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

    this.iniciarDados();
  }

  iniciarDados() {
    this.myForm.patchValue({
      email: '',
    });
  }

  onSubmit() {
    if (!this.myForm.valid) {
      console.log('Algo não está de acordo.');
      return;
    }

    // const data: Ilogin = this.myForm.value;
    // this.webService.post('/login', this.myForm.value);
  }
  acessarConta() {
    this.router.navigate(['/login']);
  }
}
