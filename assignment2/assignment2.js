function defaultTable() {
    var tb = document.getElementById("defaultTable");
    var table = document.createElement("table");
    table.style.width = '100%';
    table.style.border = '1.5px solid black';
    table.style.textAlign = 'center';
    for (var r = 0; r <= 15; ++r) {
        var tr = table.insertRow(-1);
        for (var c = 0; c <= 15; c++) {
            var td = tr.insertCell();
            td.appendChild(document.createTextNode(`${r},${c}`));
            td.style.border = '1.5px solid black';
        }
        tb.appendChild(table);
    }
} 
function CreateTable() {
    var maxRows = 16;
    var maxCols = 16;
    var rows = document.getElementById('rows').value;
    var cols = document.getElementById('cols').value;
    var tbl = document.getElementById("Table");
    var table = document.createElement("table");
    table.style.width = '100%';
    table.style.border = '1.5px solid black';
    table.style.textAlign = 'center';
    if (rows < maxRows || cols < maxCols) {
        for (var r = 0; r <= rows; ++r) {
            var tr = table.insertRow(-1);

            for (var c = 0; c <= cols; c++) {
                var td = tr.insertCell();
                td.appendChild(document.createTextNode(`${r},${c}`));
                td.style.border = '1.5px solid black';
            }
            tbl.appendChild(table);
        }
    } else window.alert("Please enter number less than 15")
    
}
window.addEventListener('load', defaultTable, false);
document.getElementById("DrawTable").addEventListener('click', CreateTable, false);