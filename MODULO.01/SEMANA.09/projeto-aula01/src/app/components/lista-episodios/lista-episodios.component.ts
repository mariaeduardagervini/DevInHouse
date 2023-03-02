import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-lista-episodios',
  templateUrl: './lista-episodios.component.html',
  styleUrls: ['./lista-episodios.component.scss'],
})
export class ListaEpisodiosComponent {
  @Input() episodios: any[] = [];
  @Output() cliqueEnviado: EventEmitter<any> = new EventEmitter<any>();

  constructor() {}

  ngOnInit(): void {}

  emitirEvento() {
    this.cliqueEnviado.emit('Clique no componente filho');
    //alert('Componente filho');
  }
}
