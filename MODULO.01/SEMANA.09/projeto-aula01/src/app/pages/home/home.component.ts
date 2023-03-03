import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  parametroVar = 25;

  seriesList = [
    { id: '1', nome: 'Breaking Bed' },
    { id: '2', nome: 'The Walking Dead' },
    { id: '3', nome: 'Game of Thrones' },
  ];
  tratarEvento(event: any) {
    console.log(event);
  }

  constructor(private router: Router) {}

  ngOnInit(): void {}

  gotoSerie() {
    this.router.navigate([`/serie/${this.parametroVar}`]);
  }
}
