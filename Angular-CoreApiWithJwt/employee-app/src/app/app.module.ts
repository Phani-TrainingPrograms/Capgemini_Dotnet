import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { provideHttpClient } from '@angular/common/http';
import { FormsModule} from '@angular/forms'
import { ReactiveFormsModule } from '@angular/forms'; // Import ReactiveFormsModule

import { AppComponent } from './app.component';
import { LoginComponent } from './Components/login/login.component';
import { EmployeeFormComponent } from './Components/employee-form/employee-form.component';
import { EmployeeListComponent } from './Components/employee-list/employee-list.component';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    EmployeeFormComponent,
    EmployeeListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ],
  providers: [provideHttpClient()],
  bootstrap: [AppComponent]
})
export class AppModule { }
