//class Product {
//    constructor(_id, _productName, _unitPrice, _unitsInStock) {
//        this.ID = _id;
//        this.ProductName = _productName;
//        this.UnitPrice = _unitPrice;
//        this.UnitsInStock = _unitsInStock;
//    }
//}

window.onload = function () {
    ProductList.getProducts();
}

class ProductList {

    static getProducts() {
        var sampleProducts = [{
            id: 1,
            productName: "Chai",
            unitPrice: 18,
            unitsInStock: 500
        }, {
            id: 2,
            productName: "Chang",
            unitPrice: 15,
            unitsInStock: 250
            }, {
            id: 3,
            productName: "Sakura",
            unitPrice: 21,
            unitsInStock: 300
            }]

        for (var i = 0; i < sampleProducts.length; i++) {
            ProductList.addProducts(sampleProducts[i]);
        }
    }



    static addProducts(product) {
        var productTable = document.getElementById("productTable");
        var tr = document.createElement('tr');
        /* tr.innerHTML = '<td>' + product.id + '</td>' + '<td>' + product.productName + '</td>' + '<td>' + product.unitPrice + '</td>' + '<td>' + product.unitsInStock + '</td>'*/
        tr.innerHTML = ` <tr>
                            <td>${product.id}</td>
                            <td>${product.productName}</td>
                            <td>${product.unitPrice}</td>
                            <td>${product.unitsInStock}</td>
                        </tr>`
        productTable.appendChild(tr);
    }
}