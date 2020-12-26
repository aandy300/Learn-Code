PHP 語法 ------------

php date http://php.net/manual/en/function.date.php

<?= date('Y')?> Examples: 1999 or 2003
<?= date('m')?>           01 through 12

php array 製作 ----------------

@ 指定名稱自行填入

$week = array('SUN','MON','TUE','WED','THU','FRI','SAT');
                            //保存值的名稱自訂
<?php foreach ($week as $key => $weekday): ?>
    <div class="day"><?= $weekday ?></div>              
<?php endforeach ?>

@ 數字自動增加

$dates = [];
for ($i=1; $i<=31; $i++){
    $dates[] = $i;
}

<?php foreach ($dates as $key => $date): ?>
    <div class="day"><?= $date ?></div> 
<?php endforeach ?>

@ 追加數值

<?php
$a=array("red","green");
array_push($a,"blue","yellow");
print_r($a);
?>

$a = Array ( [0] => red [1] => green [2] => blue [3] => yellow )

@ 判斷式 Conditional (ternary) operator JavaScript 和 PHP 都有

function getFee(isMember) {
  return (isMember ? "$2.00" : "$10.00");
}

console.log(getFee(true));
// expected output: "$2.00"

console.log(getFee(false));
// expected output: "$10.00"

console.log(getFee(1));
// expected output: "$2.00"