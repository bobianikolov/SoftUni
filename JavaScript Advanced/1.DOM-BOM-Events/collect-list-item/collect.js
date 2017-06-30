$(document).ready(function () {

    $('#btn-extract').on('click', function (event) {
        "use strict";

        let items = document.querySelectorAll('#items li');
        let currentItem = document.getElementById('view-element-in-text-area');
        for (var i = 0; i < items.length; i++) {
            currentItem.value += items[i].textContent + "\n";
        }
    });
});