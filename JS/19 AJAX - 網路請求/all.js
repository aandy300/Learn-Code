// hex origin
// const http = require("http");
// http.createServer(function(req, resp){
//     // console.log(req);
//     console.log(req.url);
//     if(req.url == '/'){
//         console.log('接收到網頁請求');
//         resp.writeHead(200, {"Content-Type": "text/HTML"});
//         resp.write("<h1>index</h1>");
//         resp.end();
//     }
// }).listen(process.env.PORT || 3000);
// console.log("SV已開啟port: 3000");


// 解說ver https://ithelp.ithome.com.tw/articles/10185302
// m 連線位置 127.0.0.1:3000
const http = require('http'); // 1 - 載入 Node.js 原生模組 http
 
const server = http.createServer(function (req, resp) {   // 2 - 建立server  // m- req = 訪問者發出請求時，接收到的訪問者的資訊，發出網路請求的時候才會執行
    // 在此處理 客戶端向 http server 發送過來的 req。

    // console.log(req);
    console.log(req.url);
    if(req.url == '/'){ // m / = 首頁的方式造訪
        console.log('接收到網頁請求');
        resp.writeHead(200, {"Content-Type": "text/HTML"}); // m 寫入resp的head 回傳 200, 告知格式 "Content-Type": "text/HTML"
        resp.write("<h1>index</h1>"); // m 回傳 寫入respone的內容
        resp.end();
    }
});
server.listen(process.env.PORT || 3000); //3 - 進入此網站的監聽 port, 就是 localhost:xxxx 的 xxxx
 
// server.listen(5000); //3 - 進入此網站的監聽 port, 就是 localhost:xxxx 的 xxxx
console.log('Node.js web server at port 5000 is running..')