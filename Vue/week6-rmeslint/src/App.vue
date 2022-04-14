// 這個是首頁?
<template>
  <nav class="navbar navbar-expand-lg navbar-light bg-light">
    <div class="container-fluid">
      <a class="navbar-brand" href="#">Navbar</a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
        <div class="navbar-nav">
            <router-link class="nav-link active" aria-current="page" href="#" to="/">Home</router-link>
            <router-link class="nav-link" to="/about">About</router-link>
            <router-link class="nav-link" :to="{ name: '新增頁面' }">新增頁面</router-link>
        </div>
      </div>
    </div>
  </nav>

  <div class="container">
    <router-view/>
  </div>
  <!-- {{ name }} -->
  <!-- <button type="button" class="btn btn-primary">Primary</button> -->
</template>

<style lang="scss">
// @import "bootstrap";
</style>

<script>
export default {
  data() {
    return {
      name: process.env.VUE_APP_NAME
    }
  }
}
</script>
