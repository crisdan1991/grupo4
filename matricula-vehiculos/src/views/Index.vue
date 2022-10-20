<template>
    <LoginComponent/>
</template>

<script>
    import LoginComponent from '@/components/Matricula/LoginComponent.vue'

    export default {
        components:{
            LoginComponent
        },

        created () {
            //this.$store.commit('SET_LAYOUT', 'principal-layout')
        }
    }
</script>

