var $cell = $(".module");

//open and close module when clicked on module
$cell.find(".js-expander").click(function (event) {
    event.preventDefault();

    var $thisCell = $(this).closest(".module");

    if ($thisCell.hasClass("is-collapsed")) {
        $cell
            .not($thisCell)
            .removeClass("is-expanded")
            .addClass("is-collapsed")
            .addClass("is-inactive");
        $thisCell.removeClass("is-collapsed").addClass("is-expanded");

        if ($cell.not($thisCell).hasClass("is-inactive")) {
            //do nothing
        } else {
            $cell.not($thisCell).addClass("is-inactive");
        }
    } else {
        $thisCell.removeClass("is-expanded").addClass("is-collapsed");
        $cell.not($thisCell).removeClass("is-inactive");
    }
});

//close module when click on cross
$cell.find(".js-collapser").click(function () {
    var $thisCell = $(this).closest(".module");

    $thisCell.removeClass("is-expanded").addClass("is-collapsed");
    $cell.not($thisCell).removeClass("is-inactive");
});
