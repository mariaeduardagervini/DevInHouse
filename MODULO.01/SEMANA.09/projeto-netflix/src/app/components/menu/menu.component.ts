import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss'],
})
export class MenuComponent {
  constructor(private router: Router) {}

  logout() {
    localStorage.setItem('logged', 'false');
    this.router.navigate(['/login']);
  }

  voltarHome() {
    this.router.navigate(['/home']);
  }
}
