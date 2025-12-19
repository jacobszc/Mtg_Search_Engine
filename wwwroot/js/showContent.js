function showContent() {
  let temp = document.getElementsByTagName("template")[0];
  let clon = temp.content.cloneNode(true);
  let results = document.getElementById("ResultDiv")
  results.appendChild(clon);
}