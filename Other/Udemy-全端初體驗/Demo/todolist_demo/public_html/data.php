<?php 
include('../db.php');
try {
$pdo = new PDO("mysql:host=$db[host];dbname=$db[dbname];port=$db[port]charset=$db[charset]",
	$db['username'],$db['password']);}
/* 捕獲錯誤 如有存到 PDOException $e裡 並印出 error*/
   catch(PDOException $e){
   echo "error";
   exit;
}

$sql = 'SELECT * FROM todos ORDER BY `order` ASC';
$statement = $pdo ->prepare($sql);
$statement -> execute();
$todos = $statement -> fetchALL(PDO::FETCH_ASSOC);
?>

<script>  //以json格式傳回前端 保留數字的格式
	var todos = <?= json_encode($todos, JSON_NUMERIC_CHECK)?>
</script>



