function pay() {
  var backpack = document.getElementById('backpack').value;
  var slingbag = document.getElementById('slingbag').value;
  var total = backpack * 65 + slingbag * 45;
  var span = document.getElementById('totalAmount');
  span.innerText = '$' + total;
}

function payment() {
  alert('Payment Success');
}
