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
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="d-flex order-actions">
								<a onClick="viewSelect(${data})" class="ms-3 cursor-pointer"><i class='bx bx-search-alt-2'></i></a>
							</div>
                        `
                },
                "width": "10%"
            }
        ]
    });
}


