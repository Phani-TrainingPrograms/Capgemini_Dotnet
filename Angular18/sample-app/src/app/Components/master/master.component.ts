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
     this.empList.push({empId : 123, empName: "Phaniraj", empAddress : "Bangalore", empSalary : 45000, empImg : "phani.png"});
     this.empList.push({empId : 123, empName: "Phaniraj", empAddress : "Bangalore", empSalary : 45000, empImg : "phani.png"});
     this.empList.push({empId : 123, empName: "Phaniraj", empAddress : "Bangalore", empSalary : 45000, empImg : "phani.png"});
     this.empList.push({empId : 123, empName: "Phaniraj", empAddress : "Bangalore", empSalary : 45000, empImg : "phani.png"});
     this.empList.push({empId : 123, empName: "Phaniraj", empAddress : "Bangalore", empSalary : 45000, empImg : "phani.png"});
   }
   empList: Employee[] = []
}
