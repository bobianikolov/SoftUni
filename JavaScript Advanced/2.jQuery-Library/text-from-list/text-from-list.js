$(document).ready(function () {

    $("#btn").on('click', function (ev) {
        let allLi =  $('li').toArray().map(li => li.textContent).join(", ");
        $('#result').text(allLi);
    });
});