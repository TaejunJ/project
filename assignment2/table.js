
function CreateTable() {

    var table = document.createElement("TABLE");
    table.border = "1";
    var columnCount = 15;
    var row = table.insertRow(-1);
    for (var i = 0; i < columnCount; i++) {
        var headerCell = document.createElement("TH");
        headerCell.innerHTML = '<input type="number" name="number" size="3" maxlength="3">';
        row.appendChild(headerCell);
    }
    for (var i = 1; i < 15; i++) {
        row = table.insertRow(-1);
        for (var j = 0; j < columnCount; j++) {
            var cell = row.insertCell(-1);
            cell.innerHTML = '<input type="number" name="number" size="3" maxlength="3">';
        }
    }
    var dvTable = document.getElementById("dvTable");
    dvTable.innerHTML = "";
    dvTable.appendChild(table);