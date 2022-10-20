<template>
  <v-text-field
    :maxlength="maxlength"
    :minlength="minlength"
    :label="label"
    :rules="rules"
    :prepend-inner-icon="prependInnerIcon"
    :variant="controlStyle.variant"
    :density="controlStyle.density"
    :append-icon="passVisible ? 'mdi-eye' : 'mdi-eye-off'"
    @click:append="passVisible = !passVisible"
    :type="passVisible ? 'text' : 'password'"
    />
</template>

<script>
import {mapState} from 'vuex'

export default {
    props: ['value', 'label', 'maxlength', 'minlength', 'prependInnerIcon', 'rules'],
    computed: mapState(['controlStyle']),

    data: ()=>({
        passVisible: false,
    }),

    methods: {
        keypress(e){
            if(e.keyCode === 13){
                this.$emit('keypressEnter')
            }
        }
    }
}
</script>
