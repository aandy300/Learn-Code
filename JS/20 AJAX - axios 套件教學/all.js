// console.log(axios);

// 接檔案練習
// axios.get('https://hexschool.github.io/ajaxHomework/data.json')
// .then(function (response) {
//     let ary =response.data;
//     const title = document.querySelector(".title");
//     // <span> innerHTML比較合適
//     // 純文本  textContent 比較合適
//     title.textContent = ary[0].name;


//     console.log(response);
//     console.log(response.data);
//     console.log(response.status);
//     console.log(response.statusText);
//     console.log(response.headers);
//     console.log(response.config);
// });


// 透過函式設計處理非同步 確保非同步資料
// JS 是單執行緒的語言，因此一次只會進行一件事情，伺服器資料還沒回傳會先繼續跑下面，之後等待處理的任務(等伺服器回傳的資料)處完後才會結束程式
// 確認已經讀到資料 再跑function renderData()
// 因為有待處理所以不會結束
let ary = [];
axios.get('https://hexschool.github.io/js-filter-data/data.json')
.then(function (response) {
    console.log('資料有回傳了')
    ary = response.data;
    renderData();
});

function renderData(){
    console.log(ary);
    const title = document.querySelector('.title');
    title.textContent = ary[0].name;
}
console.log(ary);
