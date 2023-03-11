import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-card-serie',
  templateUrl: './card-serie.component.html',
  styleUrls: ['./card-serie.component.css'],
})
export class CardSerieComponent {
  @Input() public serie: any = {};
}
