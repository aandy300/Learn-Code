data = [] // 儲存用
// let obj = {
  // id: new Date().getTime(), // 運用時間 弄出特別id
  // isChecked: "", // CheckBox是否勾選用
  // content: addTxt.value
// }    
const list = document.querySelector('.list'); // list
const save = document.querySelector('.btn_add'); // +按鍵
const addTxt = document.querySelector('.txt'); // 待辦輸入框
const tab = document.querySelector('.tab'); // tab標籤
const list_footer = document.querySelector('.list_footer') // 底層標籤div容器
let activeTagName = "全部" // 確認現在在哪個tab 預設 全部

// # 監聽類..
// 監聽 - +按鍵點擊時 > 增加功能
save.addEventListener('click', function(e){      
  addTodo();
})
// 監聽 - Enter時 > 增加功能
addTxt.addEventListener('keypress', function (e) {
  if(e.key === 'Enter'){
      addTodo();
  }
})
// 監聽 - X按鈕 > 刪除待辦事項
list.addEventListener('click', function(e){
  delTodo(e);
})
// 監聽 - 點擊待辦事項更新資訊 > input(確認事項時)檢測 tab狀態 照tab狀態 選擇 更新資訊func
list.addEventListener('click', function(e){
  if(e.target.nodeName == "INPUT"){
    renderTabStatusCheck();
  }
  // console.log(e.target.nodeName);
})
// 監聽 - 清除已完成項目
list_footer.addEventListener('click', function(e){
  console.log(e.target.nodeName);
  if(e.target.nodeName == "A"){
    del_Checktodo();
  }
})
// 監聽 - tab點擊更換狀態 切換狀態 全部 待完成 完成
// = 先移除舊的active > 點到的追加active > 判斷點到的目標文字內容更新 activeTagName
// https://stackoverflow.com/questions/49423973/how-to-remove-the-active-class-from-all-children-in-a-parent-using-javascript
tab.addEventListener('click', function(e){  
  let oldActive = document.querySelector('.active');  
  oldActive.classList.remove('active')    
  e.target.setAttribute("class", 'active');  
  activeTagName = e.target.textContent;
  // console.log(activeTagName);
  renderTabStatusCheck();
})

// # 功能類...
// 增加功能
function addTodo(){
    if(addTxt.value == ""){
        alert('不可為空');
        return;
      }    
      let obj = {
        id: new Date().getTime(), // 運用時間 弄出特別id
        isChecked: "", // CheckBox是否勾選用
        content: addTxt.value
      }      
      data.unshift(obj);
      renderTabStatusCheck()
      resetInfo();
}

// 刪除功能 - 原本用陣列順序刪除會因遞補出問題 改用id各自obj識別
function delTodo(e){
  const id = e.target.closest("li").getAttribute("data-id"); // 抓ID
  const index = data.findIndex(function(item){ // 取得index 找出是在陣列中的第幾筆
    console.log(item.id, id )
   return item.id == id;
  });
  console.log(index)
  if(e.target.getAttribute('class') == "delete"){      // 如果點到delete 照抓的index 刪除
      data.splice(index, 1);                          // 他是直接把資料裡的那筆刪除掉了 不是調整狀態 調整狀態是下面的check
    }else if(data[index].isChecked == ""){
      data[index].isChecked = "checked";      // 因為是寫入到data裡面所以 render重新印出的時候也會更新 本身未done > 點了 = done
    }else{
      data[index].isChecked = "";      // 反向 本身done 點了 = 沒done
    }
    renderTabStatusCheck()
}

// 刪除全部完成的待辦事項 = 回傳篩選出未完成的，完成的略過(反向操作)
function del_Checktodo(){
  data = data.filter(function(item){    
    return item.isChecked == ""
  })
  renderTabStatusCheck();
}

// render 篩選器 可以改用case?
function renderTabStatusCheck(){
  if(activeTagName == "全部"){
    renderDate();
  }else if(activeTagName == "待完成"){
    renderChecked();
  }else if(activeTagName == "已完成"){
    renderDoneList();
    // console.log('已完成...render 篩選器')
  }
}

// 寫入用的html格式 str樣板 +=用
function strTemplate(item){
  let style = `
  <li data-id="${item.id}">
    <label class="checkbox" for="">
      <input type="checkbox" ${item.isChecked}/>
      <span>${item.content}</span>
    </label>
    <a href="#" class="delete"></a>
  </li>
  `  
  return style
}

// render 全部
function renderDate(){
  let str = "";
  data.forEach(function(item, index){
    str+= strTemplate(item);
  })  
  list.innerHTML = str;  
  
  //篩選出 待完成項目 待完成項目總數用
  waitTolist = data.filter(function(item){
    console.log(item)
    return item.isChecked == ""
  })  
  addDoneTotal(waitTolist);
}

// render 未完成的
function renderChecked(){
  let str = "";
  // 從data挑出未完成的 存入waitTolist
  waitTolist = data.filter(function(item){    
    return item.isChecked == ""
  })
  // 一筆一筆印出跟普通版一樣
  waitTolist.forEach(function(item, index){     
    str+= strTemplate(item);
  })
  list.innerHTML = str;   
  addDoneTotal(waitTolist);
}

// render 完成的
function renderDoneList(){  
  let str = "";
  // 從data挑出完成的 存入doneList
  doneList = data.filter(function(item){    
    return item.isChecked == "checked"
  })  
  doneList.forEach(function(item, index){
    str+= strTemplate(item);
  })
  list.innerHTML = str; 
  let arrLength = doneList.length;
  list_footer.innerHTML = `<p>${arrLength} 個已完成項目</p> <a href="#">清除已完成項目</a>`
}

// 寫入底部待完成數量 - 只有待完成 (完成只有一次所以沒做)
function addDoneTotal(waitTolist){
  let arrLength = waitTolist.length;
  list_footer.innerHTML = `<p>${arrLength} 個待完成項目</p> <a href="#">清除已完成項目</a>`
}

// 重置輸入框
function resetInfo(){
    addTxt.value =""
}

renderDate()



