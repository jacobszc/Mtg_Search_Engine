const GreenCheckBox = document.getElementById("checkbox-green")

const BlackCheckBox = document.getElementById("checkbox-black")

const SearchButton = document.getElementById("SearchButton")

.addEventListener("click", () => {

let colors =["green", "black", "red", "blue", "white"];

if(!GreenCheckBox.checked) {
    colors.splice(0,1);
}

if(!BlackCheckBox.checked) {

    colors.splice(1,1);
}

}) // end event listender labda


async function searchFiltered() {

    
}