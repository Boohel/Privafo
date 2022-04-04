var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Module/GetAll"
        },
        "columns": [
            { "data": "moduleName", "width": "15%" },
            { "data": "description", "width": "15%" },
            { "data": "moduleSort", "width": "15%" },
            { "data": "moduleImageClass", "width": "15%" },
            { "data": "moduleCtg.moduleCtgName", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="d-flex order-actions">
								<a href="/Module/Upsert?ID=${data}" class=""><i class='bx bxs-edit'></i></a>
								<a onClick="Delete('/Module/Delete/${data}')" class="ms-3 cursor-pointer"><i class='bx bxs-trash'></i></a>
							</div>
                        `
                },
                "width": "10%"
            }
        ]
    });
}