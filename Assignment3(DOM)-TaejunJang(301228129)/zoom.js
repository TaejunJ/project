"use strict";
const params = window.location.hash.substring(1)
    .split('&')
    .map(v => v.split('='))
    .reduce((pre, [key, value]) => ({ ...pre, [key]: value }), {})
const id = params['id']
const fav = params['fav'] === 'true'

function pageSetup() {
    document.getElementsByTagName("img")[0].src = `./images/fish${id}.jpg`
    document.querySelector('footer #close').onclick = () => window.close()
    if (fav) {
        const rmv = document.querySelector('footer #remove')
        rmv.removeAttribute('hidden')
        rmv.onclick = () => {
            window.opener.postMessage(`remove ${id}`, '*')
            window.close()
        }
    } else {
        const add = document.querySelector('footer #favorite')
        add.removeAttribute('hidden')
        add.onclick = () => {
            window.opener.postMessage(`add ${id}`, '*')
            window.close()
        }
        }
    }

    window.onload = pageSetup;