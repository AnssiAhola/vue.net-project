<script setup lang="ts">
import { ReviewService } from '@/services/ReviewService';
import type { Review } from "@/models/Review";
import { onMounted, ref } from 'vue';

let reviewService = new ReviewService()

let name = ref("")
let email = ref("")
let content = ref("")

let submit = (e: Event) => {
    let _content = content.value.trim()
    let _name = name.value.trim()
    if (_name.length == 0 || _content.length == 0) {
        return
    }
    let review:Review = {
        name: _name,
        email: email.value.trim(),
        content: _content,
        timestamp: new Date()
    }
    reviewService.submit(review)
    reset()
    e.preventDefault()
}

let reset = () => {
    name.value = ""
    email.value = ""
    content.value = ""
}
</script>

<template>
    <form @submit="submit" class="my-form">
        <div class="input-container">
            <label for="name">Nimi</label>
            <input v-model="name" class="shadow" type="text" name="name" id="">
        </div>
        <div class="input-container">
            <label for="email">Sähköpostiosoite</label>
            <input v-model="email" class="shadow" type="email" name="email" id="">
        </div>
        <div class="input-container">
            <label for="content">Vapaa kenttä</label>
            <textarea v-model="content" class="shadow" type="textarea" name="review_content" id=""></textarea>
        </div>
        <button type="submit" class="submit-btn shadow">
            Lähetä
        </button>
    </form>
</template>

<style scoped>
.my-form {
    display: flex;
    flex-direction: column;
    justify-items: center;
}

.input-container {
    padding: .5rem 1rem;
    margin: 0 1rem;
}

.input-container label {
    font-size: large;
    font-weight: bold;
    display: block;
    margin-bottom: .5rem;
}

input,
textarea {
    width: 100%;
    width: -webkit-fill-available;
    background-color: rgb(247, 247, 247);
    border-radius: .3rem;
    border: none;
    height: 2rem;
    display: block;
    padding: 1rem;
}

textarea {
    min-height: 10rem;
    resize: none;
}

.submit-btn {
    color: white;
    background-color: rgb(67, 131, 192);
    height: 2rem;
    border: none;
    border-radius: .5rem;
    margin: 1rem 2rem;
}
</style>