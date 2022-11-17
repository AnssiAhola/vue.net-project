<script setup lang="ts">
import Navigation from "./components/Navigation.vue"
</script>

<template>
	<Navigation />
	<div class="container">
		<RouterView />
	</div>
</template>

<style scoped>
.container {
	margin: auto;
	max-width: 1200px;
}
</style>