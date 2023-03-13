import { SerieService } from './../../services/serie.service';
import { Component, Input, OnInit } from '@angular/core';
import { Serie } from 'src/app/models/serie';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  @Input() public series: any = {};

  constructor(private serieService: SerieService) {
    this.listSeries();
  }
  listSeries() {
    this.serieService.getSeries().subscribe((series) => {
      this.series = series;
    });
  }
}
