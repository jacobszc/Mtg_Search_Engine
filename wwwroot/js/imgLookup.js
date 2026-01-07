

async function searchImg(query) {




/* url to my api controller */

const url =`/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent(query)}`;


const response = await fetch(url);

const urltoimg = await response.text(); // this is where string uri to image is retuned

showCardImage(urltoimg);



}

