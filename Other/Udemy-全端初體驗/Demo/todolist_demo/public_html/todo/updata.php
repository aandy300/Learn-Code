<?php // 解說參照 Create.php
header('Content-Type: application/json; charset=utf8');
include('../../db.php');

try {
$pdo = new PDO("mysql:host=$db[host];dbname=$db[dbname];port=$db[port]charset=$db[charset]",
  $db['username'],$db['password']);
}  catch(PDOException $e){
   echo "伺服器連接錯誤_updata.php";
   exit;
}
     
$sql = 'UPDATE todos SET content=:content WHERE id=:id';
$statment = $pdo->prepare($sql);
$statment -> bindValue(':content', $_POST['content'], PDO::PARAM_STR);
$statment -> bindValue(':id', $_POST['id'], PDO::PARAM_INT);
$result = $statment -> execute();

if(!$result){
   echo "not result 輸出失敗_updata.php ";
 }
?>