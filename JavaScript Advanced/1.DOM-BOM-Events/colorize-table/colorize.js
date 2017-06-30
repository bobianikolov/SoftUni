$(document).ready(function () {

    $('#btn-colorize').on('click', function (ev) {
        let allRows = document.querySelectorAll('.table-info tbody tr');

        for (var i = 0; i < allRows.length; i++) {
            if (i % 2 == 0) {
                allRows[i].style.backgroundColor = 'rgb(239, 223, 98)';
            }
        }
    });
});