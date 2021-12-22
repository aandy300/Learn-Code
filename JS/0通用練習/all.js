// JSON格式
// -------------------------------------
// let tomStatus = {
// 	name: "tom",
// 	age: 26,
// 	status: ""
// }

// // 追加屬性 溫度
// -------------------------------------
// tomStatus.degree = 36.5;

// if (tomStatus.degree >= 37){
// 	//console.log("體溫過高")
// 	tomStatus.status = "體溫過高不能進入";
// }else{
// 	//console.log("體溫正常")
// 	tomStatus.status = "體溫正常可以進入";
// }
// console.log(tomStatus.status)
// console.log("23")



// function測試
// -------------------------------------

// // 丟入兩個分數 > 
// // > 1.算出平均
// // > 2.看平均是否60以上 
// // > 3.回傳 分數1, 分數2, 平均分數, 是否平均以上 (分array版本和直接印出版本)
// function checkScore(score){
// 	if(score >= 60){
// 		return '兩科平均60以上';
// 	}else{
// 		return '兩顆平均以下';
// 	}
// }

// function add(scoreNum, scoreNum2){
// 	let score = (scoreNum + scoreNum2) / 2;
// 	let check =	checkScore(score);
// 	// 下面 array儲存
// 	// return ['分數1:' + scoreNum, '分數2:' + scoreNum2, '平均分數:' + score, check]
// 	// 下面 直接印出
// 	return `分數1: ${scoreNum} 分數2: ${scoreNum2} 平均分數: ${score} $check`	
// }

// let tomScore = add(60, 100)
// console.log(tomScore)

// // output:
// // array儲存
// 	// (4) ['分數1:60', '分數2:100', '平均分數:80', '兩科平均60以上']
// // 直接印出
// 	// 分數1: 60 分數2: 100 平均分數: 80 兩科平均60以上


// 1 是 true 0 是 false
// -------------------------------------
// 1 是 true 0 是 false
// function checkNum2(number2){
// 	if(number2%2){ //若為 true，表示取出餘數 1(truthy)	
// 	console.log(`不是偶數`); //印出不是偶數
// 	}else{ //否則就是 false，也就是取出 0 (falsy)	
// 	console.log(`是偶數`); //印出是偶數
// 	}	
// 	}
// let o = checkNum2(5)

	

// document.querySelector & document.querySelectorAll 陣列儲存可以直接叫
// -------------------------------------
// const el = document.querySelector("h1");
// el.textContent=("456");
// console.log(el.textContent);

// const list = document.querySelector(".list")
// let newLink = "http://google.com";
// let linkName = "googlelink";
// let content =  `<a href="${newLink}">${linkName}更改後</a>`
// list.innerHTML = content;

// const allh1 = document.querySelectorAll("h1");
// console.log(allh1[1].textContent)



// addeventListener 練習
// -------------------------------------
// const btn = document.querySelector(".btn");
// const title = document.querySelector("h1");

// btn.addEventListener("click", function(e){
//     title.textContent = "被點擊過了";
//     console.log("被點擊了");
// })


// 加法練習 點按鈕加數字
// -------------------------------------
// const btn = document.querySelector(".btn");
// const title = document.querySelector("h1");
// let conunt = 0;

// btn.addEventListener("click", function(e){
//     console.log("被點擊了");
//     conunt+= 1;    
//     title.textContent = conunt;
//     console.log(e.target);
// })

// forEach()
// -------------------------------------
// let data = [
// 	{
// 		name: "tom",
// 		sex: "male"
// 	},
// 	{
// 		name: "mary",
// 		sex: "woman"
// 	},
//     {
// 		name: "andy",
// 		sex: "male"
// 	},
// ];
// let total = 0;
// let names = [];
// data.forEach(function(item, index){	
// 	//將物件寫入其他陣列
//     names.push(item.name);
//     //讀取 抓取物件屬性
//     console.log(`現在的名字是: ${item.name}`)
//     //if
//     if (item.sex === "male"){
//         //加法
// 		total+=1;
// 	}
// })
// console.log(total);
// console.log(names);




// const obj = {
//     a:1
// }
// const num = 3
// obj.b =3
// obj.a =2;
// console.log(obj.a, obj.b);


// var num = '123' == 123;
// console.log(num)

// let date = new Date().getTime()
// console.log(`date`, date)

// function Car(make, model, year) {
//     this.make = make;
//     this.model = model;
//     this.year = year;
// }
// let car = new Car("Nissan", "300ZX", 1992)
// console.log(`car`, car)
// console.log(`object`, typeof (car)) 



// 按值對對象屬性進行排序
// https://stackoverflow.com/questions/1069666/sorting-object-property-by-values?page=1&tab=votes#tab-top
// let arrayOfObjects = [   
//     {
//         name: 'Diana',
//         born: 13, // Mon, Jul 15 2013
//         num: 4,
//         sex: 'female'
//     },
//     {

