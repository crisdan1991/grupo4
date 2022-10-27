<template>
    <LoginComponent/>
</template>

<script>
    import LoginComponent from '@/components/Composite/LoginComponent.vue'

    export default {
        components:{
            LoginComponent
        },

        created () {
            //this.$store.commit('SET_LAYOUT', 'principal-layout')
        }
    }
</script>

