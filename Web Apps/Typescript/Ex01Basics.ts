const msg : string = "Hello world"
console.log(msg);

let username : string = "Phaniraj";
let age : number = 48;
let isAdmin : boolean = true;

let id : string | number //string or number(UNION Data type)...
id = 123;
id = "Emp_123";

console.log(`${id}`) 

//tuples are also available in the latest version of the TS.
let skills : [string, number]
skills = ["Programming", 8];
console.log(skills)

skills = ["Learning", 5];
console.log(skills)

skills = ["Presentation", 9];
console.log(skills)

console.log(`${username} whose age is ${age} has his Admin credentials as ${isAdmin}`);