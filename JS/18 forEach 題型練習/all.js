let data = [
    {
        Charge:"免費",
        name:"小名充電站"
    },{
        Charge:"免費",
        name:"曉華充電站"
    },{
        Charge:"投幣",
        name:"阿瓜充電站"
    },{
        Charge:"投幣",
        name:"阿偉充電站"
    }
];
const list = document.querySelector(".list");    

// #預設載入函式 初始化
function init(){    
    let str = "";
    
    data.forEach(function(item, index){
        // console.log(item.name);
        str+= `<li>${item.name}，${item.Charge}</li>`
    });
    list.innerHTML = str;
}

init();

// 主要利用物件直接對比 e.target.value == data[*]item.Charge
// 利用Else其他的完成全部
// #按鈕篩選器選擇
const stationFilter = document.querySelector(".filter");
stationFilter.addEventListener("click", function(e){
    // console.log(e.target.value);
    if(e.target.value == undefined){
        console.log('123')
        return; // 直接中斷，且不帶值
    }
    let str = ""
    data.forEach(function(item, index){
        // 點到的目標的value = 這輪輪到的item的value
        if(e.target.value == item.Charge){
            str+=`<li>${item.name}，${item.Charge}</li>`
        }else if(e.target.value == "全部"){
            str+= `<li>${item.name}，${item.Charge}</li>`
        }
    });
    list.innerHTML = str;
});

// #新增資料邏輯
const stationName = document.querySelector(".stationName");
const stationCharge = document.querySelector(".stationCharge");
const btn = document.querySelector(".btn");
// console.log(stationName,stationCharge,btn)
// 直接 = 就好，+=反而錯誤因為一開始沒東西
btn.addEventListener("click", function(e){
    let objTemp = {}
    objTemp.name = stationName.value;    
    objTemp.Charge = stationCharge.value;        
    data.push(objTemp);
    // #重製選項
    stationName.value = "";
    stationCharge.value = "";
    // #初始化刷新資料
    init();
})

// 做錯的
// Uncaught SyntaxError: Identifier 'data' has already been declared
// 因為js載入兩次

// Uncaught TypeError: list.innerHTML is not a function
// 錯誤的用法 list.innerHTML(str);
// 正確的用法 list.innerHTML = str;
