/*Bir sayfa acildiginda tetiklenecek islemler: */
window.onload = function () {
    //array
    var sehirler = ["Istanbul", "Ankara", "Izmir"];
    var cities = ["Paris", "Londa", "Munih"];

    //length
    document.getElementById('btn1').onclick = function () {
        console.log(sehirler.length); //sag tik, incele, console'dan bakildiginda sehirler arrayinde bulunan item sayisini verir.
    }

    //Includes (c#'taki contains ile ayni)
    document.getElementById('btn2').onclick = function () {
        var result = sehirler.includes('Izmir'); //varsa true; yoksa false doner.
        if (result) {
            alert("Dizi icerisinde mevcut")
        }
        else {
            alert("Dizi icerisinde mevcut degil.")
        }
    }

    //Concat (dizileri birlestirme)
    document.getElementById('btn3').onclick = function () {
        var result = sehirler.concat(cities);
        console.log(result);
        //Sehirler dizesine, cities dizisindeki elemanlari ekler ve console'da gosterir.
    }

    //Foreach
    document.getElementById('btn4').onclick = function () {
        sehirler.forEach(function (value, index) { alert(value + " " + index) })
        //sehirler dizisinde don, dizi elemanlarini ve index numaralarini sirayla alert olarak getir.
    }

    //Pop: Diziyi son elemandan baslayarak siler. Tek tek silme islemi gerceklestirilir. Silmis oldugu elemani da bize teslim eder.
    document.getElementById('btn5').onclick = function () {
        if (sehirler.length>0) {
            var item = sehirler.pop();
            console.log(item);
            console.log(sehirler);
        }
        else {
            alert("dizide herhangi bir eleman mevcut degil.")
        }
        
    }
    //Push: Diziye sondan eleman ekler.
    document.getElementById('btn6').onclick = function () {
        var city = "Roma";
        cities.push(city);
        alert(city + " " + "eklendi!");
        console.log(cities);

    }
    //Unshift: Diziye en bastan eleman ekler.
    document.getElementById('btn7').onclick = function () {
        var city = "New York";
        cities.unshift(city);
        alert(city + " " + "eklendi!");
        console.log(cities);

    }
}