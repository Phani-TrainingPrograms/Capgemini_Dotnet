# Angular 18
## About Angular
1. Angular is a framework provided by Google for developing Web UI Applications in a faster, reliable and easy manner. It makes UR applications more optimized to run on Web Browsers using various modren tools like Webpack, Minify and Protractor. 
2. Developed by Google and has a wide usage across the industry and supported by a large community. 
3. Google promises to release new versions of it very 6 months. Current version is v18.0 and there is already a 19th version but not with LTS. 
4. Angular has the following features
- It provides Component architecture where UR App is divided into small independent components which are reusable and adaptive. They are self contained with their our programming logic, UI and its own testing environment. 
- Angular expects its Application to be SPA.(Single Page Application). There shall be a page called Index.html and inside that HTML U shall load UR components in the structure that U want to display in the UI. 
- It has a powerful data binding feature that allows data to be bound with the HTML Elements and changes made at either side shall be reflected on the other. It provides property binding, event binding and form binding where the data shall be updated when the changes are made anywhere in the Component.
- It is one of the first JS Frameworks to provide DI Feature in their Components. It provides a concept called Services that can be injected into any component when it is loaded into the browser and thru that Service U can make calls to the REST APIs or backend services to get/set/put UR data.
- Code is developed using Typescript, even though its not mandatory. With Typescript U get OOP features like inheritance and other features into the Component architecture. TS is typesafe and shall be more optimized with the tsconfig files that come with it. 
- Angular provides first hand support to Unit testing in JS using jasmine library and also supports Protractor.js for E2E Testing, usually done for Automation Testing. 
- Angular has aditional libraries like RxJs that supports APIs for making calls to REST end points. 
- Angular has new routing feature that allows components to be loaded on request thru either Links or thru Lazy loading. 
- With the above features, angular Apps can be built using various units of the Angular like Components(Fundamental Units), Pipes(Transformers), Services(Singleton Objects that can share data among the components), Injectors(For DI purposes), Modules(precompiled units), directives(Attribute like),  gaurds(Middlewares), interfaces(Models) and classes(OOP units). All the above mentioned unis are classes with specific directives.   

### Software requirements for Angular. 
1. Any OS like linux, Windows, Mac. 
2. Download the LTS version of Nodejs which will be UR server for hosting Angular Apps.
3. Download the Angular CLI which is a Command line interface provided by google for creating Angular apps in a faster manner. 

### How to create Angular Applications
1. After installing Nodejs and NPM,we can use NPM to install Angular CLI.
```
npm install -g @angular/cli
ng version
npm uninstall -g @angular/cli
```


