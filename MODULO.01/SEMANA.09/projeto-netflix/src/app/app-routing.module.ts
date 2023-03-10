import { ContentComponent } from './layouts/content/content.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FullComponent } from './layouts/full/full.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { SerieComponent } from './pages/serie/serie.component';
import { CardSerieComponent } from './pages/card-serie/card-serie.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  {
    path: '',
    component: FullComponent,

    children: [{ path: 'home', component: HomeComponent }],
  },
  {
    path: '',
    component: ContentComponent,

    children: [
      { path: 'login', component: LoginComponent },
      { path: 'card-serie', component: CardSerieComponent },
      { path: 'serie', component: SerieComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
