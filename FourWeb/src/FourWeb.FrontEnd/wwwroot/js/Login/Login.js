function Login() {
    jQuery.support.cors = true;

    var model = {
        email: $('#txtEmail').val(),
        password: $('#txtPassword').val(),
        isAdmin: true,
    };
    $.ajax({
        url: 'http://localhost:5000/connect/token',
        crossDomain: true,
        type: 'POST',
        contentType: "application/json",
        data: JSON.stringify(model),

        success: function (data) {
            localStorage.removeItem('token');
            localStorage.setItem("token", data.token);
            alert(localStorage.getItem('token'));
        },
        error: function (x, y, z) {
            alert(JSON.stringify(x) + '\n' + y + '\n' + z);
        }
    });
}
$(document).ready(function () {

    $('#btnLogin').click(function () {
        Login();
    });
    
});