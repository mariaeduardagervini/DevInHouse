import { Component } from '@angular/core';
import { Serie } from 'src/app/models/serie.interface';
import { SerieService } from 'src/app/services/serie.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  serie: Serie[] = [];

  constructor(private serieService: SerieService) {
    this.listSeries();
  }

  listSeries() {
    this.serieService.getSeries().subscribe((series) => {
      this.serie = series;
      console.log(series);
    });
  }
}
