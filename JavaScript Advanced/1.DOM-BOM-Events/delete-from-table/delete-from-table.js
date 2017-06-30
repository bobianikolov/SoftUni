$(document).ready(function () {

    $('#btn-delete').on('click', function () {
        "use strict";

        let allEmails = document.querySelectorAll('#customers tr td:nth-child(2)');
        let searchEmail = document.getElementsByName('email')[0].value;

        for (let email of allEmails) {
            if (email.textContent == searchEmail) {
                let row = email.parentNode;
                row.parentNode.removeChild(row);
                document.getElementById('result').textContent = 'Deleted.';
                document.getElementsByName('email')[0].value = '';
                return;
            }
        }
        document.getElementById('result').textContent = 'Not found.';
        document.getElementsByName('email')[0].value = '';

    });
});