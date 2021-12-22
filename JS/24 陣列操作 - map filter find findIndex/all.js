// #map --------------------------------
// #自己*自己
let arr = [0, 1, 2, 3, 4, 10]
const newArr = arr.map(function(item){
  return item*item
})
console.log('自己*自己: ' + newArr);
// // 自己*自己: 0,1,4,9,16,100
console.log(newArr);
// (6) [0, 1, 4, 9, 16, 100]

// #挑>3的
const newArr2 = arr.map(function(item){
  return item>3
})
console.log('>3: ' + newArr2);
// >3: false,false,false,false,true,true

// #處理後傳自製的obj
const newData = arr.map(function(item){
  let obj = {};
  obj.checkNum = item >= 3;  
  return obj
})
console.log('obj >3: ' + newData); // 這樣印會變印出文字而已 要下面才會是obj格式
// obj >3: [object Object],[object Object],[object Object],[object Object],[object Object],[object Object]

console.log(newData);
// (6) [{…}, {…}, {…}, {…}, {…}, {…}]
// 0: {checkNum: false}
// 1: {checkNum: false}
// 2: {checkNum: false}
// 3: {checkNum: true}
// 4: {checkNum: true}
// 5: {checkNum: true}
// length: 6
// [[Prototype]]: Array(0)

console.log('filter--------------------------------')

// #filter 資料篩選 --------------------------------

// #挑出符合條件的
const newArr3 = arr.filter(function(item){
  return item >= 3;
})
console.log(newArr3);
// (3) [3, 4, 10]

// #挑出合格分數的
let studentData = [
  {
    name: "a",
    score: 21
  },
  {
    name: "a",
    score: 85
  },
  {
    name: "b",
    score: 51
  }
]
const filterScore = studentData.filter(function(item){
  return item.score >= 60;
});
console.log(filterScore);
// [{…}] 0: {name: 'a', score: 85}length: 1[[Prototype]]: Array(0)

// #find 資料篩選 --------------------------------
// #尋找頭一筆符合的資料
newArr4 = arr.find(function(item){
  return item >=3;
})
console.log(newArr4);
// 3

// #findindex 尋找資料索引 --------------------------------

// 要出目標所在的index 值
const colors = ['red', 'black', 'blue'];
const blueIndex = colors.findIndex(function(item){
  return item == "blue";
})
console.log(blueIndex);

// 運用客人給單號時抓資訊
orderData = [
  {
    name: 'ming',
    orderId: '123456',
    staus: '運送中'
  },
  {
    name: 'adny',
    orderId: '125686',
    staus: '已送達'
  },
  {
    name: 'alex',
    orderId: '128956',
    staus: '集貨中'
  },
]

let personId = '128956'
function getInfo(id){
const resultId = orderData.findIndex(function(item){
  return item.orderId == id;
})
console.log(`該單號: ${personId} 在data中的index為: ${resultId}`);
// 該單號: 128956 在data中的index為: 2
console.log(`這個訂單編號 收貨人為: ${orderData[resultId].name} 運送狀態為: ${orderData[resultId].staus}`);
// 這個訂單編號 收貨人為: alex 運送狀態為: 集貨中
}

getInfo(personId);

