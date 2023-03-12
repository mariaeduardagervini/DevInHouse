import { Component } from '@angular/core';
import { SearchPipePipe } from 'src/app/common/pipes/search-pipe.pipe';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss'],
})
export class ListComponent {
  products: any[] = [
    {
      id: 1,
      name: 'Saia Azul',
      quantity: 50,
      unitPrice: 154.9,
    },
    {
      id: 2,
      name: 'Top Amarelo',
      quantity: 50,
      unitPrice: 94.5,
    },
    {
      id: 3,
      name: 'Camisa Branca',
      quantity: 50,
      unitPrice: 189.9,
    },
    {
      id: 4,
      name: 'Sandália Off Whitte',
      quantity: 50,
      unitPrice: 259.9,
    },
  ];
  keySearch: string = '';

  constructor(private pipe: SearchPipePipe) {}
}
