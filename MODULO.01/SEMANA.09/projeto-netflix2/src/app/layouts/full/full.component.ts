import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-full',
  templateUrl: './full.component.html',
  styleUrls: ['./full.component.css'],
})
export class FullComponent {
  @Input() public serie: any = {};
}
