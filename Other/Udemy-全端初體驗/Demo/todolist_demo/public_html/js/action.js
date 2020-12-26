$(document).ready(function(){

	//先在外面準備好 不然再Function裡面每次都會執行一次
    var source = document.getElementById("todo-list-item-temp").innerHTML;
    // jquray版本尋找 var source =  $('todo-list-item-temp').html();
    var todotemplate = Handlebars.compile(source);
    
    //生成資料庫裡的 todos list
    var todoListUI = '';
    $.each(todos, function(index, todo) {
    	todoListUI = todoListUI + todotemplate(todo);
    });
    $('#todolist').find('li.new').before(todoListUI);

//  enter editor mode
$('#todolist')

.on('dblclick','.content',function(e){
    $(this).prop('contenteditable',true).focus();	
	})
.on('blur','.content',function(e){
	//確認目標最近的li class 是否為 new 是的話回傳 true 不是回傳 false	
	var isNew = $(this).closest('li').is('.new')
	if(isNew)
	{
		console.log("456");
		  // this = 事件發生的對象 = e.currentTarget
		  var todo = $(e.currentTarget).text();
		  // trim(); = 清空 空白
		  todo = todo.trim();
		// 複寫上面的 todo  注意是用 : 不是 = !!
		// 如果字串 大於0 執行以下
		// 內容轉化為handlebars辨別的內容回傳
		if(todo.length>0)
		{       
			console.log("123");
                var order = $('#todolist').find('li:not(.new)').length +1;
			  	// 呼叫  請求資料 create.php 資料會回傳至 data
			  	$.post('todo/create.php', { content: todo, order: order }, function(data, textStatus, xjr){
                todo = {
                  id: data.id,
			  	  is_complete: false,
			  	  content: todo,
                };
			  	var li = todotemplate(todo);
		        // 爬樹 擦入這個li列表裡
		        $(e.currentTarget).closest('li').before(li);
			   });
		}
       	  //清空輸入框
	  	  $(e.currentTarget).empty();
	}
	//updata
	else{
		  var id = $(this).closest('li').data('id');
		  var content = $(this).text();
          $.post('todo/updata.php', {id: id, content: content});

		  $(this).prop('contenteditable',false);
	}
    })
// Delete
.on('click','.delete',function(e){
	var result = confirm('你確定要刪除嗎?');
	if(result)
  {
    var id = $(this).closest('li').data('id');
    $.post('todo/delete.php', {id: id}, function(data, textStatus, xhr) {
	$(e.currentTarget).closest('li').remove();
	});
  }
})
.on('click','.checkbox',function(e){
	var id = $(this).closest('li').data('id');
	$.post('todo/complete.php', {id: id}, function(data, textStatus, xhr) {
	$(e.currentTarget).closest('li').toggleClass('complete');
	});
});

$('#todolist').find('ul').sortable({
	items: 'li:not(.new)',
	stop: function(){
    var orderPair = [];
    $('#todolist').find('li:not(.new)').each(function(index, li) {
       orderPair.push({
       	  id:$(li).data('id') ,
          order: index +1,
       });
     });
    
    $.post('todo/sort.php', {orderPair: orderPair}, function(data, textStatus, xhr) {
    	
    });
	},
});

});