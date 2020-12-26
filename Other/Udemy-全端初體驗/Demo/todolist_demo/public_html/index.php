<?php include('header.php')?>
<?php include('data.php') ?>
<?php require 'vendor/autoload.php' ?>
<div id="panel">
	<h1>Todo Loist</h1>
<?php d($todos); ?>
	<div id="todolist">
		<ul style="	padding: 0;	margin: 0; list-style-type: none;">
	
	
		    
		    <li class="new"> 
				<div class="checkbox"></div>
				<?php// contenteditable 給使用者直接打打字的地方 輸入框?>
				<div class="content" contenteditable="true"></div>
			</li>
		</ul>
	</div>

</div>


<!-- handlebars script中如果要註解方式如下 {‌{!-- 註解內容 --}} -->
<!-- script不會顯示塞在越後面越好 讓其他語法早點顯示在畫面上 -->
<!-- handlebars的 IF 如果 TURE 印 complete{{#if is_complete}}complete{{/if}} -->
<!-- 應對排序 在 li 裡偷藏id data-id="{{id}}" -->
<script id="todo-list-item-temp" type="text/x-handlebars-template">
   <li data-id="{{id}}" class="{{#if is_complete}}complete{{/if}}">
      <div class="checkbox"></div>
	  <div class="content">{{content}}</div>
	  <div class="actions">
	    <div class="delete">X</div>
	  </div>
   </li>
</script>

<?php include('footer.php')?>