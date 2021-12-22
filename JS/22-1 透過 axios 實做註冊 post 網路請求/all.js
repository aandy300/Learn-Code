console.log("123");

// function化
function callSingUp(){
  obj = {
    email: 'lovef123@hexschool.com',
    password: '12345678000'
  }
  
  axios.post('https://hexschool-tutorial.herokuapp.com/api/signup', obj)
    .then(function (response) {
      console.log(response);
    })
    .catch(function (error) {
      console.log(error);
    });
}

callSingUp()