$(document).ready(function () {

    $('#btn-add').on('click', function (ev) {
        "use strict";

        let text = document.getElementById('enter-text').value;
        let li = document.createElement('li');
        li.textContent = text;

        document.getElementById('items').appendChild(li);
        document.getElementById('enter-text').value = '';
    });
});