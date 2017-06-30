function calc() {
    "use strict";

    let numOne = document.getElementById('number-one').value;
    let numTwo = document.getElementById('number-two').value;
    let result = Number(numOne) + Number(numTwo);

    document.getElementById('sum').value = result;
}