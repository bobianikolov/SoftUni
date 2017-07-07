$(document).ready(function () {

    calendar([15, 1, 2015]);

    function calendar([day,month,year]) {

        let toDay = new Date(year, month - 1, day);
        let monthNames = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        let captionContent = monthNames[toDay.getMonth()] + ' ' + toDay.getFullYear();

        let bodyMonth = $('#content');
        let caption = $('<caption>').text(captionContent);
        let table = $('<table>');
        let tBody = $('<tbody>');
        let tr = $('<tr>');
        let mon = $('<td>').text('Mon');
        let tue = $('<td>').text('Tue');
        let wed = $('<td>').text('Wed');
        let thu = $('<td>').text('Thu');
        let fri = $('<td>').text('Fri');
        let sat = $('<td>').text('Sat');
        let sun = $('<td>').text('Sun');
        tr.append(mon).append(tue).append(wed).append(thu).append(fri).append(sat).append(sun);

        tBody.append(tr);
        table.append(caption);
        table.append(tBody);
        bodyMonth.append(table);

        let numberOfDay = 0;
        let lastDayInMonth = new Date(year, month, 0);
        numberOfDay += lastDayInMonth.getDate();
        let prevMonthDay = new Date(year, month - 1, 0).getDay();
        let nextMonthDay = (7 - new Date(year, month, 0).getDay() % 7) % 7;
        numberOfDay += prevMonthDay + nextMonthDay;

        let daysCounter = 0 - prevMonthDay + 1;

        for (var i = 0; i < numberOfDay / 7; i++) {
            tBody.append($('<tr>'));

            for (var j = 0; j < 7; j++) {
                let currentDay;

                if (daysCounter < 1 || daysCounter > lastDayInMonth.getDate()) {
                    currentDay = '';
                } else {
                    currentDay = daysCounter;
                }

                if (currentDay == toDay.getDate()) {
                    $('tbody tr:last-child').append($('<td>').addClass('today').text(currentDay));
                } else {
                    $('tbody tr:last-child').append($('<td>').text(currentDay));
                }
                daysCounter++;
            }
        }
    }
});