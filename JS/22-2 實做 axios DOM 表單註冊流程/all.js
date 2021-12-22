// console.log("123");
// 已被註冊測試用帳號: lovef123@hexschool.com

const account = document.querySelector('.account');
const password = document.querySelector('.password');
const send = document.querySelector('.send');
const accountLogin = document.querySelector('.accountLogin');
const passwordLogin = document.querySelector('.passwordLogin');
const sendLogin = document.querySelector('.sendLogin');


send.addEventListener('click', function(e){
  callSingUp()
})
sendLogin.addEventListener('click', function(e){
  login()
})

// #註冊
function callSingUp(){
  // 防呆 - 輸入欄空值
  if(account.value == "" || password.value == ""){
    alert('請輸入正確資訊!');
    return;
  }

  let obj = {}
  obj.email = account.value;
  obj.password = password.value;  

  axios.post('https://hexschool-tutorial.herokuapp.com/api/signup', obj)
    .then(function (response) {
      // console.log(response);
      // 運用 response.data.message 告知註冊狀態
      if(response.data.message == "帳號註冊成功"){
        alert("帳號註冊成功!");
      }else if(response.data.message == "Email 格式不正確"){ // 防呆 - Email 格式不正確
        alert('Email 格式不正確');        
      }else{ // 防呆 - 已被註冊
        alert("此帳號已被註冊!");
      }
      resetInfo();
    })
    // err偵錯
    .catch(function (error) {
      console.log(error);
    });
}

// #登入
function login(){
  // 防呆 - 輸入欄空值
  if(accountLogin.value == "" || passwordLogin.value == ""){
    alert('請輸入正確資訊!');
    return;
  }

  let obj = {}
  obj.email = accountLogin.value;
  obj.password = passwordLogin.value;  

  axios.post('https://hexschool-tutorial.herokuapp.com/api/signin', obj)
  .then(function (response) {
    console.log(response);
    console.log(response.res);
    if(response.data.message == "登入成功"){
      alert('登入成功!');
    }else if(response.data.message == "此帳號不存在或帳號密碼錯誤"){
      alert('此帳號不存在或帳號密碼錯誤!');
    }else{
      alert('其他錯誤!')
    }
    resetInfo();
  })
  // err偵錯
  .catch(function (error) {
    console.log(error);
  });
}

function resetInfo(){
  account.value = "";
  password.value = "";
  accountLogin.value = "";
  passwordLogin.value = "";
}
