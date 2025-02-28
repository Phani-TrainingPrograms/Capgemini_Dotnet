import { Component, Input } from '@angular/core';
import { Employee } from '../../Models/employee';

@Component({
  selector: 'app-emp-rec',
  standalone: false,
  templateUrl: './emp-rec.component.html',
  styles: ``
})
export class EmpRecComponent {
  @Input() empDetail : Employee = {} as Employee;//Initialize it to a empty Employee object. 
  

}
