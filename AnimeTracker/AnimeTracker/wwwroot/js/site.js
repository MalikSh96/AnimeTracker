// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Datatable functionality --> applied to only AllAnime.cshtml and Search.cshtml
$(document).ready(function () {
    $('#datatable').DataTable({
        "lengthMenu": [[5, 10, 20, -1], [5, 10, 20, "All"]]
        //processing: true,
        //ordering: true,
        //paging: true,
        //searching: true,
        //ajax: "api/Products",
        //columns: [
        //    { "data": "productId" },
        //    { "data": "name" },
        //    { "data": "productNumber" },
        //    { "data": "color" },
        //    { "data": "listPrice" }
        //]
    });
});