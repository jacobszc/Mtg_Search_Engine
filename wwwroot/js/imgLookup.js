

async function searchImg(query) {


const imgResultDiv = document.getElementById('imgResultDiv')

/* url to my api controller */

const url =`/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent(query)}`;

const response = await fetch(url);

const urltoimg = await response.text();

imgResultDiv.innerHTML = `<img src="${urltoimg}" alt="Description of image" style="width:100%;">`;


}