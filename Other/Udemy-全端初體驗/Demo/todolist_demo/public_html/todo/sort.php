<?php // 解說參照 Create.php
header('Content-Type: application/json; charset=utf8');
include('../../db.php');

try {
$pdo = new PDO("mysql:host=$db[host];dbname=$db[dbname];port=$db[port]charset=$db[charset]",
  $db['username'],$db['password']);
}  catch(PDOException $e){
   echo "伺服器連接錯誤_sort.php";
   exit;
}
$sql = 'UPDATE todos SET `order`=:order WHERE id=:id';
$statment = $pdo->prepare($sql);
foreach ($_POST['orderPair'] as $key => $orderPair) {
	$statment -> bindValue(':order', $orderPair['order'], PDO::PARAM_INT);
	$statment -> bindValue(':id', $orderPair['id'], PDO::PARAM_INT);
	$result = $statment -> execute();
}
     


if(!$result){
   echo "not result 輸出失敗_sort.php ";
 }
?>