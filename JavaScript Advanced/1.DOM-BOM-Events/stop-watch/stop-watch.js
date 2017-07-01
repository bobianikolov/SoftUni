$(document).ready(function () {
    "use strict";

    let time;
    let intervalId;
    let startButton = document.getElementById('startBtn');
    let stopButton = document.getElementById('stopBtn');

    startButton.addEventListener('click', function () {
        time = -1;
        incrementTime();
        intervalId = setInterval(incrementTime, 1000);
        startButton.disabled = true;
        stopButton.disabled = false;
    });

    stopButton.addEventListener('click', function () {
        clearInterval(intervalId);
        startButton.disabled = false;
        stopButton.disabled = true;
    });

    function incrementTime() {
        time++;
        document.getElementById('time').textContent =
            ("0" + Math.trunc(time / 60)).slice(-2) +
                ':' + ("0" + (time % 60)).slice(-2);
    }
});