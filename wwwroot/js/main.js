jQuery(document).ready(function ($) {

    $('.login-form').validate({
        rules: {
            username: {
                required: true,
                maxlength: 40,
                minlength: 2,
                Uppercase: true
            },
            pass: {
                required: true,
                minlength: 6,
                maxlength: 20,
            },

        },
        messages: {
            username: {
                required: 'User name is required',
                minlength: 'No less than 2 letters',
                maxlength: 'Max letters:40',

            },
            pass: {
                minlength: 'Password must contain at least 8 characters',
                required: 'Please give a password',
            },
        }
    });

    $.validator.addMethod("Uppercase", function (value, element) {
        return this.optional(element) || /[Α-Ω]\S+/.test(value);
    }, "First letter must be upercase");


    $(function () {
        $("#slider-range").slider({
            range: true,
            min: 0,
            max: 500,
            values: [75, 300],
            slide: function (event, ui) {
                $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
            }
        });
        $("#amount").val("$" + $("#slider-range").slider("values", 0) +
            " - $" + $("#slider-range").slider("values", 1));
    });

    var picker2months = new Pikaday(
        {
            numberOfMonths: 2,
            field: document.getElementById('datepicker-2months'),
            firstDay: 1,
            minDate: new Date(2000, 0, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [2000, 2020]
        });

    var picker3monthsRight = new Pikaday(
        {
            numberOfMonths: 3,
            mainCalendar: 'right',
            field: document.getElementById('datepicker-3months-right'),
            firstDay: 1,
            minDate: new Date(2000, 0, 1),
            maxDate: new Date(2020, 12, 31),
            yearRange: [2000, 2020]
        });

});