import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-serie',
  templateUrl: './serie.component.html',
  styleUrls: ['./serie.component.scss'],
})
export class SerieComponent implements OnInit {
  lista = [
    { nome: 'Titanic', duracao: '247' },
    { nome: 'A vida é bela', duracao: '205' },
    { nome: 'E o vento levou', duracao: '147)' },
  ];
  constructor() {}

  ngOnInit(): void {}

  recebeEvento(event: any) {
    console.log('--Recebe evento--');
    console.log(event);
  }
}
