/**
 * Created by Bobi on 07/06/2017.
 */
$(document).ready(function () {

    let checkBox = $('#checked');
    let companyInformation = $('#company-information');

    if(checkBox.css('checked', 'unchecked')){
        companyInformation.css('display', 'none')
    }

    checkBox.on('click', function () {
        companyInformation.css('display', 'block')
    });

    let username = $('#username');
    let email = $('#email');
    let password = $('#password');
    let confirmPassword = $('#confirm-password');
    let companyNumber = $('#company-number');
    let btnSubmit = $('#btn-send-information');
    let isValid = true;
    let usernameRegex = /^[0-9a-z]{3,20}/;
    let passwordRegex = /^\w{5,15}/;
    let emailRegex = /@.*\./;
    let companyNumberRegex = /^[0-9]{1}[0-9]{3}/;

    if(username.text() != usernameRegex){
        username.css('border', '2px solid red');
        isValid = false;
    }

    if(email.text() != emailRegex){
        email.css('border', '2px solid red');
        isValid = false;
    }

    if(password.text() != passwordRegex){
        password.css('border', '2px solid red');
        isValid = false;
    }

    if(confirmPassword.text() != passwordRegex){
        confirmPassword.css('border', '2px solid red');
        isValid = false;
    }

    if(companyNumber.text() != companyNumberRegex){
        companyNumber.css('border', '2px solid red');
        isValid = false;
    }
});