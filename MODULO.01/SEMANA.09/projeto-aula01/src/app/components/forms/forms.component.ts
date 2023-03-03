import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.scss'],
})
export class FormsComponent implements OnInit {
  myForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.myForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]],
    });
    this.iniciarDados();
  }
  iniciarDados() {
    this.myForm.patchValue({
      email: 'maria@gmail.com',
    });
  }
  onSubmit() {
    if (!this.myForm.valid) {
      console.log('Algo não está correto!');
      return;
    }
    console.log(this.myForm.value);
  }
}
