var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable(jsonFilter) {
    //alert('/venproductctg/GetAll?jsonFilter=');
    dataTable = $('#tblData').DataTable({
        dom: 'trip', //l:length row perpage, i:information page, t:table, p:pagination control, s:search/filtering box, r: processing display element
        "ajax": {
            "url": "/dtetransfer/GetAll?jsonFilter=" + jsonFilter
        },
        "columns": [
            { "data": "dteTransferName", "width": "15%" },
            { "data": "description", "width": "15%" },
            { "data": "userCreated.userName", "width": "15%" },
            { "data": "dateCreated", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div class="d-flex order-actions">
								<a onclick="showInPopup('/dtetransfer/Upsert/${data}', 'Update Data Transfer')" class="ms-3 cursor-pointer"><i class='bx bxs-edit'></i></a>
								<a onClick="Delete('/dtetransfer/Delete/${data}')" class="ms-3 cursor-pointer"><i class='bx bxs-trash'></i></a>
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
