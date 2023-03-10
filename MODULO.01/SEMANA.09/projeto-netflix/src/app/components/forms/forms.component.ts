import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Ilogin } from 'src/app/models/login.interface';
import { WebService } from 'src/app/services/web.service';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.scss'],
})
export class FormsComponent {
  myForm!: FormGroup;

  constructor(private fb: FormBuilder, private webService: WebService) {}

  ngOnInit() {
    this.myForm = this.fb.group({
      email: ['', [Validators.email]],
      password: ['', [Validators.minLength(6), Validators.maxLength(12)]],
    });

    this.iniciarDados();
  }

  iniciarDados() {
    this.myForm.patchValue({
      email: 'yan.m.esteves@gmail.com',
    });
  }

  jaTentouEnviar = 0;
  onSubmit() {
    if (!this.myForm.valid) {
      console.log('Algo não está de acordo.');
      return;
    }

    //const data: Ilogin = this.myForm.value;
    //this.webService.post('/login', this.myForm.value);
  }
}
