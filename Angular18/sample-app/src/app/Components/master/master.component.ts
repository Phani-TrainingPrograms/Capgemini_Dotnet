import { Component, OnInit } from '@angular/core';
import { Employee } from '../../Models/employee';

@Component({
  selector: 'app-master',
  standalone: false,
  templateUrl: './master.component.html',
  styles: ``
})
export class MasterComponent implements OnInit {
   ngOnInit(): void {
     this.empList.push({empId : 123, empName: "Phaniraj", empAddress : "Bangalore", empSalary : 45000, empImg : "Phani.png"});
     this.empList.push({empId : 124, empName: "Vinod Kumar", empAddress : "Mysore", empSalary : 45000, empImg : "pic1.png"});
     this.empList.push({empId : 125, empName: "Banu Prakash", empAddress : "Mysore", empSalary : 45000, empImg : "pic2.png"});
     this.empList.push({empId : 126, empName: "Sunder", empAddress : "Chennai", empSalary : 45000, empImg : "pic3.png"});
     this.empList.push({empId : 127, empName: "Sreeja", empAddress : "Bangalore", empSalary : 45000, empImg : "pic4.png"});
   }
   empList: Employee[] = []
   selectedEmp : Employee | null = null;
   onEdit(emp : Employee){
     this.selectedEmp = emp
     alert("Employee is selected")
   }
}
