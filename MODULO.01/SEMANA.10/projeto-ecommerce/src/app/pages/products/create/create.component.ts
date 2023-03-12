import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss'],
})
export class CreateComponent implements OnInit {
  userName!: any;
  productForm!: FormGroup;

  ngOnInit(): void {
    this.userName = localStorage.getItem('userName');
    this.createForm();
  }

  constructor() {}

  createForm() {
    this.productForm = new FormGroup({
      id: new FormControl('', [Validators.required, Validators.minLength(2)]),
      nome: new FormControl('', [Validators.required, Validators.minLength(2)]),
      preco: new FormControl('', [
        Validators.required,
        Validators.minLength(4),
      ]),
      quantidade: new FormControl('', [
        Validators.required,
        Validators.minLength(4),
      ]),
      userName: new FormControl(this.userName, [
        Validators.required,
        Validators.minLength(4),
      ]),
    });
  }

  get id() {
    return this.productForm.get('id')?.value;
  }

  get nome() {
    return this.productForm.get('nome')?.value;
  }

  get preco() {
    return this.productForm.get('preco')?.value;
  }

  get quantidade() {
    return this.productForm.get('quantidade')?.value;
  }

  get username() {
    return this.productForm.get('userName')?.value;
  }

  onSubmit() {}
}
