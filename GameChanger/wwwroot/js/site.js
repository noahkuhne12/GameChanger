$(document).ready(function () {
    $(window).trigger("resize");
});
$(window).resize(function () {
    var videoWidh = $(".video").width();
    $(".video").css("height", videoWidh / 16 * 9 + "px");
});
