<?php include('header.php')?>
<?php include('data.php')?>
<!-- this by calendar -->
<div id="calendar" data-year="<?= date('Y')?>" data-month="<?= date('m')?>">
	<div id="header">
	   <?= date('Y')?>/<?= date('m')?>
	</div>
	<div id="days">
		<div class="week" class="clearfix">
			<?php foreach ($week as $key => $weekday): ?>
				<div class="day"><?= $weekday ?></div>				
			<?php endforeach ?>
		</div>
	<!-- 	<div class="day">SUN</div>
		<div class="day">MON</div>
		<div class="day">TUE</div>
		<div class="day">WED</div>
		<div class="day">THU</div>
		<div class="day">FRI</div>
		<div class="day">SAT</div> -->
	</div>

	<div id="dates" class="clearfix">
		<?php foreach ($dates as $key => $date): ?>
		   <div class="date-block <?= (is_null($date))? 'empty' : ''?>" data-date="<?= $date?>">
				<div class="date"><?= $date ?></div>
				<div class="events clearfix">
          <div class="title">title</div>
          <div class="from">10:00</div>
				</div>
		   </div>
		<?php endforeach ?>
	</div>
 </div>
<!-- info-panel -->
<div id="info-panel" class="update"> 
  <div class="close">x</div>	

  <form action="">
      <div class="title">
       <label>Event</label>
       <input type="text" name="title">
       </div>
    <div class="time-picker">
       <div class="selected-date">
        <span class="month"></span>/<span class="date"></span>
        <input type="hidden" name="month">
        <input type="hidden" name="date">
       </div>
       <div class="from">
          <label for="from">from</label><br>
          <input id="from" type="time" name="start_time"> 
       </div>
       <div class="to">
          <label for="to">to</label><br>
          <input id="to" type="time" name="end_time"> 
       </div>
       </div>
    <div class="description">
       <label>description</label><br>
       <textarea name="description" id="description"></textarea>
       </div>
  </form>

  
  <div class="button clearfix">
  	 <button class="create">create</button>
  	 <button class="update">update</button>
  	 <button class="cancel">cancel</button>
  	 <button class="delete">delete</button>
     </div>  
 </div>

<?php include('footer.php')?>