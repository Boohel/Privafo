var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable(jsonFilter) {
    //alert('/venproductctg/GetAll?jsonFilter=');
    dataTable = $('#tblData').DataTable({
        dom: 'trip', //l:length row perpage, i:information page, t:table, p:pagination control, s:search/filtering box, r: processing display element
        "ajax": {
            "url": "/city/GetAll?jsonFilter=" + jsonFilter
        },
        "columns": [
            { "data": "cityName", "width": "15%" },
            { "data": "province.provinceName", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="d-flex order-actions">
								<a onclick="showInPopup('/city/Upsert/${data}', 'Update Data City')" class="ms-3 cursor-pointer"><i class='bx bxs-edit'></i></a>
								<a onClick="Delete('/city/Delete/${data}')" class="ms-3 cursor-pointer"><i class='bx bxs-trash'></i></a>
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
    alert(jsonFilter);
    //dataTable.destroy();
    //loadDataTable(jsonFilter);
    //$(".switcher-filter").removeClass("switcher-filter-toggled");
});
