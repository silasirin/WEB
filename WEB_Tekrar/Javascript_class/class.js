//class Product {
//    productName;
//    unitPrice;
//    unitsInStock;
//}

//var product = new Product();
//product.productName = "Chai";
//product.unitPrice = 15;
//product.unitsInStock = 500;
//console.log(product);

class Product {
    constructor(_productName, _unitPrice) {
        this.ProductName = _productName; //this: product isimli class'ta bulunan property'yi temsil eder.
        this.UnitPrice = _unitPrice;
    }

    info() { //class icerisinde function olustururken basinda function kelimesi kullanilmaz.
        return this.ProductName + " " + this.UnitPrice;
    }

    //Urun fiyatini %18 KDV ile birlikte gosterme fonksiyonu:
    vat() {
        var price = this.UnitPrice * 1.18;
        return price;
    }
}

var productOne = new Product("Chai", 18);
var productTwo = new Product("Chang", 15);
//console.log(productOne); console.log(productTwo);
console.log(productOne.info());
console.log(productOne.vat());



