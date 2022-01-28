document.addEventListener("DOMContentLoaded", function (event) {

    document.getElementById("queryid1").addEventListener("click", function () {

        ShowFirstQuery();
        //getRaceData2();
        //getRaceData3();
    });

});


function ShowFirstQuery() {
    console.log('ShowFirstQuery called');
    $.getJSON("api/values/query1")
        .done(function (data) {
            //$.each(data, function (key, item) {
            //    // Add a list item for the product.
            //    $('<li>', { text: formatItem1(item) }).appendTo($('#displayRace1'));
            //});
            //console.log(data);
            console.log("data:",data);
            let table = document.getElementById("table1");
            generateTable(table, data);
        });
    console.log('END ShowFirstQuery called');
}

function generateTable(table, data) {
    for (let element of data) {
        let row = table.insertRow();
        for (key in element) {
            let cell = row.insertCell();
            let text = document.createTextNode(element[key]);
            cell.appendChild(text);
        }
    }
}

