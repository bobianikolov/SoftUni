$(document).ready(function () {

    let body = $('#content');
    body.addClass('items-control');

    let addDiv = $('<div>').addClass('add-controls');
    let labelAdd = $('<label>').text('Enter text: ').append($('<input>'));
    let btnAdd = $('<button>Add</button>').attr('display', 'inline-block').on('click', addItem);
    addDiv.append(labelAdd);
    addDiv.append(btnAdd);
    body.append(addDiv);

    let searchDiv = $('<div>').addClass('search-controls');
    let labelSearch = $('<label>').text('Search: ').append($('<input>')).on('input', search);
    searchDiv.append(labelSearch);
    body.append(searchDiv);

    let resultDiv = $('<div>').addClass('result-controls');
    let ul = $('<ul>').addClass('items-list');
    let li = $('<li>').addClass('list-item');
    let a = $('<a>').addClass('button').text('X').on('click', deleteItem);
    let strong = $('<strong>Element 1</strong>');
    li.append(a);
    li.append(strong);
    ul.append(li);
    resultDiv.append(ul);
    body.append(resultDiv);

    function addItem() {
        let textInput = $('.add-controls label input').val();
        console.log(textInput);

        let ul = $('<ul>').addClass('items-list');
        let li = $('<li>').addClass('list-item');
        let a = $('<a>').addClass('button').text('X').on('click', deleteItem);
        let strong = $('<strong>').text(textInput);
        li.append(a);
        li.append(strong);
        ul.append(li);
        resultDiv.append(ul);
        body.append(resultDiv);
        $('.add-controls label input').val('');
    }

    function deleteItem() {
        $(this).parent().remove();
    }

    function search() {
        let listItem = $('.result-controls ul li strong').toArray(li => li.text );
        let currentText = $('.search-controls label input').val();

        console.log(currentText);

        for (var i = 0; i < listItem.length; i++) {
            if(listItem[i].innerText.search(currentText) == -1){
                $(listItem[i]).parent().hide();
            } else {
                $(listItem[i]).parent().show();
            }
        }
    }
});