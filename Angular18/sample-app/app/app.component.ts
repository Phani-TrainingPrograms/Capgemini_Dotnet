import { Component } from '@angular/core';

@Component({
  selector: 'mango',
  templateUrl: "./mango.html",
  standalone : false
})
export class AppComponent {
  title = 'sample-app';
  developedBy : string = "phaniraj";
  year : number = new Date().getFullYear();
  empRecords : [number, string, string, number?] []= [
                    [123, "Phaniraj", "phanirajbn@gmail.com", 45000],
                    [124, "Mahesh", "mahesh@yahoo.in", 55000],
                    [125, "Venkat", "venkat@rediffmail.com", 40000],
                    [126, "Ramesh", "ramesh@gmail.com", 50000]
                  ]
}