//         name: 'Beyonce',
//         born: 136, // Wed, Apr 24 2013
//         num: 2,
//         sex: 'female'
//     },
//     {            
//         name: 'Albert',
//         born: 137, // Mon, Jun 3 2013
//         num: 3,
//         sex: 'male'
//     },    
//     {
//         name: 'Doris',
//         born: 135, // Sat, Dec 1 2012
//         num: 1,
//         sex: 'female'
//     }
// ];

// // use slice() to copy the array and not just make a reference
// var byDate = arrayOfObjects.slice(0);
// byDate.sort(function(a,b) {
//     console.log('123',a[sex],b[1]);
//     return a.born - b.born;
//     // return b.born - a.born;
// });
// // console.log('by date:');
// console.log(byDate);
// byDate.forEach(item => console.log(item))


// // switch & case
// function sw(state){
//     let expr = state;
//     switch (expr) {
//       case 'Oranges':
//         console.log('Oranges are $0.59 a pound.');
//         break;
//       case 'Mangoes':
//       case 'Papayas':
//         console.log('Mangoes and papayas are $2.79 a pound.');
//         // expected output: "Mangoes and papayas are $2.79 a pound."
//         break;
//       default:
//         console.log(`Sorry, we are out of ${expr}.`);
//     }
// }

// sw('Oranges') // Oranges are $0.59 a pound.
// sw('Papayas') // Mangoes and papayas are $2.79 a pound.


// let expr = 'Papayas';
// switch (expr) {
//   case 'Oranges':
//     console.log('Oranges are $0.59 a pound.');
//     break;
//   case 'Mangoes':
//   case 'Papayas':
//     console.log('Mangoes and papayas are $2.79 a pound.');
//     // expected output: "Mangoes and papayas are $2.79 a pound."
//     break;
//   default:
//     console.log(`Sorry, we are out of ${expr}.`);
// }
// expr = 'Oranges';
// expr = 'Papayas';


// var str = 'For more information, see Chapter 3.4.5.1';
// var re = /see (chapter \d+(\.\d)*)/i;
// var found = str.match(re);

// // 輸出 ["see Chapter 3.4.5.1", "Chapter 3.4.5.1", ".1"]
// console.log(found);

// const list = [
//   ['小明', '小小明', '小明明'],
//   ['小華', '小小華', '小華華'],
//   ['小美', '小小美', '小美美'],
// ]

// let newlist = [].concat(...list) // concat = 合併多個陣列 // array1.concat(array2, array3, ..., arrayX) 	必需。要连接的数组。
// let result = newlist.filter((item) => String(item).match(/^小小/g))
// console.log(newlist) // (9) ['小明', '小小明', '小明明', '小華', '小小華', '小華華', '小美', '小小美', '小美美']
// console.log(result) // (3) ['小小明', '小小華', '小小美']



// #sort 物件為什麼可以用 [] 叫屬性 疑問
// datas = [
//     {
//     作物名稱: "椰子",    
//     上價: 543.1,    
//     },
//     {
//     作物名稱: "釋迦",
//     上價: 12.6,
//     },
//     {
//     作物名稱: "草莓-進口",
//     上價: 122.2,
//     },
//     {
//     作物名稱: "藍莓-進口",
//     上價: 266.7,
//     }
// ]

// datas.forEach(item => console.log(item) );

// datas.sort(function(a,b) {
//     let va = '上價'
//     console.log(typeof(a), typeof(a.上價), typeof(a[va]), typeof(a[0]), typeof(a[datas.上價]) );
//     // object number undefined undefined undefined

//     // return a.上價 - b.上價; // 是物件 呼叫物件的屬性 還理解的了
//     // return a[datas.上價] - b[datas.上價]; // 錯誤沒作用?
//     return a[va] - b[va]; // 不懂這邊為什麼變成陣列了，而且是帶入 string 的 '上價'
    
// });
// console.log('--------')
// datas.forEach(item => console.log(item))



// datas = [
//   {
//   作物名稱: "椰子",    
//   上價: 543.1,    
//   },
//   {
//   作物名稱: "釋迦",
//   上價: 12.6,
//   },
//   {
//   作物名稱: "草莓-進口",
//   上價: 122.2,
//   },
//   {
//   作物名稱: "藍莓-進口",
//   上價: 266.7,
//   }
// ]

// datas.forEach(item => console.log(item) );

// let newDatas = datas.sort(function(a,b) {
//   let price = '上價'  
//   return a[price] - b[price]; // 少的先
//   // return b[price] - a[price]; // 多的先
// });
// console.log('--------')
// newDatas.forEach(item => console.log(item)) 
// // {作物名稱: '釋迦', 上價: 12.6}
// // {作物名稱: '草莓-進口', 上價: 122.2}
// // {作物名稱: '藍莓-進口', 上價: 266.7}
// // {作物名稱: '椰子', 上價: 543.1}

const obj = {
  a:1
};

obj.b = 'x';
console.log(obj.b)