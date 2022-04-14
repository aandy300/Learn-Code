<template>
    <div>
      new page!
    </div>
    <!-- b5格線系統 -->
    <div class="row">
        <div class="col-4">
            <!-- b5連結和按鈕 -->
            <div class="list-group">
                <router-link to="/newpage/a" class="list-group-item list-group-item-action">A元件</router-link>
                <router-link to="/newpage/b" class="list-group-item list-group-item-action">B元件</router-link>
                <router-link to="/newpage/nameview" class="list-group-item list-group-item-action">nameview</router-link>
                <router-link to="/newpage/nameview/c2a" class="list-group-item list-group-item-action">nameview-ctoa</router-link>
                <router-link to="/newpage/nameview/b2c" class="list-group-item list-group-item-action">nameview-btoc</router-link>
            </div>
        </div>
        <div class="col-8">
            <router-view></router-view>
        </div>
    </div>
</template>
