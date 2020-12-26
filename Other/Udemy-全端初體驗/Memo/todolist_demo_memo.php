Temamplate 製作工具 handlebars

兩個大{{}}裡面的值為可更改的
需要包在特定的語法裡面才能作用
id為自己取的名字
<script id="entry-template" type="text/x-handlebars-template">
  <div class="entry">
    <h1>{{title}}</h1>
    <div class="body">
      {{body}}
    </div>
  </div>
</script>

handlebars 功能
Handlebars.compile = 解析文件內容 解析後可以使用
找到在index.php的Script 找 entry-template 存到 source
var source   = document.getElementById("entry-template").innerHTML;
compile解析後儲存到 templatte
var template = Handlebars.compile(source);


trim(); = 去除空白
-----------------------------------
handlebars 概念
<!-- handlebars script中如果要註解方式如下 {‌{!-- 註解內容 --}} -->
<!-- script不會顯示塞在越後面越好 讓其他語法早點顯示在畫面上 -->
<!-- handlebars的 IF 如果 TURE 印 complete{{#if is_complete}}complete{{/if}} -->
1.做出範本
<script id="todo-list-item-temp" type="text/x-handlebars-template">
   <li class="{{#if is_complete}}complete{{/if}}">
      <div class="checkbox"></div>
	  <div class="content">{{content}}</div>
	  <div class="actions">
	    <div class="delete">X</div>
	  </div>
   </li>
</script>
2.解析範本,儲存範本
<!-- 先在外面準備好 不然再Function裡面每次都會執行一次 -->
    var source = document.getElementById("todo-list-item-temp").innerHTML;
<!-- jquray版本尋找 var source =  $('todo-list-item-temp').html(); -->
    var todotemplate = Handlebars.compile(source);
3.調整與IF 輸出內容
$('li.new').find('.content').blur(function(e){
    // this = 事件發生的對象 = e.currentTarget
  	var todo = $(e.currentTarget).text();
  	// trim(); = 清空 空白
    todo = todo.trim();
    // 複寫上面的 todo  注意是用 : 不是 = !!
    // 如果字串 大於0 執行以下
    // 內容轉化為handlebars辨別的內容回傳
    if(todo.length>0)    {
    	todo = {
    	is_complete : false,
    	content	: todo,
        };
        var li = todotemplate(todo);
  	// 爬樹 擦入這個li列表裡
  	    $(e.currentTarget).closest('li').before(li);
    }
    
  	//清空輸入框
  	$(e.currentTarget).empty();
  	console.log(todo)
  });


-----------------------------------

updata todo list 更改內容


prop() 目標屬性 方法设置或返回被选元素的属性和值
dblclick  雙擊目標
'contenteditable',true 輸入狀態

用 on 在 todolist 上 確認隨時可以觸發以下
//  enter editor mode
$('#todolist')
	.on('dblclick','.content',function(e){
    $(this).prop('contenteditable',true).focus();	
	})
	.on('blur','.content',function(e){
    $(this).prop('contenteditable',false);
	});

-----------------------------------

creat & updata 結合
雙擊時進入編輯模式
離開時 判斷條件 是 .new class 執行 Copy handlebarsf 格式產生表格 並清空元表格
               如果不是 關閉編輯模式
$('#todolist')
	.on('dblclick','.content',function(e){
    $(this).prop('contenteditable',true).focus();	
	})
	.on('blur','.content',function(e){
	var isNew = $(this).closest('li').is('.new')
	if(isNew){
		 var todo = $(e.currentTarget).text();
		 todo = todo.trim();
		      if(todo.length>0)
			  {
			  	todo = {
			  	is_complete : false,
			  	content	: todo,
			  };
		  var li = todotemplate(todo);
		  $(e.currentTarget).closest('li').before(li);
		  }
       	  $(e.currentTarget).empty();
	}
	else{
		  $(this).prop('contenteditable',false);
	}
});	

---------------------------------------------
$(this).closest('li').toggleClass('complete'); 有就刪掉沒有就加上 反轉
---------------------------------------------
移動選單排序
https://jqueryui.com/
jq UI  Stable (Themes) (1.12.1: for jQuery1.7+)

<script src="js/jquery-3.3.1.min.js"></script>  
<script src="js/jquery-ui.min.js"></script>  <<-- 要放在後面 因 基礎為jquery

$('#todolist').find('ul').sortable({ //移動宣單指令叫法 .sortable
  items: 'li:not(.new)',              //目標 li 除了 有.new的class
});


---------------------------------------------
MySQL
     資料庫     資料夾   橫 參數  直 參數  
概念 database > table > row    = column

primary key 獨特的 不重複 不能為空

foreign key 串聯用 連結期他table

relationship 1對1 1對多 多對多 連接

Workbench PK = primary key NN = Not Null AI = 自動增加數值(1>2>3)


date base 主從關係

先選的是多 連結數量不行時時用溝通橋梁 新增一個TABLE分類


--------------------------------------------
MySQL 指令

about `backticks` 反引號
會撞到程式原本的關鍵字時用``包起來

AI自動記數 指定從100開始
ALTER TABLE `users` AUTO_INCREMENT=100;

@ 進入 MySQL 使用 CMD
大小寫沒差 -p按ENTER可以隱藏輸入密碼
C:\MAMP/bin/mysql/bin/mysql -u root -proot;

@ 建立 DATABASE
CREATE DATABASE IF NOT EXISTS `my_blog`
DEFAULT CHARACTER SET utf8
COLLATE utf8_general_ci ;

@ 建立 TABLE
<!-- 在 my_blog 底下 新增 uses 的 table -->
CREATE TABLE IF NOT EXISTS `my_blog`.`uses`( 
  `id` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(255) NOT NULL,
  `password` VARCHAR(255) NOT NULL,
   PRIMARY KEY (`id`))
ENGINE = InnoDB

@ CRUD -------------------

SELECT
* = 全部 選曲全部欄位 WHERE 挑出 taker.wu的
SELECT * FROM `users` WHERE `username`='taker.wu';
只抓 users 裡的 password , created_time
SELECT `password`,`created_time` FROM `users`
WHERE `username`= 'taker.wu';

INSERT 插入
INSERT INTO `users` (`username`,`password`)
VALUES (`taker.wu`,`password_demo`);

UPDATE 更新資料 where限定目標
UPDATE `users`
SET `password`=`newpassword`
WHERE `username`=`  Taker.wu`;

DELETE 刪除
DELETE from `users`
WHERE `username`='taker.wu';

--------------------------------------
@ 其他指令 ----------------
@ JOIN 合併 TABLE 尋找 taker.wu 的文章
SELECT * FROM posts
INNER JOIN users on posts.author_id = users.id
WHERE user.susername='taker.wu';

@WHERE Logic  * = 全部
 AND 兩個條件都要符合
SELECT * FROM `posts`   
WHERE `post_time` > '2017-10-30 16:00:00' AND `category_id`=2;
 OR 一個條件符合就可以
SELECT * FROM `posts`
WHERE category_id`=8 OR `category_id`=2;

@Comparison
等於
SELECT * FROM `users`
WHERE `username`='taker.wu';
不等於
SELECT * FROM `users`
WHERE `username`<>'taker.wu';
不等於
SELECT * FROM `users`
WHERE `username`!='taker.wu';
大於
SELECT * FROM `users`
WHERE `username`>='taker.wu';

@IS NULL
尋找未分類文章 印出 category_id 是 null的
SELECT * FROM `posts`
WHERE `category_id` IS NULL;

@MAX MIN 最大值 最小值
SELECT max(`order`) FROM todos;
SELECT min(`order`) FROM todos;

@Sum & Avg 加總 & 平均值
SELECT sum(price)
FROM `orders`
WHERE order_time > '2017-10-30 16:00:00';

SELECT avg(price)
FROM `orders`
WHERE order_time > '2017-10-30 16:00:00';

@Count 裡有內容的(*) id是2的抓出來
SELECT count(*)
FROM posts
WHERE category_id=2;

@ //其他指令 ----------------
@use 資料庫名稱
@show tables 列出所有桌子
@SHOW DATABASES 列出所有資料庫
@describe 桌子名稱 描述桌子內容
@DROP DATABASE 資料庫名; 刪除資料庫

@ ERROR ----------------
ERROR: Error 1064
MySQL server version for the right syntax to use near 'VISIBLE,
  INDEX `fk_posts_categories1_idx` (`category_id` ASC) VISIBLE

刪掉 VISIBLE

----------------------------------
PHP

@特殊符號
印出符號 "xxxx\"todddd"  加\

@迴圈
印一次1 +1 到10為止
$i = 1;
echo "<select>\n>";
  while($1 <= 10){
  echo"<option>$1</option>\n";
  $i++;
}
echp'</select>';

@ array ----------------------------------

可自訂key 叫 dictionary
KEY 對應 值
key     value
apple   red

一般的 ARRAY 自動排 0 1 2 3 對應值

@範例一 選KEY 印出
$fruits = array('apple' => 'red',
                'lemon' => 'green',
                'pineapple' => 'yellow',);
echo $fruits['apple']; // 印出 red                

@範例二 照順序array為數字 0 1 2
$weathers = array('sunny','cloudy','raining');
echo $weathers[0]; // 印出 sunny


@範例一 新版

$fruits = ['apple' => 'red','lemon' => 'green', 'pineapple' => 'yellow'];
echo $fruist['apple']; // red

@範例二 新版

$weathers = ['sunny','cloudy','raining'];
echo $weathers[0]; // sunny

@foreach 翻出全部ARRAY的內容 在 印出所有
$fruits = ['apple' => 'red','lemon' => 'green', 'pineapple' => 'yellow'];
echo '我最愛吃的水果是:';
echo '<ul>';
foreach($fruits as $自訂名稱1 => $自訂名稱2){
  echo"<li>$fruit</li>";
}
echo'</ul>';

@修改與刪除 ARRAY內容
$fruits = ['apple' => 'red','lemon' => 'green', 'pineapple' => 'yellow'];

修改 更改內容 RED改成GREEN
$fruits['apple'] = 'green';
echo $fruits['apple']; // green

刪除  選定目標 直接刪除值
unset($fruits['lemon']);
var_dump($fruits); //['apple' => 'red', 'pineapple' => 'yellow']

insert 插入array值

指定索引得插入
$fruits = [];
$fruits ['apple'] = 'red';
echo $fruits['apple']; //red

無指定索引將自動編號
$fruits = [];
$fruits [] = 'apple';
$fruits [] = 'orange';
自動照號碼編下去
echo $fruits[0]; //apple

@imlode 將array內容結合成字串
$fruits = ['apple','lemon','pineapple'];
$menu = implode(', ' , $fruits);
echo 'we have'.$menu;
// 印出 we have apple, lemon, pineapple

@explode 炸開目標 重新編排
$transport = ' car, bus, MRT, airplane';
$transport = explode(', ' , $transport);
var_dump($transport);
// ['car', 'bus', 'MRT', 'airplane']

@sort 照英文順序排列 ARRAY 內容
$fruits = ['pineapple','lemon','apple'];
$fruitsColor = [
   'apple' => 'red',
   'lemon' => 'green',
   'pineapple' => 'yellow'
];

sort($fruits);
sort($fruitsColor);

var_dump($fruits);
// ['apple', 'lemon', 'pineapple']
var_dump($fruitsColor); //只看值
// ['green', 'red', 'yellow']

@asort 排序 key也會印出來 順序照值得A~Z
$fruitsColor = [
   'apple' => 'red',
   'lemon' => 'green',
   'pineapple' => 'yellow'
];

asort($fruitsColor);

var_dump($fruitsColor);
// ['lemon'=>'green', 'apple'=>'red', 'pineapple'=>'yellow']

@ksort 排序 key也會印出來 順序照KEY得A~Z
@rsort 排序 key也會印出來 變成Z~A

@PHP function -----------------

isNight(20)  = $time = 20
function isNight($time){
   if($time > 18)
      return true;
   else
      return false;
}

$isNight = isNight(20);
if ($isNight)
    echo 'turn on the light';
else
    echo 'turn off the light';


@PHP OBJECT -------------------

@範例1
class Compter{ //物件裡的東西
  public $cpu;
  public $ram;
  public $hd;
  public $power;

  public function turnOn(){
     $this->power = true;
  }

  public function trunOff(){
     $this->power = false;
  }
}

$mac = new Computer; //這個宣完才是 OBJ

@範例2
class Doggy{
  public $color;

  publci function bark(){
     echo '旺旺!';
}

$charlie = new Doggy;
$charlie ->color = 'yellow'; //指定顏色
$charlie ->bark();  //執行bark()
}

@ __construct 程式function 先準備好 文字需都要對

class Computer{
  public $cpu;
  piblic $ram;
  piblic $hd;
  piblic $power;

  public function __construct($cpu,$ram,$hd){
      $this->cpu = $cpu;
      $this->ram = $ram;
      $this->hd = $hd;

      $this->power= false;

  }

  public function trunOn(){
     $this-> = true;
  }

  public function trunOff(){
     $this-> = false;
  }
}

$mac = new Computer ('1.2GHZ', '2GB','2tb')  //會寫入 public function __construct($cpu,$ram,$hd) 裡面

@ extends 繼承 會繼承puublic的屬性 private和protected

class ATM extends Computer{
    public $monitor;
    publlic $keyboder;
}

$bankAtm = new ATM('1.2ghz','2gb',2tb);


@範例3 先設置好 在直接使用

class Computer {
  private $branding;

  public function setbranding($branding){
     $this->branding = $branding.'MARK';
  }

  public function getbranding(){
     return $this->branding;
  }

  $mac = new Conputer;
  $mac -> setbranding('Apple');
  echo $mac->getBranding(); //'AppleMARK'
 }


@private & protected 

private 不可繼承
protected 可繼承


@namespace   防止名稱重複
 
namespace MING;

class Say{
  public function hi(){
    echo 'hello word';
  }  
}

 在其他script裡
 include'Say.php'; //抓近來
 \MING\Say::hi(); //使用

@namespace + use   防止名稱重複 + 改名 + 簡化

include 'Say.php';
include 'Classroom.php';

use \MING\Say;
use \MING\Classroom\Say as 要改成的名稱;

Say::hi();
要改的名稱::welcom();

@web form 取得 使用者輸入的資料 輸出到後端-----------------------
https://www.w3schools.com/html/html_form_elements.asp  其他form原素指令
表單範例
輸入的資料會傳入 updata-account-info.php 網址裡
<form action="updata-account-info.php" method="post">
後臺得到的資訊是name="email"裡面的值
      Name:<input type="text" name="name"><br>
      Email:<input type="email" name="email"><br>
radio = 選項按鈕
      Gender:<br>
      <input type="radio" name="gender" value="male" checked> Male<br>
      <input type="radio" name="gender" value="Female" checked> Female<br>

      <button>submit</button>>    
</form>>

@POST 後台獲取的資料 存在 $_POST已array呈現

echo $_POST['name'];
echo $_POST['emali'];
echo $_POST['gender'];

@GET 另一種 get 較不安全 會直接顯示輸入的東西在網址上

echo $_GET['name'];

@ REQUEST 不管事get還是post 都可以直接抓

echo $REQUEST['name'];

@validating 確認使用者輸入是否為正確 防被駭
@ filter_var 確認格式 有email....種類型 EX FILTER_VALIDATE_EMAIL
if(filter_var($_POST['email'], FILTER_VAILDATE_EMAIL)){
 echo"Email OK!" ;
}
else{
 echo"Email 錯誤!";   
}

@ $_SERVERP['***'] 伺服器專用變數

echo $_SERVER['QUERY_STRING']; // section=1&course=20   get後面的輸入資料轉化的網址
echo $_SERVER['PATH_INFO'];    // /classroom            網址後面接的東西 EX www.facebook.com/內容  "內容"
echo $_SERVER['SERVER_NAME'];  // www.goole.com         伺服器的名稱
echo $_SERVER['DOCUMENT_ROOT']; /user/local/htdocs      放網頁的根目錄
echo $_SERVER['REMOTE_ADDR'];  //175.38.221.3           IP
echo $_SERVER['HTTP_REFERER']; // http://www.facebook.com  從哪裡連過來的(可以被偽裝)
echo $_SERVER['HTTP_USER_AGENT'];                       連過來的 預覽器版本
//Mozill/5.0(window nt 5.1; rv:12.0) gecko/20100101 firefox/12.0

@ DATABASE 資料庫

@PDO 泛用資料庫連接 防止都要用不同的語法

$user = 'MING';
$pass = 'password'
              連哪一種類的資料庫  資料庫位置 連哪種名稱的資料庫
$pdo = new PDO('mysql:host=localhost;dbname=myblog', $user, $pass);
// $pdo = 直接連到資料庫

@插入資料 @危險版 直接用使用者輸入的資料可能會被輸入其他指令搞資料庫
刪除 寫入 讀取 用 exec
exec = 使用外部指令
$affectedRows = $pdo->exec('
   INSERT INTO posts (author_id, category_id, title, content, post_time)
   VALUES (1, 10 "10 things you should know about MySQL", "...", "2017-10-20 17:00:00")
');

@選取 用 query = 詢問 只會選取不會抓出來 @危險版
fetch() = 抓取出來
$query = $pdo->query('SELECT author_id, title FROM posts');
   // 用while迴圈 選取資料 並印出來 重複到 query抓不到東西便false
   while($row = $query->fetch()){
      echo $row['title'].'<br>';
 }


@比較安全版
// author_id=:author_id'; 先空出位置之後再放入東西
// prepare = 處理 準備好$sql的資料
// bindValue 只要一開始綁定值，那麼不管後面變數裡的值如何變化，都不會改變一開始變數裡的值，就像是把變數變成常數一樣
// execute = 執行?
// htmlentities = 把輸出的字元轉換為HTML的代碼 防被駭
// htmlspecialchars = 中文字元用這個
// fetch 一次抓一筆資料
// fetchAll 一次全部抓出來(吃記憶體)
// PDO::FETCH_ASSOC 傳回下一筆資料的欄位名及值
// xx::zz = 使用xx裡的zzz
$pdo = new PDO('mysql:host=localhost;dbname=my_blog', $user,$pass);
                                            
$sql = 'SELECT * FROM posts WHERE author_id=:author_id';

$statement = $pdo->prepare($sql);
$statement -> bindValue(':author_id', $_POST['author_id']);
$statement -> execute();

while (($result = $statement -> fetch(PDO::FETCH_ASSOC)) !==false){
    echo  $result['title'];
//另一種輸出法 較安全  htmlentities
while (($row = $statement -> fetch(PDO::FETCH_ASSOC)){
    echo htmlentities $result['title'];
}

@ cookies(只能存簡單的字串,網站有30個上限) & sessions(編號)
看宣哪一種 但是都要放在最頂端
stecookie('userid', 'jack', time()+60*60);
session_start();

@ cookies
第一次連接時
宣告userid的變數是jack 後面是COOIKE存活的時間 不設也可以預覽器本身就有設定
stecookie('userid', 'jack', time()+60*60);
第二次連接時
echo $_COOKIE['userid']
@ session
session_start();
確認是否有設定過值 沒有的話設定
if(!isset($_SESSION['user_id']))
$SESSION['user_id'] = 'Jack';

echo 'hello, '.$_SESSION['user_id'];

@ session 限定時間版
//下面這行限制時間
ini_set('session.gc_maxlifetime',3600);
session_start();

if(!isset($_SESSION['user_id']))
  echo 'you are not logged in.';
else
  echo 'hello, '.$SESSION['user_id']  ;

@ cURL 與其他網站溝通 -------------------
//準備參數
$formData = [
   'name'  => 'MING'
   'email' => 'ming@gmail.com',
];
//要連接的網站
$c = curl_init('http://google.com');
curl_setopt($c, CURLOPT_RETURNTRANSFER, true);   //回傳網頁的資料回來
curl_setopt($c, CURLOPT_POST, true);             //設定傳出去的資料為POST
curl_setopt($c, CURLOPT_POSTFIELDS, $formData);  //要傳過去的POST資訊室 剛剛準備的資料

$serverOutput = curl_exec($c); //執行
echo $serverOutput;            //印出

curl_close($c);                //結束

@ composer (package management) = 使用其他人打包好的工具管理系統

官網下載安裝 https://getcomposer.org/doc/00-intro.md#installation-windows
其他外掛 https://packagist.org/


php.exe 路徑: C:\MAMP\bin\php\php7.2.1\php.exe

安裝完後 CMD 輸入 cd:c\mamp\htdocs\composer_test(自己開的資料夾) 更換位置
之後安裝kint外掛 輸入指令 composer require kint-php/kint
composer_test\vendor = 安裝的東西會在這裡面
下面這行會自動叫近來 安裝在 vendor 裡的外掛
<?php
require 'vendor/autoload.php'

$foo = ['123',4654,"debug"];
d($foo); //kint的debug簡寫
?> 

@ create todo list API ----------------------------------

通常POST做GET去讀取

<?php //因為最後是回傳json(最下面那行) 這裡把此檔案宣成json
header('Content-Type: application/json; charset=utf8');
// 試試看連結資料庫
try {
$pdo = new PDO("mysql:host=localhost;dbname=todolist_demo;port=3306;charset=utf8",'ming_demo','A129937916');
}/* 捕獲錯誤 如有存到 PDOException $e裡 並印出 error*/
   catch(PDOException $e){
   echo "error";
   exit();
}
     //在todo table裡 插入欄位   //VALUES欄位的值 因之後要使用prepare和bindValue 所以這邊先空出位置之後填寫 :**** = 空出位置
$sql = 'INSERT INTO todos (content, is_complete, order)
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
  //json_encode = 轉化為 json格式字串  lastInsertID = 取得上一筆新增的序號
  echo json_encode(['id'=> $pdo->lastInsertID()]);
}
?>

@ ajax -----------------------------------------

$.ajax({
    url: '/path/to/file', // API的網址
    type: 'POST',         // 類型 from post
    dataType: 'xml/html/script/json/jsonp', //回傳過來的格式
    data: {paraml: 'value1'},  //要傳的東西   {todo: todo} todo: =  $_POST['todo']  todo = 值
    
    complete: function(xhr, textStatus){
      // 上面的URL 跑完時 觸發這個function
    },
    
    success: function(data, textStatus, xjr){
      // 跑完URL 並且對方回傳"成功" 觸發這個function
    }, 
    
    error: function(xhr, textStatus, errorThrown){
      // 跑完URL 並且對方回傳"錯誤" 觸發這個function 
    },
});  

@ $.ajax $.post 簡約版
        //url           //data              //success
$.post('/path/to/file', {param1: 'value1'}, function(data, textStatus, xjr){
  
});

@ 串接create API 與 前端 ----------------------------------

@ 步驟一 action.js 確認使用者輸入的資料沒有問題後執行以下 if(todo.length>0){...}
@ 步驟二 用以下 ajax ($.post...) 將資料(content: , oder:,)傳到 Create.php 
@ 步驟三 Create.php 跟資料庫連接後 prepare + bindValue資料 插入資料 (action.js $.post使用者輸入的資料)
         插入成功後 以json格式回傳到 action.js
@ 步驟四 action.js 得到資料後 會存在 $.post function(data) 裡 之後更新 todo = { id: data.id...}
@ 步驟五 更新完後 塞入 var li = todotemplate(todo); 插入目標li $(e.currentTarget).closest('li').before(li);

@ action.js

if(todo.length>0)
{       
          var order = $('#todolist').find('li:not(.new)').length +1;
           
          $.post('todo/create.php', { content: todo, order: order }, function(data, textStatus, xjr){
           todo = {
              id: data.id,
              is_complete: false,
              content: todo,
           };
          var li = todotemplate(todo);
            // 爬樹 擦入這個li列表裡
            $(e.currentTarget).closest('li').before(li);
         });
}


@ Create.php

<?php //因為最後是回傳json(最下面那行) 這裡把此檔案宣成json
header('Content-Type: application/json; charset=utf8');
// 試試看連結資料庫
try {
$pdo = new PDO("mysql:host=$db[host];dbname=$db[dbname];port=$db[port]charset=$db[charset]",
  $db['username'],$db['password']);}/* 捕獲錯誤 如有存到 PDOException $e裡 並印出 error*/
   catch(PDOException $e){
   echo "error";
   exit();
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
}
?>    
  
@ todolist READ 網站架構與安全性更新 ----------------------------------
!! 在"..."裡 $db[host] 不用+ '' 會自動判斷裡面的值
@步驟1 將index.php與其他...php移到public_htm資料夾裡 = 使用者只能讀取public_html裡的資料
@步驟2 在public_html裡新增db.php 存取機密資料

@db.php
$db = [
   'host' => 'localhost',
   'port' => 3306,
   'dbname' => 'todolist_demo',
   'username' => '***',
   'password' => 'A*******',
   'charset' => 'utf8',
];

步驟3 更改sql登入資訊(讀取db.php的欄位) 用 include('../db.php'); 載入機密資料
$pdo = new PDO("mysql:host=$db[host];dbname=$db[todolist_demo];port=$do[port]charset=$db[charset]",
  $db['username'],$db['password']);


@ 勞出所有的 SQL todolist資料 用 PHP印出 --------------------------
ASC遞增排序 DSC遞減排序

!!  <?php echo ?> = <?= ?> //簡寫
!! PHP 寫 html : 和 <?php endforeach ?> 取代 {}
<?php foreach ($todos as $key => $todo): ?>
      <li>Html...</li>
<?php endforeach ?>
@ 方法 foreach 一個一個印出來

@ 步驟一 建立 data.php 提取資料庫資料
@ 步驟二 在 index.php  <?php include('data.php') ?> 就會有 data.php 裡的 $todos 可以用
@ 步驟三 在 index.php 裡用 foreach() 印出資料 到沒有資料可印為止

@ data.php --------

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
//ORDER BY=排序 以`oderr`當作排序 ASC = 遞增排序 DESC = 遞減排序
$sql = 'SELECT * FROM todos ORDER BY `order` ASC';
$statement = $pdo ->prepare($sql);
$statement -> execute();
                       //印出所有  PDO::FETCH_ASSOC = 檔案為 ARRAY 樣式 為陣列形
$todos = $statement -> fetchALL(PDO::FETCH_ASSOC); ?>

@ index.php ---------

//整理好的變量目標($todos) as $key(他的索引) => $todo(值) = action.js 裡 if(todo.length>0) 的todo
<?php foreach ($todos as $key => $todo): ?>
      <li data-id="<?= $todo['id'] ?>" class="complete"> 
        <div class="checkbox"></div>
        <div class="content"><?= $todo['content'] ?></div>
        <div class="actions">
          <div class="delete">X</div>
          </div>
      </li>
<?php endforeach ?>


@ 撈出所有的 todo list，用 Handlebars.js 印出 --------------------------

步驟一 data.php 新增 script 輸出成果的 todos
步驟二 原理 新增空的欄位 把輸出的li(裡面+todos的值) 加到空的欄位裡後 輸出 使用each重複擦入li後復寫下一個todos的值在輸出直到沒有值
@ 其他 todotemplate = Handlebars之前做的格式暫存
@ 空欄位  var todoListUI = ''; 塞li複寫用

@ data.php ------

<script>  //以json格式傳回前端 保留數字的格式
  var todos = <?= json_encode($todos, JSON_NUMERIC_CHECK)?>
</script>

@ action.js ------

    //生成資料庫裡的 todos list
    var todoListUI = '';
    $.each(todos, function(index, todo) {
      todoListUI = todoListUI + todotemplate(todo);
    });
    $('#todolist').find('li.new').before(todoListUI);


@ 串聯 update API --------------------------

@ 步驟一 在 action.js if(isNew){}else裡 新增 AJXA Code 當不是 new的CONTENT blur時 使用updata.php更改資料
@ 步驟二 新增 updata.php

@ action.js if(isNew){}else

  var id = $(this).closest('li').data('id');  <!-- id = <li data-id="{{id}}"></li>> 的id  -->
  var content = $(this).text();
  $.post('todo/updata.php', {id: id, content: content});
 
  $(this).prop('contenteditable',false);

@ updata.php 

連接伺服器...

$sql = 'UPDATE todos SET content=:content WHERE id=:id';
$statment = $pdo->prepare($sql);
$statment -> bindValue(':content', $_POST['content'], PDO::PARAM_STR);
$statment -> bindValue(':id', $_POST['id'], PDO::PARAM_INT);
$result = $statment -> execute();

@ 串聯 delete API --------------------------

@ 步驟一 找出 action.js .on('click','.delete',function(e) 新增 AJAX.code 新增ID欄位回傳給後端(參考以下)
@ 步驟二 新增 delete.php 
@ 步驟三 注意 delete.php 沒輸出東西 $.post('todo/delete.php', {id: id}, function(data, textStatus, xhr) 的 data 接不到值
會以為沒有 execute(); 所以最後 if($result) 隨便輸出點東西出去 讓.post data 有值
@ 步驟四 因 $(this).closest('li').remova(); 更改位置後 目標變成 .post data 所以改成
  $(e.currentTarget).closest('li').remove();

@ action.js -----

 .on('click','.delete',function(e){
  var result = confirm('你確定要刪除嗎?');
  if(result)
  {
    var id = $(this).closest('li').data('id');
    $.post('todo/delete.php', {id: id}, function(data, textStatus, xhr) {
    $(e.currentTarget).closest('li').remove();
  });
  }
})

@ delete.php ------

連接伺服器...    
$sql = 'DELETE FROM todos WHERE id=:id ';
$statment = $pdo->prepare($sql);
$statment -> bindValue(':id', $_POST['id'], PDO::PARAM_INT);
$result = $statment -> execute();

if($result){
   echo json_encode(['id' => $_POST['id']]);
 }else{
  echo "not result 輸出失敗_delete.php ";
 }
?>

@ 串聯 Complete API --------------------------

@ 步驟一 在 action.js 新增 AJXA Code 
@ 步驟二 新增一個 Complete.php
@ 步驟三 原理 //load todo -> //toggle complete status -> //save

@ action.js 

.on('click','.checkbox',function(e){
  var id = $(this).closest('li').data('id');
  $.post('todo/complete.php', {id: id}, function(data, textStatus, xhr) {
  $(e.currentTarget).closest('li').toggleClass('complete');
  });

@ compltet.php

連接伺服器...
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

@ 串聯 Order 順序 API --------------------------

@ 步驟一 使用 sortable 裡的 stop: 時 值行程式
@ 步驟二 新增空的 ARRAY 裡面 填入 id 與 li的odrer順序(index) 使用 push(){} 塞進 array裡
@ 步驟三 .post 更改資料庫 odrder 的順序編號 使用 foreach 更新到 array沒東西

@ action.js

$('#todolist').find('ul').sortable({
  items: 'li:not(.new)',
  stop: function(){
    var orderPair = [];
    $('#todolist').find('li:not(.new)').each(function(index, li) {
       orderPair.push({
          id:$(li).data('id') ,
          order: index +1,
       });
     });
    
    $.post('todo/sort.php', {orderPair: orderPair}, function(data, textStatus, xhr) {
      
    });
  },

@ sort.php
// 下兩行只需要執行一次 所以放 foreach 外面
$sql = 'UPDATE todos SET `order`=:order WHERE id=:id';
$statment = $pdo->prepare($sql);

foreach ($_POST['orderPair'] as $key => $orderPair) {
  $statment -> bindValue(':order', $orderPair['order'], PDO::PARAM_INT);
  $statment -> bindValue(':id', $orderPair['id'], PDO::PARAM_INT);
  $result = $statment -> execute();
}