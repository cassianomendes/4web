function AddUser() {
    jQuery.support.cors = true;

    alert($('#txtPassword').val());

    var model = {
        email: $('#txtEmail').val(),
        password: $('#txtPassword').val(),
        isAdmin: true,
    };
    $.ajax({
        url: 'http://localhost:5000/api/Account',
        crossDomain: true,
        contentType: "application/json",
        type: 'POST',
        data: JSON.stringify(model),
        success: function (data) {
            alert('sucesso');
            window.location = 'login.html';
        },
        error: function (x, y, z) {
            alert(JSON.stringify(x) + '\n' + y + '\n' + z);
        }
    });
}
$(document).ready(function () {

    $('#btnRegister').click(function () {
        AddUser();
    });
    
});