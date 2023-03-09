$(document).ready(function () {
    console.log("ready!");
    const myModal = new bootstrap.Modal(document.getElementById('myModal'), options)


    $("#CadastraMedicamento").click(function CadastraRemedioClica(){
        console.log("funcionei");

    });
});


function showModal(elementID) {
    if (elementID != null && elementID != undefined) {
        let modalElement = document.getElementById(elementID);
        modalElement.style.display = "block";
        return "ok";
    } else {
        return "error";
    }
}