import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SecurityGuard } from './security-guard/security-guard';
import { SecurityComponent } from './security/security.component';

const routes: Routes = [
  {path:'giris', component:SecurityComponent},
  {path:'', redirectTo:'dashboard', pathMatch:'full'},
  {path:'dashboard', component:HomeComponent, canActivate:[SecurityGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
