import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from "@angular/forms";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SecurityComponent } from './security/security.component';
import { HomeComponent } from './home/home.component';
import { SecurityGuard } from './security-guard/security-guard';

@NgModule({
  declarations: [
    AppComponent,
    SecurityComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [SecurityGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
