<script setup lang="ts">
import ReviewForm from '@/components/ReviewForm.vue';

</script>

<template>
  <main>
    <h2 class="title">Jätä arviosi!</h2>
    <ReviewForm class="my-form" />
  </main>
</template>

<style scoped>
main {
  margin: auto;
  max-width: 500px;
}

.title {
  text-align: center;
  margin: auto;
  margin-top: 2rem;
}

.my-form {
  margin: auto;
  margin-top: 3rem;
}
</style>