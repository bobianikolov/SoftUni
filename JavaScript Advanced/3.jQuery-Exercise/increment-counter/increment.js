$(document).ready(function () {
    
    let body = $('#wrapper');
    
    let textArea = $('<textarea>');
    textArea.addClass('counter')
        .val(0)
        .attr('disabled', 'true');

    let incrementButton = $('<button>Increment</button>');
    incrementButton.addClass('btn')
        .attr('id','incrementBtn');

    let addButton = $('<button>Add</button>');
    addButton.addClass('btn')
        .attr('id','addBtn');

    let ul = $('<ul>');
    ul.addClass('results');

    body.append(textArea);
    body.append(incrementButton);
    body.append(addButton);
    body.append(ul);

    incrementButton.on('click', function (event) {
        "use strict";

        let value = parseInt(textArea.val());
        textArea.val(++value);
    });

    addButton.on('click', function (ev) {
        "use strict";

        let li = $('<li>');
        li.text(textArea.val());
        ul.append(li);
    });
});