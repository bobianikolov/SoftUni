/**
 * Created by Bobi on 07/06/2017.
 */
$(document).ready(function () {

    let start = $('#start-timer');
    let stop = $('#stop-timer');
    let time;
    let timer;

    start.on('click', function (ev) {

        start.prop('disabled', 'true');
        time = -0;
        timer = setInterval(step, 1000);
    });

    stop.on('click', function (event) {

        start.prop('disabled', 'false');
        timer = clearInterval(timer);
    });

    function step() {
        time++;
        $('#hours').text(('0' + Math.trunc(time / 3600)).slice(-2));
        $('#minutes').text(('0' + Math.trunc(time / 60)).slice(-2));
        $('#seconds').text(('0' + Math.trunc(time % 60)).slice(-2));
    }
});