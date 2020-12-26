<?php //因為最後是回傳json(最下面那行) 這裡把此檔案宣成json
header('Content-Type: application/json; charset=utf8');
include('../../db.php');
// 試試看連結資料庫
try {
$pdo = new PDO("mysql:host=$db[host];dbname=$db[dbname];port=$db[port]charset=$db[charset]",
  $db['username'],$db['password']);}
/* 捕獲錯誤 如有存到 PDOException $e裡 並印出 error*/
   catch(PDOException $e){
   echo "error";
   exit;
}
     //在todo table裡 插入欄位   //VALUES欄位的值 因之後要使用prepare和bindValue 所以這邊先空出位置之後填寫 :**** = 空出位置
$sql = 'INSERT INTO todos (content, is_complete, `order`)
        VALUES (:content, :is_complete, :order)';
//prepare = 預先準備
$statment = $pdo->prepare($sql);
//把值放入之前流的位置 值從post來 is_complete自己設定就可  PDO::PARAM_*** = 告知參數類型
$statment -> bindValue(':content', $_POST['content'], PDO::PARAM_STR);
$statment -> bindValue(':is_complete', 0, PDO::PARAM_INT);
$statment -> bindValue(':order', $_POST['order'], PDO::PARAM_INT);
                     //execute(); 執行後會回傳是否成功 true or false
$result = $statment -> execute();
  // 如果 execute 成功的話會(回傳ture)執行以下
if($result){
  //json_encode = 轉化為 json格式字串  lastInsertID = 取得上一筆新增的序號 印出 ID
  echo json_encode(['id'=> $pdo->lastInsertID()]);
  echo $pdo->lastInsertID;
  
}else{
  var_dump($pdo->errorInfo());
}
?>