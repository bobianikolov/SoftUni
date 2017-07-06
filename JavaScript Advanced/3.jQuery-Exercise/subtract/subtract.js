/**
 * Created by Bobi on 07/06/2017.
 */
$(document).ready(function () {
   
    let firstNumber = $('#firstNumber').val();
    let secondNumber = $('#secondNumber').val();
    let result = $('#result');
    
    let subtract = firstNumber - secondNumber;
    result.text(subtract);
});