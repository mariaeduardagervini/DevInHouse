import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { SerieComponent } from './pages/serie/serie.component';
import { MenuComponent } from './components/menu/menu.component';
import { LoginComponent } from './pages/login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FullComponent } from './layouts/full/full.component';
import { ContentComponent } from './layouts/content/content.component';
import { FormsComponent } from './components/forms/forms.component';
import { AuthService } from './services/auth.service';
import { PrincipalComponent } from './pages/principal/principal.component';
import { CardSerieComponent } from './components/card-serie/card-serie.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SerieComponent,
    MenuComponent,
    LoginComponent,
    FullComponent,
    ContentComponent,
    FormsComponent,
    PrincipalComponent,
    CardSerieComponent,
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, ReactiveFormsModule],
  providers: [AuthService],
  bootstrap: [AppComponent],
})
export class AppModule {}
