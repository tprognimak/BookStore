$(function () {

    $.ajaxSetup({ cache: false });

    $(".bookItem").click(function (e) {
        e.preventDefault();
        debugger;
        $.get(this.href, function (data) {
            $('#dialog').html(data);
            $('#modDialog').modal('show');
        });
    });

    $(".addBook").click(function (e) {
        e.preventDefault();
        $.get(this.href, function (data) {
            $('#dialogContent').html(data);
            $('#modDialog').modal('show');
        });
    });
})