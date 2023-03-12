import { FullComponent } from './layout/full/full.component';
import { LoginComponent } from './pages/login/login.component';
import { WrapperComponent } from './layout/wrapper/wrapper.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: WrapperComponent,
    children: [
      { path: '', redirectTo: 'login', pathMatch: 'full' },
      { path: 'login', component: LoginComponent },
    ],
  },
  // {
  //   path: '',
  //   component: FullComponent,
  //   children: [],
  // },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
