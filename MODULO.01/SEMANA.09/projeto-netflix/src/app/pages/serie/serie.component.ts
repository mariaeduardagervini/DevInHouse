import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Serie } from 'src/app/models/serie.interface';
import { SerieService } from 'src/app/services/serie.service';

@Component({
  selector: 'app-serie',
  templateUrl: './serie.component.html',
  styleUrls: ['./serie.component.scss'],
})
export class SerieComponent implements OnInit {
  serie!: Serie;
  numTemp: String[] = [];

  constructor(
    private serieService: SerieService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.params.subscribe((params) => {
      // console.log(params['id']);
      this.getSerie(params['id']);
    });
  }

  getSerie(id: string) {
    setTimeout(() => {
      this.serieService.getSerie(id).subscribe((serie) => {
        this.serie = serie;
        this.numTemp.length = parseFloat(serie.season);
      });
    }, 3000);
  }
}
