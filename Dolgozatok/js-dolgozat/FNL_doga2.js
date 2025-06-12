let tomb = [5,10,20,50,100,200];

// [a..b] intervallumból egy random egész
function random(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

function megjelenit() {
    const db = random(2, 8);
    const p = document.querySelector("p");
    p.innerText = db;
    p.style.color = "red";
    p.style.backgroundColor = "rgb(255, 255, 0)";
    
    const kepekDiv = document.querySelector("#ermekDiv");
    kepekDiv.innerText = "";
    let osszeg = 0;
    for (let i = 0; i < db; i++) {
        const penz = tomb[random(0, tomb.length-1)];
        const img = document.createElement("img");
        img.src = `kepek/${penz}.png`; // template literal
        img.style.width = "50px";
        kepekDiv.appendChild(img);
        osszeg += penz;
    }

    const osszegDiv = document.querySelector("#osszegDiv");
    osszegDiv.innerText = osszeg;
}