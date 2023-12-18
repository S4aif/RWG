// Example starter JavaScript for disabling form submissions if there are invalid fields
(() => {
    'use strict'

    // Fetch all the forms we want to apply custom Bootstrap validation styles to
    const forms = document.querySelectorAll('.needs-validation')

    // Loop over them and prevent submission
    Array.from(forms).forEach(form => {
        form.addEventListener('submit', event => {
            if (!form.checkValidity()) {
                event.preventDefault()
                event.stopPropagation()
            }

            form.classList.add('was-validated')
        }, false)
    })
})()

//----------------------------------------------------------------------------------------//

//stopwatch

// Window onload event handler
window.onload = function () {

    // Initialize seconds and tens variables
    var seconds = 00;
    var tens = 00;

    // Get HTML elements for appending tens and seconds
    var appendTens = document.getElementById("tens");
    var appendSeconds = document.getElementById("seconds");

    // Get HTML elements for buttons
    var buttonStart = document.getElementById('button-start');
    var buttonStop = document.getElementById('button-stop');
    var buttonReset = document.getElementById('button-reset');

    // Declare variable for interval
    var Interval;

    // Click event handler for start button
    buttonStart.onclick = function () {
        // Clear any existing interval
        clearInterval(Interval);
        // Set interval to call startTimer function every 10 milliseconds
        Interval = setInterval(startTimer, 10);
    }

    // Click event handler for stop button
    buttonStop.onclick = function () {
        // Clear the interval
        clearInterval(Interval);
    }

    // Click event handler for reset button
    buttonReset.onclick = function () {
        // Clear the interval
        clearInterval(Interval);
        // Reset tens and seconds
        tens = "00";
        seconds = "00";
        // Update the HTML elements
        appendTens.innerHTML = tens;
        appendSeconds.innerHTML = seconds;
    }

    // Function to start the timer
    function startTimer() {
        // Increment tens
        tens++;

        // Update HTML for tens based on its value
        if (tens <= 9) {
            appendTens.innerHTML = "0" + tens;
        }

        if (tens > 9) {
            appendTens.innerHTML = tens;
        }

        // Check if tens exceeds 99
        if (tens > 99) {
            console.log("seconds");
            // Increment seconds and reset tens
            seconds++;
            appendSeconds.innerHTML = "0" + seconds;
            tens = 0;
            appendTens.innerHTML = "0" + 0;
        }

        // Update HTML for seconds if it exceeds 9
        if (seconds > 9) {
            appendSeconds.innerHTML = seconds;
        }
    }
}


//----------------------------------------------------------------------------------------//

//rest timer

// Variables for clock animation
$step = 1;
$loops = Math.round(100 / $step);
$increment = 360 / $loops;
$half = Math.round($loops / 2);
$barColor = '#ec366b';
$backColor = '#feeff4';

// Document ready function
$(function () {
    // Initialize clock
    clock.init();
});

// Clock object
clock = {
    interval: null,

    // Initialization function
    init: function () {
        $('.input-btn').click(function () {
            // Event handler for start and stop buttons
            switch ($(this).data('action')) {
                case 'start':
                    clock.stop();
                    clock.start($('.input-num').val());
                    break;
                case 'stop':
                    clock.stop();
                    break;
            }
        });
    },

    // Function to start the clock animation
    start: function (t) {
        var pie = 0;
        var num = 0;
        var min = t ? t : 1;
        var sec = min * 60;
        var lop = sec;

        // Set initial text and class based on the input
        $('.count').text(min);
        if (min > 0) {
            $('.count').addClass('min');
        } else {
            $('.count').addClass('sec');
        }

        // Set interval for clock animation
        clock.interval = setInterval(function () {
            sec = sec - 1;

            // Calculate pie value for the circular progress
            if (min > 1) {
                pie = pie + (100 / (lop / min));
            } else {
                pie = pie + (100 / (lop));
            }

            // Reset pie value if it exceeds 100
            if (pie >= 101) { pie = 1; }

            // Calculate num value for the displayed time
            num = (sec / 60).toFixed(2).slice(0, -3);

            // Update display based on num value
            if (num == 0) {
                $('.count').removeClass('min').addClass('sec').text(sec);
            } else {
                $('.count').removeClass('sec').addClass('min').text(num);
            }

            // Calculate and set background gradient based on pie value
            $i = (pie.toFixed(2).slice(0, -3)) - 1;
            if ($i < $half) {
                $nextdeg = (90 + ($increment * $i)) + 'deg';
                $('.clock').css({ 'background-image': 'linear-gradient(90deg,' + $backColor + ' 50%,transparent 50%,transparent),linear-gradient(' + $nextdeg + ',' + $barColor + ' 50%,' + $backColor + ' 50%,' + $backColor + ')' });
            } else {
                $nextdeg = (-90 + ($increment * ($i - $half))) + 'deg';
                $('.clock').css({ 'background-image': 'linear-gradient(' + $nextdeg + ',' + $barColor + ' 50%,transparent 50%,transparent),linear-gradient(270deg,' + $barColor + ' 50%,' + $backColor + ' 50%,' + $backColor + ')' });
            }

            // Clear the interval and reset styles when time reaches 0
            if (sec == 0) {
                clearInterval(clock.interval);
                $('.count').text(0);
                $('.clock').removeAttr('style');
            }
        }, 1000);
    },

    // Function to stop the clock animation
    stop: function () {
        clearInterval(clock.interval);
        $('.count').text(0);
        $('.clock').removeAttr('style');
    }
}
