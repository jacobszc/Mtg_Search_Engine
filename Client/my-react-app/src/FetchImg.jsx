import {useRef, useEffect} from 'react';

async function FetchImg({query}) {


    const url =`/api/imagesearch/imagesearch?imgQueryResult=${encodeURIComponent(query)}`;

    const response = await fetch(url);

    const urltoimg = await response.text();

    ShowCardImage(urltoimg);

}

export default FetchImg;



