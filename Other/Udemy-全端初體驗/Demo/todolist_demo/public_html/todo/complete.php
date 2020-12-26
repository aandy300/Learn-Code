<?php // 解說參照 Create.php
header('Content-Type: application/json; charset=utf8');
include('../../db.php');

try {
$pdo = new PDO("mysql:host=$db[host];dbname=$db[dbname];port=$db[port]charset=$db[charset]",
  $db['username'],$db['password']);
}  catch(PDOException $e){
   echo "伺服器連接錯誤_complete.php";
   exit;
}
// load todo    
$sql = 'SELECT is_complete FROM todos WHERE id=:id';
$statment = $pdo->prepare($sql);
$statment -> bindValue(':id', $_POST['id'], PDO::PARAM_INT);
$result = $statment -> execute();
$todo = $statment->fetch(PDO::FETCH_ASSOC);

// save
$sql = 'UPDATE todos SET is_complete=:is_complete WHERE id=:id';
$statment = $pdo->prepare($sql);
$statment -> bindValue(':id', $_POST['id'], PDO::PARAM_INT);
$statment -> bindValue(':is_complete', !$todo['is_complete'], PDO::PARAM_INT);
$result = $statment -> execute();

if($result){
    echo json_encode(['id'=>$_POST['id'], 'is_complete'=>!$todo['is_complete']]);
 }else{
 	echo "not result 輸出失敗_complete.php ";
 }
?>