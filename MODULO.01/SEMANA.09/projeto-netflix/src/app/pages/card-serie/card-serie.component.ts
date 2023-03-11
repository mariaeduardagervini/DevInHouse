import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ISeries } from 'src/app/models/series.interface';
import { WebService } from 'src/app/services/web.service';

@Component({
  selector: 'app-card-serie',
  templateUrl: './card-serie.component.html',
  styleUrls: ['./card-serie.component.scss'],
})
export class CardSerieComponent implements OnInit {
  @Input() public series: any = {};
  serieC: ISeries = {
    id: 0,
    nome: '',
    imagem: '',
  };

  constructor(
    private service: WebService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    // const id = this.route.snapshot.paramMap.get('id');
    // this.service.buscarPorId(parseInt(id!)).subscribe((serieC: any) => {
    //   this.serieC = serieC;
    // });
  }
  acessarSerie() {
    this.router.navigate(['/serie']);
  }
}
