# Typescript
1. Typescript is a programming language created by Microsoft that is based on JS. 
2. It is an extension of Javascript with more type safety.
3. Here data types are to be explicitly declared before use and shall use the same types of Javascript. 
4. Typescript is not directly supported by any browser. So we need a transpiler that compiles the TS code and converts it to JS.
5. Typescript compiler is available from the MS website and can be used to transpile the TS files. 
6. tsconfig.json is the file that contains the config settings required to compile the TS files and generate the output as JS files. These generated JS files are used by the browsers for Dynamic Page generations. 
7. Popularly used by major JS frameworks and Libraries like Angular, React, Protractor and many more.
 
### Software requirements
1. Install Nodejs latest.
2. Install typescript using the following command: npm install -g typescript
3. If tsc is not recognized as command, U need to set the PATH variable in the Environment variables to include the path of the npm: %AppData%/Roaming/npm.
4. Ticket: Need admin rights to execute the Cmd, Allow to set the Path Environment for the user in the Windows os. 

### Compile the TS files
1. Create TS files with extension. .ts
2. U should configure UR TSC compiler to run from the Terminal by setting the Environment variable. 
3. U can run the following command to compile the TS file
```
tsc fileName.ts
```
4. Alternatively, U can create tsconfig.json file and provide options to define the location of the ts files(folder), the location for the output directory and other JS settings like the version of the JS stds that U need to generate. 

### Why TS?
1. TypeScript is typesafe language developed by Anders Heilsberg, the creator of C# which was said to be one of the popular typesafe languages. 
2.  JS is dynamic language and shall evaluate the variables and properties at runtime. If a property is not available it leads to undefined which is very common issue when working with JS. 
3. The compilers of TS shall ensure to generate more optimized JS code that can make UR apps run faster. 
4. Popular Frameworks and Libraries of JS like Angular and React extensively use TS for their coding purposes. 

### Data Types in TS
1. TS provides strict data types of Javascript
2. All data types of JS are available in TS.
    - string, number, boolean, object. 
3. Like C#, TS also has Type inference which need not specify the data type but it implicitly created. 

