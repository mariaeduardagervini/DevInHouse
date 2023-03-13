import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Serie } from 'src/app/models/serie';

@Component({
  selector: 'app-card-serie',
  templateUrl: './card-serie.component.html',
  styleUrls: ['./card-serie.component.css'],
})
export class CardSerieComponent {
  @Input() serie!: Serie;

  constructor(private router: Router) {}

  navigateToSerie(serieId: string) {
    this.router.navigate([`/series/${serieId}`]);
  }
}
