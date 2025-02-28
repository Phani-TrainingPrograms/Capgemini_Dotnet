import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmpDetailComponent } from './Components/emp-detail/emp-detail.component';
import { CalcComponent } from './Components/calc/calc.component';
import { FormsModule } from '@angular/forms';
import { MasterComponent } from './Components/master/master.component';
import { EmpRecComponent } from './Components/emp-rec/emp-rec.component';

@NgModule({
  declarations: [
    AppComponent,
    EmpDetailComponent,
    CalcComponent,
    MasterComponent,
    EmpRecComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
