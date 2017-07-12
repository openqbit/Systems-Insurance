$("#menu-toggle").click(function (e) {
    e.preventDefault();
    $("#wrapper").toggleClass("toggled");
});
$("#sidebar-nav").click(function (e) {
    alert('Working')
    e.preventDefault();
    $("#wrapper").toggleClass("toggled");
});