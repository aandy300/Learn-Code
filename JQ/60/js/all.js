$(document).ready(function() {
    console.log( "ready!" );
    $('a').click(function (e) { 
        e.preventDefault();
        alert('123') 
    });
    // $('.swiper-slide').click(function (e) { 
        // e.preventDefault();
        // alert('123') 
    // });
});