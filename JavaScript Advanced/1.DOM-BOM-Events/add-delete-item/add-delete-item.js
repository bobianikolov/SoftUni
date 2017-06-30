$(document).ready(function () {
    
    $('#btn-add').on('click', function (event) {
        "use strict";
        
        let currentText = document.getElementById('enter-text').value;
        let li = document.createElement('li');
        li.textContent = currentText;

        let span = document.createElement('span');
        span.innerHTML = " <a href='#'>[Delete]</a>";
        span.addEventListener('click', function () {
            let li = span.parentNode;
            li.parentNode.removeChild(li);
        });

        document.getElementById('items').appendChild(li).appendChild(span);
        document.getElementById('enter-text').value = '';
    });
});