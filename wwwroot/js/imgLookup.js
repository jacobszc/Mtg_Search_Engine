

async function searchImg(query) {


const imgResultDiv = document.getElementById('imgResultDiv')

/* url to my api controller */

const url =`/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent(query)}`;

const response = await fetch(url);

const urltoimg = await response.text();

const img = document.createElement("img");

img.src = urltoimg;
img.alt = "Description of image";
img.classList.add("result-img");

imgResultDiv.appendChild(img);

/*imgResultDiv.innerHTML = `<img src="${urltoimg}" alt="Description of image" class ="result-img">`;*/


}