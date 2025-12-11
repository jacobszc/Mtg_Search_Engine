
function filterTypes() {

    const Artifact = document.getElementById("artifact")
    const Instant = document.getElementById("instant")
    const Sorcery = document.getElementById("sorcery")
    const Enchantment = document.getElementById("enchantment")
    const Land = document.getElementById("land")
    const Planeswalker = document.getElementById("planeswalker")
    const Battle = document.getElementById("battle")




let typeFilter =[];

if(Artifact.selected) {

    typeFilter.push("Artifact")
}

if(Instant.selected) {

    typeFilter.push("Instant")
}

if(Sorcery.selected) {

    typeFilter.push("Sorcery")
}

if(Enchantment.selected) {

    typeFilter.push("Enchantment")
}

if(Land.selected) {

    typeFilter.push("Land")
}

if(Planeswalker.selected) {

    typeFilter.push("Planeswalker")
}

if(Battle.selected) {

    typeFilter.push("Battle")
}

return typeFilter

}