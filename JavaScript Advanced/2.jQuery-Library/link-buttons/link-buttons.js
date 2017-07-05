$(document).ready(function () {

    $('.button').on('click', function (ev) {
        "use strict";

        $('.selected').removeClass('selected');
        $(this).addClass('selected');
    });
});