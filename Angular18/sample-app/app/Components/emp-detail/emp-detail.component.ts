import { Component, Input } from '@angular/core';

//@Input Directive is used to input the values for the properties from the Container component. 

@Component({
  selector: 'app-emp-detail',
  standalone: false,
  templateUrl: './emp-detail.component.html',
  styleUrl: './emp-detail.component.css'
})
export class EmpDetailComponent {
  //set the data:
  @Input() empId : number = 0;
  @Input()empName? : string;
  @Input() empEmail? : string;
  @Input() empSalary? : number | undefined;
 
  onClick(){
    alert(`The Name is ${this.empName} with a email Address of ${this.empEmail}`)
  }
}
