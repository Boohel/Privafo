var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/DPIA/GetAll"
        },
        "columns": [
            { "data": "templateName","width": "40%"},
            { "data": "description", "width": "50%"},
            {
                "data": "icon",
                "render": function (data) { return `<div></div>` }
            },
            {
                "data": "welcome",
                "render": function (data) { return `<div></div>` }
            },
            {
                "data": "questionJSON",
                "render": function (data) { return `<div></div>`}
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="d-flex order-actions">
								<a href="/DPIA/Upsert?ID=${data}" class=""><i class='bx bxs-edit'></i></a>
								<a onClick="Delete('/DPIA/Delete/${data}')" class="ms-3 cursor-pointer"><i class='bx bxs-trash'></i></a>
							</div>
                        `
                },
                "width": "10%"
            }
        ]
    });
}


function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.options = {
                            "closeButton": true,
                            "debug": false,
                            "newestOnTop": true,
                            "progressBar": true,
                            "preventDuplicates": true,
                            "showDuration": "300",
                            "hideDuration": "1000",
                            "timeOut": "3000",
                            "extendedTimeOut": "1000",
                        }
                        toastr.success(data.message);
                    } else {
                        toastr.options = {
                            "closeButton": true,
                            "debug": false,
                            "newestOnTop": true,
                            "progressBar": true,
                            "preventDuplicates": true,
                            "showDuration": "300",
                            "hideDuration": "1000",
                            "timeOut": "3000",
                            "extendedTimeOut": "1000",
                        }
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}