<template>
  <div class="card">
    ---
    <div class="card-header">Quote</div>
    <div class="card-body">
      <blockquote class="blockquote mb-0">
        <p>這是 MyCard 測試文字</p>
        <footer class="blockquote-footer">
          Someone famous in <cite title="Source Title">{{ title }}</cite>
        </footer>
      </blockquote>
    </div>
    ---
  </div>
</template>

<script>
export default {
  data() {
    return {
      title: '這是標題'
    }
  },
  mounted() {
    console.log('123')
  }
}
</script>
