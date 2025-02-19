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