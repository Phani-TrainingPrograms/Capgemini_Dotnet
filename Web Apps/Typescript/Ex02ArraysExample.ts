let skillset : string[] = []; //creates a blank string [].
skillset.push("Programming")
skillset.push("UI Design")
skillset.push("Problem Solving")
skillset.push("Presentation")
skillset = [...skillset, "Operations"] //new syntax of adding content to an array using ... spread operator.


//try other functions of Array to perform Crud operations. 
console.log(skillset)

//remove a record
skillset = skillset.filter(i =>i != "Problem Solving")
console.log(skillset)

skillset = skillset.map(i => i == "Presentation" ? "Presentation Skills" : i);
console.log(skillset)