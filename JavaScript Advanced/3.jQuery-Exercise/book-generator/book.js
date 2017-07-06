/**
 * Created by Bobi on 07/06/2017.
 */
$(document).ready(function () {

    let body = $('#wrapper');

    let divBook = $('<div>');
    divBook.attr('id','book1');
    divBook.attr('border', 'medium none');

    let title = $('<p>');
    title.addClass('title')
        .text('Alice in Wondeland');
    divBook.append(title);

    let author = $('<p>');
    author.addClass('author')
        .text('Lewis Carroll');
    divBook.append(author);

    let sbn = $('<p>');
    sbn.addClass('isbn')
        .text('1111');
    divBook.append(sbn);

    let buttonSelect = $('<button>Select</button>').on('click', select);
    divBook.append(buttonSelect);
    let buttonDeselect = $('<button>Deselect</button>').on('click', deselect);
    divBook.append(buttonDeselect);

    body.append(divBook);

    function select() {
        $(this).parent().css('border','2px solid blue');
    }

    function deselect() {
        $(this).parent().css('border', '');
    }
});