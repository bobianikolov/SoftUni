$(document).ready(function () {

    $('#createLink').on('click', function () {
       "use strict";
        let countryText = $('#newCountryText').val();
        let countryCapital = $('#newCapitalText').val();

        let up = $("<a href='#'>[Up]</a>");
        let table = $('#countriesTable');
        let tr = $('<tr>');
        let tdCountry = $('<td>');
        tdCountry.text(countryText);
        tr.append(tdCountry);

        let tdCapital = $('<td>');
        tdCapital.text(countryCapital);
        tr.append(tdCapital);

        let action = $('<td>');
        action.append($('<a href="#">[Up]</a>').click(moveRowUp)).append(" ");
        action.append($('<a href="#">[Down]</a>').click(moveRowDown)).append(" ");
        action.append($('<a href="#">[Delete]</a>').click(deleteRow));
        tr.append(action);

        table.append(tr);

         $('#newCountryText').val('');
         $('#newCapitalText').val('');

        removeUpAndDownCommands();
    });

    function moveRowUp() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
           row.insertBefore(row.prev());
            row.fadeIn();
            removeUpAndDownCommands();
        });

    }

    function moveRowDown() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
           row.insertAfter(row.next());
            row.fadeIn();

            removeUpAndDownCommands();
        });
    }

    function deleteRow() {
        let row = $(this).parent().parent();
        row.fadeOut(function () {
            row.remove();

            removeUpAndDownCommands();
        });
    }
    
    function removeUpAndDownCommands() {
        let row = $('#countriesTable tr');

                 // show all links
        $('#countriesTable a').css('display' , 'inline');

                 // hide up link
        $(row[2]).find("a:contains('Up')").css('display', 'none');

                // hide down link
        $(row[row.length - 1]).find("a:contains('Down')").css('display', 'none');
    }
});