
// Authorization請求方式 GW2是用這個看要怎麼學這個請求方式
// https://www.google.com/search?q=java+request+header+authorization&sxsrf=AOaemvJQlOCbXF-X_KVvmouZ6Pt2qZLJdA%3A1639486485216&ei=FZS4YaPWDIKl2roP6vO08As&oq=Authorization+request+header+JAV&gs_lcp=Cgdnd3Mtd2l6EAMYATIGCAAQBRAeMgYIABAIEB4yBggAEAgQHjIGCAAQCBAeMgYIABAIEB4yBggAEAgQHjIGCAAQCBAeMgYIABAIEB4yBggAEAgQHjIGCAAQCBAeOggIABCABBCwAzoHCAAQsAMQHjoJCAAQsAMQBxAeOgQIABAeOggIABAIEA0QHkoECEEYAUoECEYYAFD-B1ifEmD5QGgBcAB4AIABZogBvwKSAQMzLjGYAQCgAQHIAQrAAQE&sclient=gws-wiz


let ary = [];
// let Authorization: Bearer [api key]
// axios.get('https://hexschool.github.io/js-filter-data/data.json')
// axios.get('https://api.guildwars2.com/v2/account')
axios.get('https://api.guildwars2.com/v2/achievements/daily')
//  https://api.guildwars2.com/v2/achievements?page=12 // GW2 成就id 映射用

.then(function (response) {
    console.log('資料有回傳了')
    ary = response.data;
    renderData();
});

function renderData(){
  console.log(ary);
  console.log(ary.wvw[3]);
  // const title = document.querySelector('.title');
  // title.textContent = ary[0].name;
}
// console.log(ary);