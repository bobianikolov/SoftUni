/**
 * Created by Bobi on 07/05/2017.
 */
$(document).ready(function () {

    $('#items').on('click', 'li', function () {
       let li = $(this);

        if(li.attr('data-selected')){
            li.removeAttr('data-selected');
            li.css('background', '')
        }else {
            li.attr('data-selected', 'true');
            li.css('background', '#DDD');
        }
    });

    $('#showTownsButton').on('click', function (ev) {
        "use strict";

        let selectedLi = $('#items li[data-selected=true]');
        let result = selectedLi.toArray().map(li => li.textContent).join(", ");
        $('#selectedTowns').text("Selected towns: " + result);
    });
});