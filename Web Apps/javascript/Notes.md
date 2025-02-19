# Notes on Javascript 
1. JS is a client side scripting language that is used to create dynamic content in HTML Documents. 
2. It is light weight and easy to work with. It can be embeded inside Html docs and generate dynamic html content. 
3. It is fast and very powerful. It works on interpretors. 

# Software for JS
1. JS can work on any browser. 
2. U need a text editor to create JS code. 
3. U can use JS inside html docs or create a seperate JS file and include it in the html doc. 

### Variables and Constants in JS
1. var, let and const
2. var and let are same. var is the older version of let. let is more scope based compared to var. 
3. const is used to create data that cannot be modified. however its members can be modified. 

### UI based functions in JS
1. alert -> used to display pop up window with text that can draw the attention of the user.  
2. prompt -> Similar to alert but allows the user to enter some text as answer to the question asked in the Pop-up window. 
3. confirm-> Allows to user to either accept or cancel the action. 

### Data types in JS
1. JS is a dynamic language, U dont declare the variables with data types.
2. let or var or const to declare the variables. it is not mandatory to declare the variables before use. However, its a good practise and U can force this variable declaration using strict flag which should be set at the start of the script. 
3. U can use typeof function to determine the internal type that the variable holds. 
4.  internally variables could be: number, string, object, boolean, undefined.
5. To convert inputs to numbers we use parseInt and parseFloat. 
6. If the conversion is not possible, then it shall be assigned as NaN(Not a Number). However we can use IsNumber or Number functions to check of the input is a valid number and then we can handle it. 

### Arrays in JS
1. Arrays in JS work like collections of other programming languages. 
2. All arrays are objects, they can be initialized with [] operator.
3. Arrays has functions thru which U can manipulate the data
    - push method is used to add the element to the bottom of the list
    - unshift method is used to add the element at the begining of the list. 
    - splice method can be used to add, replace or delete an item from the list
    - length property is used to get the no of elements in the array. 
    - slice is used to get the subset of the array.
    - pop is used to remove the last element of the array, for the first element use shift, else use splice. 

 ### Classes and objects in JS
 1. There are 3 ways to create objects in Js
 2. Singleton objects where U dont need any class declaration.
 ```
<script>
 const obj = { Name : "Phaniraj", Address : "Bangalore", Salary : 45000};

 obj.EmailAddress = "phanirajbn@gmail.com"
 console.log(obj) //Use console.log to log the info in the Console section of the Browser.
</script>
 ```
 3. Function based classes which was the part of old JS. 
 4. New ES6 feature of using class keyword to create classes. 




