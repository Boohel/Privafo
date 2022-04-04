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
            { "data": "org.orgName", "width": "15%" },
            { "data": "riskType.riskTypeName", "width": "15%" },
            { "data": "residualRiskScore.score", "width": "15%" },
            { "data": "InherentRiskScore.score", "width": "15%" },
            { "data": "threat", "width": "15%" },
            { "data": "userOwner.userName", "width": "15%" },
            { "data": "threat", "width": "15%" },
            { "data": "threat", "width": "15%" }
        ]
    });
}