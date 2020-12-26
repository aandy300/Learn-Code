$(document).ready(function()
{

var panel = 
{
	el: '#info-panel',
	open: function(isNEW,e)
	{
		$(panel.el).addClass('open').css({
	  		top: e.pageY+'px',
	  		left: e.pageX+'px',
  	    }).find('.title [contenteditable]').focus();

  	    panel.updateDate(e);

		if(isNEW)
  	       $(panel.el).addClass('new').removeClass('update');
  		else
  		   $(panel.el).addClass('update').removeClass('new');
  	},
  	close: function(){	$(panel.el).removeClass('open'); },
  	updateDate: function(e){
  		if ($(e.currentTarget).is('.date-block'))
  			var date = $(e.currentTarget).data('date');
  		else
  			var date = $(e.currentTarget).closest('.date-block').data('date');

  		var month = $('#calendar').data('month');

  		$(panel.el).find('.month').text(month);
  		$(panel.el).find('.date').text(date);
  		$(panel.el).find('[name="month"]').val(month);
  		$(panel.el).find('[name="date"]').val(date);
  	},
};
	$('.date-block').dblclick(function(e){
		panel.open(true,e);
	}).on('dblclick','.events',function(e){
		e.stopPropagation();
		panel.open(false,e);
	});
 	
  	$(panel.el)
	.on('click','button',function(e){
	   if($(this).is('.create')){
	   		var data = $(panel.el).find('form').serialize();
		   	// $.post('create.php',{data},function(data,textStatus,xhr ){ 
		   	// });
	   }
	   if($(this).is('.update')){
	   	
	   }
	   if($(this).is('.cancel')){
	   	  panel.close();
	   }
	   if($(this).is('.delete')){
	   	
	   }
    })
    .on('click','.close',function(e){
       $('button.cancel').click();
    });

});


