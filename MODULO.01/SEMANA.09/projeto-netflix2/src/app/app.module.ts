import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CardSerieComponent } from './components/card-serie/card-serie.component';
import { MenuComponent } from './components/menu/menu.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { SerieComponent } from './pages/serie/serie.component';
import { FullComponent } from './layouts/full/full.component';
import { ContentComponent } from './layouts/content/content.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AuthGuard } from './guard/auth.guard';
import { PrincipalComponent } from './pages/principal/principal.component';

@NgModule({
  declarations: [
    AppComponent,
    CardSerieComponent,
    MenuComponent,
    HomeComponent,
    LoginComponent,
    SerieComponent,
    FullComponent,
    ContentComponent,
    PrincipalComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [AuthGuard],
  bootstrap: [AppComponent],
})
export class AppModule {}
