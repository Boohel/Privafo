var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        dom: 'trip', //l:length row perpage, i:information page, t:table, p:pagination control, s:search/filtering box, r: processing display element
        "ajax": {
            "url": "/RiskCtg/GetAll"
        },
        "columns": [
            { "data": "riskCtgName", "width": "15%" },
            { "data": "description", "width": "15%" },
            { "data": "userCreated.userName", "width": "15%" },
            { "data": "dateCreated", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="d-flex order-actions">
								<a href="/RiskCtg/Upsert?ID=${data}" class=""><i class='bx bxs-edit'></i></a>
								<a onClick="Delete('/RiskCtg/Delete/${data}')" class="ms-3 cursor-pointer"><i class='bx bxs-trash'></i></a>
							</div>
                        `
                },
                "width": "10%"
            }
        ]
    });
}

$('#areaSearch').on('keyup click', function () {
    dataTable.search($('#areaSearch').val()).draw();
});


