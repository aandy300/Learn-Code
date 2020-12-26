<?php 
// this by calendar
// include('../db.php');
// try {
// $pdo = new PDO("mysql:host=$db[host];dbname=$db[dbname];port=$db[port]charset=$db[charset]",
// 	$db['username'],$db['password']);}
// /* 捕獲錯誤 如有存到 PDOException $e裡 並印出 error*/
//    catch(PDOException $e){
//    echo "error";
//    exit;
//}
$week = array('SUN','MON','TUE','WED','THU','FRI','SAT');

$dates = [];
for ($i=1; $i<=31; $i++){
	$dates[] = $i;
}
$dates[] = null;
$dates[] = null;
$dates[] = null;
$dates[] = null;

?>


