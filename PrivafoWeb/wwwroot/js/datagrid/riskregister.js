var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/RiskRegister/GetAll"
        },
        "columns": [
            { "data": "riskRegName", "width": "15%" },
            { "data": "description", "width": "15%" },
            { "data": "threat", "width": "15%" },
            { "data": "threat", "width": "15%" },
            { "data": "riskMatrix.score", "width": "15%" },
            { "data": "riskMatrix.score", "width": "15%" },
            { "data": "threat", "width": "15%" },
            { "data": "threat", "width": "15%" },
            { "data": "threat", "width": "15%" },
            { "data": "threat", "width": "15%" }
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