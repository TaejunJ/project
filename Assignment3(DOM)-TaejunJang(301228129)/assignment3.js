"use strict";
var photoOrder = [1, 2, 3, 4, 5];
var autoAdvance = setInterval(rightAdvance, 5000);
var figureCount = 3;
const divFav = document.querySelector('#favDiv')

function populateFigures() {
    document.querySelector('#fig2').querySelector('img').src = './images/' + imageID(photoOrder[1], true)
    document.querySelector('#fig3').querySelector('img').src = './images/' + imageID(photoOrder[2], true)
    document.querySelector('#fig4').querySelector('img').src = './images/' + imageID(photoOrder[3], true)
}
function rightArrow() {
    clearInterval(autoAdvance);
    rightAdvance();
}
function rightAdvance() {
    for (var i = 0; i < 5; i++) {
        if ((photoOrder[i] + 1) === 6) {
            photoOrder[i] = 1;
        } else {
            photoOrder[i] += 1;
        }
        populateFigures();
    }
}
function leftArrow() {
    clearInterval(autoAdvance);
    for (var i = 0; i < 5; i++) {
        if ((photoOrder[i] - 1) === 0) {
            photoOrder[i] = 5;
        } else {
            photoOrder[i] -= 1;
        }
        populateFigures();
    }
}
function previewFive() {
    var articleEl = document.getElementsByTagName("article")[0];
    var lastFigure = document.createElement("figure");
    lastFigure.id = "fig5";
    lastFigure.style.zIndex = "5";
    lastFigure.style.position = "absolute";
    lastFigure.style.right = "45px";
    lastFigure.style.top = "67px";
    var lastImage = document.createElement("img");
    lastImage.width = "240";
    lastImage.height = "135";
    lastFigure.appendChild(lastImage);
    articleEl.insertBefore(lastFigure, document.getElementById("rightarrow"));
    var firstFigure = lastFigure.cloneNode(true);
    firstFigure.id = "fig1";
    firstFigure.style.right = "";
    firstFigure.style.left = "45px";
    articleEl.insertBefore(firstFigure, document.getElementById("fig2"));

    figureCount = 5;
    var numberButton = document.querySelector("#fiveButton p");
    numberButton.innerHTML = "Show fewer images";
    if (numberButton.addEventListener) {
        numberButton.removeEventListener("click", previewFive, false);
        numberButton.addEventListener("click", previewThree, false);
    } else if (numberButton.attachEvent) {
        numberButton.detachEvent("onclick", previewFive);
        numberButton.attachEvent("onclick", previewThree);
    }
    document.getElementsByTagName("img")[0].src = "images/fish" + photoOrder[0] + "sm.jpg";
    document.getElementsByTagName("img")[4].src = "images/fish" + photoOrder[4] + "sm.jpg";
}
function previewThree() {
    var articleEl = document.getElementsByTagName("article")[0];
    var numberButton = document.querySelector("#fiveButton p");
    figureCount = 3;
    articleEl.removeChild(document.getElementById("fig1"));
    articleEl.removeChild(document.getElementById("fig5"));
    numberButton.innerHTML = "Show more images";
    if (numberButton.addEventListener) {
        numberButton.removeEventListener("click", previewThree, false);
        numberButton.addEventListener("click", previewFive, false);
    } else if (numberButton.attachEvent) {
        numberButton.detachEvent("onclick", previewThree);
        numberButton.attachEvent("onclick", previewFive);
    }
}

function zoomFig(id, fav) {
    
    const wnd = window.open(`./zoom.html#id=${id}&fav=${fav}`, null, 'popup')
}

function imageID(id, sub) {
    let fileName = 'fish' + id
    if (sub)
        fileName += 'sm'
    return fileName + '.jpg'
}



function removeFav(id) {
    console.log('remove ' + id)
    const imgs = divFav.querySelectorAll('img')
    for (let i = imgs.length - 1; 0 <= i; i--) {
        if (imgs[i].src.includes(id)) {
            imgs[i].remove()
            break
        }
    }
}
function addToFav(id) {
    console.log('add ' + id)
    const alertImg = divFav.querySelectorAll('img')
    if (5 <= alertImg.length) {
        window.alert("Your favorite is full, please remove one picture to add one.")
        return
    }
            
    const saveImg = document.createElement('img')
    saveImg.src = './images/' + imageID(id, true)
    saveImg.style.width = "150px"
    saveImg.style.height = "150px"
    saveImg.style.marginRight = "15px"
    saveImg.onclick = () => zoomFig(id, true)
    divFav.append(saveImg)
    }


function createEventListeners() {
    var leftarrow = document.getElementById("leftarrow");
    if (leftarrow.addEventListener) {
        leftarrow.addEventListener("click", leftArrow, false);
    } else if (leftarrow.attachEvent) {
        leftarrow.attachEvent("onclick", leftArrow);
    }

    var rightarrow = document.getElementById("rightarrow");
    if (rightarrow.addEventListener) {
        rightarrow.addEventListener("click", rightArrow, false);
    } else if (rightarrow.attachEvent) {
        rightarrow.attachEvent("onclick", rightArrow);
    }
    document.querySelector('#fig3').querySelector('img').onclick = () => zoomFig(photoOrder[2], false)


    var showAllButton = document.querySelector("#fiveButton p");
    if (showAllButton.addEventListener) {
        showAllButton.addEventListener("click", previewFive, false);
    } else if (showAllButton.attachEvent) {
        showAllButton.attachEvent("onclick", previewFive);
    }

    window.addEventListener('message', event => {
        const data = event.data.split(' ')
        if (data.length < 2) {
            console.log('invalid data:', data)
        }
        else if (data[0] === 'add') {
            addToFav(data[1])
        }
        else if (data[0] === 'remove') {
            removeFav(data[1])
        }
        else {
            console.log('invalid data:', data)
        }
    })
        }

function setUpPage() {
    createEventListeners();
    populateFigures();
}
if (window.addEventListener) {
    window.addEventListener("load", setUpPage, false);
} else if (window.attachEvent) {
    window.attachEvent("onload", setUpPage);
}
