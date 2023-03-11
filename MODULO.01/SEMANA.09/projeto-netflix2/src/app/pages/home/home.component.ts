import { SerieService } from './../../services/serie.service';
import { Component, Input, OnInit } from '@angular/core';
import { Serie } from 'src/app/models/serie';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  @Input() public serie: any = {};
  listarSeries: Serie[] = [];
  constructor(private serieService: SerieService) {}

  ngOnInit(): void {
    this.serieService.getSeries().subscribe((listarSeries) => {
      this.listarSeries = listarSeries;
      console.log(listarSeries);
    });
  }
}
