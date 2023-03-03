import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss'],
})
export class CardComponent {
  @Input() series: any;
  @Output() eventemitter: EventEmitter<any> = new EventEmitter<any>();

  enviarEvento() {
    this.eventemitter.emit(`Ver séries foi execuado em: ${this.series.id}`);
  }
}
