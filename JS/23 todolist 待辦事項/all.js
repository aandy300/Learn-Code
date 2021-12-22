// 資料格式
data = [
  {
    "content": "待辦事項一"
  },
  {
    "content": "ABCDE"
  }
]

const addTxt = document.querySelector('.txt');
const save = document.querySelector('.save');
const list = document.querySelector('.list');

// #追加功能
save.addEventListener('click', function(e){  
  if(addTxt.value == ""){
    alert('不可為空');
    return;
  }
  
  let obj = {}
  obj.content = addTxt.value;
  data.push(obj);
  renderDate();
  resetInfo();
})

// #刪除功能
list.addEventListener('click', function(e){
  if(e.target.getAttribute('class') == "delete"){
    let num = e.target.getAttribute("data-num");
    console.log(num);
    data.splice(num, 1);
    renderDate();
  }else{
    return;
  }  
})

// 資料刷新
function renderDate(){
  let str = "";
  data.forEach(function(item, index){
    str+= `<li>${item.content} <input class="delete" type="button" data-num="${index}" value="刪除待辦"></li>`
  })  
  const list = document.querySelector('.list');
  list.innerHTML = str;  
}
// 重置輸入框
function resetInfo(){
  addTxt.value =""
}

renderDate();
