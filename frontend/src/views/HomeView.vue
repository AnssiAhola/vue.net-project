<script setup lang="ts">
import Reviews from "@/components/Reviews.vue"
</script>

<template>
  <main class="container">
    <div class="top">
      <div class="title-container">
        <h1 class="title">
          Lorem ipsum dolor sit amet
        </h1>
        <p class="subtitle">
          Ducimus optio sed voluptatibus saepe quaerat sequi, laborum accusantium non aut vero eius.
        </p>
      </div>
      <button @click="$router.push('/arvioi')" class="review-button shadow">
        Arvioi</button>
    </div>
    <div class="bottom">
      <Reviews />
    </div>
  </main>
</template>

<style scoped>
.review-button {
  border: none;
  color: rgb(43, 43, 43);
  font-weight: 600;
  font-size: 70%;
  border-radius: 1rem;
  background-color: var(--color-secondary);
  padding: .5rem 2rem;
  margin: 1rem 0;
  width: 10rem;
}

.top {
  background-image: url("@/assets/sunset.jpg");
  display: flex;
  flex-direction: column;
  gap: 5rem;
  font-size: x-large;
  padding: 4rem 2rem;
  color: #000;
}

.title-container {
  display: flex;
  flex-direction: column;
  gap: 2rem;
}

.title {
  color: rgba(0, 0, 0, 0.674);
  text-shadow: 1px 1px 3px rgb(158, 158, 158);
}

.subtitle {
  color: rgb(245, 245, 245);
  text-shadow: 1px 1px 6px rgb(83, 83, 83);
  max-width: 600px;
}

.bottom {
  width: 100%;
  height: 100%;
  padding: 2rem;
  background-image: linear-gradient(to bottom, rgba(231, 231, 231, 0.779), rgba(255, 255, 255, 0));
}

@media (max-width: 800px) {
  .bottom {
    padding: 0;
  }
}
</style>