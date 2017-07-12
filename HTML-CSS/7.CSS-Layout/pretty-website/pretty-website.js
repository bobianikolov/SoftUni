$(document).ready(function () {

    // News - first see more...
    let firstText = $('.see-more-text-first');
    let seeMoreFirst = $('.see-more-first');
    seeMoreFirst.click(function (ev) {
        ev.preventDefault();
        ev.stopPropagation();
        firstText.show();
        seeMoreFirst.hide();
    });

    $('.hide-text-first').click(function (ev) {
        firstText.css('display', 'none');
        seeMoreFirst.css('display', 'block');
    });

    // News second see more...
    let secondText = $('.see-more-text-second');
    let seeMoreSecond = $('.see-more-second');
    seeMoreSecond.click(function (ev) {
        ev.preventDefault();
        ev.stopPropagation();
        secondText.show();
        seeMoreSecond.hide();
    });
    $('.hide-text-second').click(function (ev) {
        secondText.css('display', 'none');
        seeMoreSecond.css('display', 'block');
    });

    // News third see more...
    let thirdText = $('.see-more-text-third');
    let seeMoreThird = $('.see-more-third');
    seeMoreThird.click(function (ev) {
        ev.preventDefault();
        ev.stopPropagation();
        thirdText.show();
        seeMoreThird.hide();
    });
    $('.hide-text-third').click(function (ev) {
        thirdText.css('display', 'none');
        seeMoreThird.css('display', 'block');
    });

          // last right article - messages
    let testimonials = $('.see-more-testimonials');
    $(testimonials).click(function (ev) {
        $('.list-testimonials').show();
        testimonials.hide();
    });

    $('.hide-list').click(function (event) {
        $('.list-testimonials').hide();
        testimonials.show();
    });
});