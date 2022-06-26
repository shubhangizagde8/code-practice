import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { MainRoutes } from '../routing/routing.main';
//import { loginComponent } from './login.component';
import { LoginComponent } from './login.component';

@NgModule({
  declarations: [
    //HomeComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(MainRoutes)
  ],
  providers: [],
  bootstrap: [LoginComponent]
})
export class MasterModule { }