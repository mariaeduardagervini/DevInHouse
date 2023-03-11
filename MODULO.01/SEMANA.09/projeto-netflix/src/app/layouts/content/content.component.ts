import { ISeries } from './../../models/series.interface';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.scss'],
})
export class ContentComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {}

  series = [
    {
      id: 1,
      nome: 'Peaky Blinders',
      imagem:
        'https://cinepop.com.br/wp-content/uploads/2019/08/peaky-blinders-cast-maxi-poster-1.190.jpg',
    },
    {
      id: 2,
      nome: 'Stranger Things',
      imagem:
        'https://veja.abril.com.br/wp-content/uploads/2016/11/strangerthings3.jpg?quality=70&strip=all',
    },
    {
      id: 3,
      nome: 'The Crown',
      imagem:
        'https://cinepop.com.br/wp-content/uploads/2016/09/thecrown_1.jpg',
    },
  ];
}
