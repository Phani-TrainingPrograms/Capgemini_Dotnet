const employee = function (id, name, address){
    this.empId = id;
    this.empName = name;
    this.empAddress = address;
}
//Introduced in ES6
class Customer{
    constructor(id, name, bill) {
        this.cstId = id;
        this.cstName = name;
        this.cstBill = bill 
    }
}

//Inheritance in 
class PrevilagedCustomer extends Customer{
   constructor(id, name, bill, date){
    super(id, name, bill)
    this.visitdate = date;
   }

   display(){
    return `${this.cstName} has billed ${this.cstBill} on ${this.visitdate}`
   }
}