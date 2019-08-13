$(window).scroll(function () {
    if ($(document).scrollTop() > 40) {
        $('#navigation').addClass("solid");
        $('#logo').addClass("solidLogo");
    }
    else {
        $('#navigation').removeClass("solid");
        $('#logo').removeClass("solidLogo");
    }
});