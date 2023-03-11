import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Serie } from 'src/app/models/serie.interface';

@Component({
  selector: 'app-card-serie',
  templateUrl: './card-serie.component.html',
  styleUrls: ['./card-serie.component.scss'],
})
export class CardSerieComponent {
  @Input() serie!: Serie;
  show: Boolean = false;

  constructor(private router: Router) {}

  navigateToSerie(serieId: string) {
    console.log('Click ativado: ' + serieId);
    this.router.navigate([`/series/${serieId}`]);
  }
}
