<template>
  <v-app>
      <component :is="layout"></component>
  </v-app>
</template>

<script>
  import PrincipalLayout from "@/components/Layouts/PrincipalLayout.vue"


  import {mapState} from 'vuex'

  export default {
    components:{PrincipalLayout},
    computed: mapState(['layout']),

    data () {
      return {
        tareas: [],
        dialog: false
      }
    },


    mounted(){
      
    },

    methods: {
      
    }
  }
</script>