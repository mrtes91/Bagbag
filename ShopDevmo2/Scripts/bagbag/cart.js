function pay() {
    var quantity = document.getElementById('quantity_@item.ProductId').value;
    var price = document.getElementById('price').value;
    var total = quantity * price;
    var span = document.getElementById('totalAmount');
    span.innerText = '$' + total;
}

function payment() {
    alert('Payment Success');
}
