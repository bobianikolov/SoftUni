$(document).ready(function () {

    $('#btn-click').on('click', function (ev) {
        let searchText = $('#searchText').val();
        let count = 0;

        $('#towns li').each((index, item) => {
            "use strict";
            if (item.textContent.includes(searchText) && searchText != '') {
                $(item).css("font-weight", "bold");
                count++;
            }else {
                $(item).css("font-weight", " ");
            }
        });
        $('#searchText').val("");
        $('#result').text(count + " matches found.");
    });
});