showInPopup = (url, title) => {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            $('#form-modal .modal-body').html(res);
            $('#form-modal .modal-title').html(title);
            $('#form-modal').modal('show');
        }
    })
}

jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $('#view-all').html(res.html);
                    $('#form-modal .modal-body').html('');
                    $('#form-modal .modal-title').html('');
                    $('#form-modal').modal('hide');
                    loadDataTable();

                    toastr.options = {
                        "closeButton": true,
                        "progressBar": true
                    }
                    toastr.success(res.msg);
                }
                else {
                    $('#form-modal .modal-body').html(res.html);

                    toastr.options = {
                        "closeButton": true,
                        "progressBar": true
                    }
                    toastr.error(res.msg);
                }
            },
            error: function (err) {
                console.log(err)
            }
        })
        //to prevent default form submit event
        return false;
    } catch (ex) {
        console.log(ex)
    }
}

var exampleJsonFilterList = [
    { type: "text", id: "Lastname", label: "Lastname" },
    { type: "text", id: "Firstname", label: "Firstname" },
    { type: "boolean", id: "active", label: "Is active" },
    { type: "number", id: "age", label: "Age" },
    {
        type: "list", id: "category", label: "Category",
        list: [
            { id: '1', label: "Family" },
            { id: '2', label: "Friends" },
            { id: '3', label: "Business" },
            { id: '4', label: "Acquaintances" },
            { id: '5', label: "Other" }
        ]
    },
    { type: "date", id: "bday", label: "Birthday" },
    { type: "text", id: "phone", label: "Phone" },
    { type: "text", id: "cell", label: "Mobile" },
    { type: "text", id: "Address1", label: "Address" },
    { type: "text", id: "City", label: "City" },
    {
        type: "list", id: "State", label: "State",
        list: [
            { id: "AL", label: "Alabama" },
            { id: "AK", label: "Alaska" },
            { id: "AZ", label: "Arizona" }
        ]
    },
    { type: "text", id: "Zip", label: "Zip" },
    {
        type: "list", id: "Country", label: "Country",
        list: [
            { label: 'Afghanistan', id: 'AF' },
            { label: 'Åland Islands', id: 'AX' }
        ]
    }
]

showFilterSide = (url, title) => {
    $.ajax({
        type: 'GET',
        url: url,
        success: function (res) {
            //$('#filter-side .filter-body-content').html(res.html);
            $('#filter-side .filter-title').html(title);
            $(".switcher-filter").toggleClass("switcher-filter-toggled");
            $('#myFilter').structFilter({
                fields: res.fields
            })
        }
    })
}

$(function () {
    $(document).bind('ajaxStart', function () {
        //action
    }).bind('ajaxStop', function () {
        //action
    });
});