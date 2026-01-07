

async function FetchScryFallImg(backEndApiUrl ) {
    
   
    
    console.log("fetching..", backEndApiUrl);
    
    const response =  await fetch(backEndApiUrl)
    .then((response)=>response.text());

    const imgUrl = response;
    console.log("scryfall image url found!... ",imgUrl);



    return imgUrl;
}

export default FetchScryFallImg;