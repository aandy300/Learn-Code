<template>
    <div>
        123
    </div>
</template>

<script>

import axios from 'axios'

export default {
    created() {
        console.log('this.$route', this.$route)
        console.log('this.$route.params.id', this.$route.params.id)
        // 85818d05086e1d4d
        // const seed = this.$route.params.id
        // const seed = '85818d05086e1d4d'
        // axios.get(`http://randomuser.me/api/?seed=${seed}`)
        // eslint-disable-next-line
        axios.get(`http://randomuser.me/api/?seed=${seed}`)        
        .then((res) => {
            console.log(res)
        }).catch((err) => {
          console.log(err)
        })
    }
}
</script>
