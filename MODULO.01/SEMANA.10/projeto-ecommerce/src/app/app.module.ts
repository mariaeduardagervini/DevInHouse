import { NgModule, PipeTransform } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './pages/login/login.component';
import { FullComponent } from './layout/full/full.component';
import { WrapperComponent } from './layout/wrapper/wrapper.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';
import { MenuComponent } from './components/menu/menu.component';
import { EmailPipePipe } from './common/pipes/email-pipe.pipe';
import { ListComponent } from './pages/products/list/list.component';
import { CreateComponent } from './pages/products/create/create.component';
import { SearchPipePipe } from './common/pipes/search-pipe.pipe';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    FullComponent,
    WrapperComponent,
    MenuComponent,
    EmailPipePipe,
    ListComponent,
    CreateComponent,
    SearchPipePipe,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [EmailPipePipe, SearchPipePipe],
  bootstrap: [AppComponent],
})
export class AppModule {}
