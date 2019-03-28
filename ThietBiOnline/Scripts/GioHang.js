let increaseValue = maSanPham => {
    var value = parseInt(document.getElementById(maSanPham).value, 10);
    value = isNaN(value) ? 0 : value;
    value++;
    document.getElementById(maSanPham).value = value;
    updateProductPrice(maSanPham, value);
};

let decreaseValue = maSanPham => {
    var value = parseInt(document.getElementById(maSanPham).value, 10);
    value = isNaN(value) ? 0 : value;
    value == 1 ? value = 1 : value--;
    document.getElementById(maSanPham).value = value;
    updateProductPrice(maSanPham, value);
};

let updateProductPrice = (maSanPham, soLuong) => {
    $.ajax({
        type: 'POST',
        url: '/GioHang/UpdateGioHang',
        dataType: 'json',
        data: { "maSanPham": maSanPham, "soLuong": soLuong },
        success: function (response) {
            document.getElementsByClassName(maSanPham)[0].innerHTML = response['ThanhTien'];
            document.getElementById('TongTien').innerHTML = response['TongTien'];
        }
    })
};

let formSubmit = maSanPham => {
    debugger;
    document.forms[maSanPham].submit();
};