<template>
  <v-text-field
    :disabled="disabled"
    :maxlength="maxlength"
    :label="label"
    :rules="rules"
    :prepend-inner-icon="prependInnerIcon"
    :variant="controlStyle.variant"
    :density="controlStyle.density"/>
</template>

<script>
import {mapState} from 'vuex'

export default {
    props: ['value', 'label', 'maxlength', 'prependInnerIcon', 'rules', 'disabled'],
    computed: mapState(['controlStyle']),

    data: ()=>({
    }),

    mounted(){
    },
}
</script>
