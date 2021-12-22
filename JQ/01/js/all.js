$(document).ready(function(){
    
    // 選擇器 hmtl class id
    $('h3').hide(2000).show(2000).hide(2000);
    $('.box').hide();
    $('#box').hide();
    
    // evnt 點擊隱藏
    $('.button').click(function (e) { 
        $('p').hide();
        $('h2').toggle();
    });
    
    // evnt slideDown
    $('.button2').click(function (e) {         
        $('.text2').stop().slideToggle(9000);
    });

    // evnt fade
    // in 隱藏的打開
    // out 開啟的關閉
    $('.button3').click(function (e) {         
        $('.text3').fadeToggle(1000);
    });

    // evnt toggleClass
    // 反向增加刪除class    
    $('.button4').click(function (e) {         
        $('.text4').toggleClass('active');
    });





    $(selector).on('click', 'h1', function (e) {
        Event.preventDefault();            
    });

});