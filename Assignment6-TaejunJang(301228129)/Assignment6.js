var selectedCity = document.querySelector("#city");
var btn = document.querySelector("#search");
var city = document.querySelector("#cityOut");
var descrip = document.querySelector("#description");
var temp = document.querySelector("#temp");
var wind = document.querySelector("#wind");
let locationIcon = document.querySelector('.weather-icon');

function convertion(val) {
    return (val - 273).toFixed(2)
}
btn.addEventListener('click', function () {
    fetch('https://api.openweathermap.org/data/2.5/weather?q=' + selectedCity.value + '&appid=9da7d989cd305aa637afafbd2f39e53d')
        .then(response => response.json())
        .then(data => {
            const icon = data.weather[0].icon;
            var nameval = data['name']
            var descrip = data['weather']['0']['description']
            var tempature = data['main']['temp']
            var wndspd = data['wind']['speed']
            city.innerHTML = `Weather of <span>${nameval}<span>`
            temp.innerHTML = `Temperature: <span>${convertion(tempature)} C</span>`
            description.innerHTML = `Sky Conditions: <span>${descrip}<span>`
            wind.innerHTML = `Wind Speed: <span>${wndspd} km/h<span>`
            locationIcon.innerHTML = `<img src="icons/${icon}.png">;`

        })
        .catch(() => alert('You entered Wrong city name'))
})

var city2 = document.querySelector("#cityOut2");
var descrip2 = document.querySelector("#description2");
var temp2 = document.querySelector("#temp2");
var wind2 = document.querySelector("#wind2");
let locationIcon1 = document.querySelector('.weather-icon1');


function currentWeather() {

    navigator.geolocation.getCurrentPosition(position => {
        var latitude = position.coords.latitude;
        var longitude = position.coords.longitude;
        
    fetch('https://api.openweathermap.org/data/2.5/weather?lat=' +latitude+ '&lon=' +longitude+ '&appid=9da7d989cd305aa637afafbd2f39e53d')
        .then(response => response.json())
        .then(data => {
            const icon1 = data.weather[0].icon;
            var nameval2 = data['name']
            var descrip2 = data['weather']['0']['description']
            var tempature2 = data['main']['temp']
            var wndspd2 = data['wind']['speed']
            city2.innerHTML = `Weather of <span>${nameval2}<span>`
            temp2.innerHTML = `Temperature: <span>${convertion(tempature2)} C</span>`
            description2.innerHTML = `Sky Conditions: <span>${descrip2}<span>`
            wind2.innerHTML = `Wind Speed: <span>${wndspd2} km/h<span>`
            locationIcon1.innerHTML = `<img src="icons/${icon1}.png">;`
        })
    });
} window.addEventListener("load",currentWeather,false);