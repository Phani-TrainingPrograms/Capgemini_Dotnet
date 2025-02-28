import { Component } from '@angular/core';

@Component({
  selector: 'app-calc',
  standalone: false,
  templateUrl: 'calc.component.html',
  styles: ``
})
export class CalcComponent {
   firstVal : number = 123.0;
   secondVal : number = 23.0;
   result : number = this.firstVal + this.secondVal;
  operation : string = "+"

  onUpdate(event : any){
    this.firstVal = event.target.value;
    this.secondVal = event.target.value;
  }
   onClick(){
    debugger;
      switch (this.operation) {
        case "+": this.result = this.firstVal+ this.secondVal; break;
        case "-": this.result = this.firstVal - this.secondVal; break;
        case "*": this.result = this.firstVal * this.secondVal; break;
        case "/": this.result = this.firstVal / this.secondVal; break;
        default:
          break;
      }
   }
}
