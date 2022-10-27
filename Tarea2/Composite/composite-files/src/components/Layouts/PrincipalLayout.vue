<template>
<v-app>
        <v-slide-y-transition mode="out-in">
          <router-view>
          </router-view>
        </v-slide-y-transition>
</v-app>
</template>

<script>

export default {
  data: () => {
    return {
      dark: false
    };
  }
};
</script>