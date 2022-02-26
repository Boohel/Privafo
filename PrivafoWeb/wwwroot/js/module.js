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
            .addClass("is-inactive")
            .find(".js-expander").html("Show Description");;
        $thisCell.removeClass("is-collapsed").removeClass("is-inactive").addClass("is-expanded");
        $thisCell.find(".js-expander").html("Hide Description");
    } else {
        $thisCell.removeClass("is-expanded").addClass("is-collapsed");
        $cell.not($thisCell).removeClass("is-inactive");
        $cell.find(".js-expander").html("Show Description");
    }
});

//close module when click on cross
$cell.find(".js-collapser").click(function () {
    var $thisCell = $(this).closest(".module");

    $thisCell.removeClass("is-expanded").addClass("is-collapsed");
    $cell.not($thisCell).removeClass("is-inactive");
    $cell.find(".js-expander").html("Show Description");
});
