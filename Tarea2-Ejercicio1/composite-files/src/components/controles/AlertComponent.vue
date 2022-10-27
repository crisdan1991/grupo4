<template>
  <v-alert v-model="showAlert"
      border="start"
      variant="tonal"
      closable
      close-label="Close Alert"
      :color="color"
      :title="title"
    >
      {{description}}
    </v-alert>
</template>

<script>
export default {
    props: ['showAlert', 'title', 'color', 'description'],
}
</script>

<style>

</style>