var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        dom: 'trip', //l:length row perpage, i:information page, t:table, p:pagination control, s:search/filtering box, r: processing display element
        "ajax": {
            "url": "/RiskRegister/GetAll"
        },
        "columns": [
            {
                "data": "riskRegName",
                "render": function (data, type, row) {
                    return `<a href="/RiskRegister/Detail?ID=${row.id}" class="ms-3 cursor-pointer">${row.riskRegName}</a>`
                },
                "width": "15%"
            },
            { "data": "description", "width": "15%" },
            { "data": "org.orgName", "width": "15%" },
            { "data": "riskType.riskTypeName", "width": "15%" },
            {
                "data": "residualRiskLvl",
                "render": function (data) {
                    return `
                            <div class="d-flex">
                                <div>
                                    <i class="bx bxs-checkbox me-2 text-warning"></i>
                                </div>
                                <div>${data}</div>
                            </div>
                        `
                },
                "width": "15%"
            },
            {
                "data": "inherentRiskLvl",
                "render": function (data) {
                    return `
                            <div class="d-flex">
                                <div>
                                    <i class="bx bxs-checkbox me-2 text-danger"></i>
                                </div>
                                <div>${data}</div>
                            </div>
                        `
                },
                "width": "15%"
            },
            { "data": "threat", "width": "15%" },
            { "data": "userOwner.userName", "width": "15%" },
            {
                "data": "null",
                "render": function (data) {
                    return `
                            <div class="badge rounded-pill text-success bg-light-success p-2 text-uppercase px-3"><i class='bx bxs-circle me-1'></i>New</div>
                        `
                },
                "width": "15%"
            },
            {
                "data": "null",
                "defaultContent": "<i>-</i>",
                "width": "15%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="d-flex order-actions">
								<a href="/RiskRegister/Upsert?ID=${data}" class=""><i class='bx bxs-edit'></i></a>
								<a onClick="Delete('/RiskRegister/Delete/${data}')" class="ms-3 cursor-pointer"><i class='bx bxs-trash'></i></a>
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

$('#submitFilter').on('click', function () {
    var jsonFilter = JSON.stringify($('#myFilter').structFilter("val"), null, 2);
    dataTable.destroy();
    loadDataTable(jsonFilter);
    $(".switcher-filter").removeClass("switcher-filter-toggled");
});