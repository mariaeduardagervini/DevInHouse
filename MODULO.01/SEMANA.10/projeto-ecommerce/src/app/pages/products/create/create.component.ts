import { Component, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

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
      name: new FormControl('', [Validators.required, Validators.minLength(2)]),
      preco: new FormControl('', [
        Validators.required,
        Validators.minLength(4),
      ]),
      quantity: new FormControl('', [
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

  get name() {
    return this.productForm.get('name')?.value;
  }

  get preco() {
    return this.productForm.get('preco')?.value;
  }

  get quantity() {
    return this.productForm.get('quantity')?.value;
  }

  get username() {
    return this.productForm.get('userName')?.value;
  }

  onSubmit() {}
}
