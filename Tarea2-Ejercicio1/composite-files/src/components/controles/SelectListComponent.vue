<template>
  <v-select
    :items="lista"
    item-title="nombre"
    item-value="id"
    return-object
    :label="label"
    required
    :variant="controlStyle.variant"
    :density="controlStyle.density"
    :rules="rules"
    :disabled="disabled"
></v-select>
</template>

<script>
import {mapState} from 'vuex'
import HelperMixin from '../../mixins/mixin'

export default {
    props: ['lista'],

    computed: mapState(['controlStyle', 'rules', 'label', 'disabled']),
}
</script>

<style>

</style>