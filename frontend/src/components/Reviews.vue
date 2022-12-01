<script setup lang="ts">

import type { Review } from '@/models/Review';
import { ReviewService } from '@/services/ReviewService';
import { onMounted, ref } from 'vue';
import LoadingSpinner from './LoadingSpinner.vue';
import ReviewCard from './ReviewCard.vue';

let reviewService = new ReviewService

let reviews = ref<Review[]>([])
let loading = ref(false)

function loadMore() {
    if (reviews.value.length == 0) {
        loading.value = true
    }

    reviewService.fetch(9, reviews.value.length)
        .then(_reviews => {
            reviews.value = reviews.value.concat(_reviews)
            loading.value = false
        }).catch(() => loading.value = false)
}

onMounted(() => loadMore())

</script>

<template>
    <div class="container">
        <div class="title">
            <h4>Arviot</h4>
        </div>
        <LoadingSpinner :active="loading" text="Ladataan" />
        <div class="no-reviews" v-if="(reviews.length == 0 && !loading)">Ei arvioita</div>
        <div class="reviews" v-if="reviews">
            <ReviewCard :review="review" v-for="review in reviews" />
        </div>
        <button @click="loadMore" v-if="!loading" class="load-more shadow">
            Lataa lisää
        </button>
    </div>
</template>

<style scoped>
.container {
    display: flex;
    flex-direction: column;
    justify-items: center;
    align-items: center;
}

.title {
    text-align: center;
    line-height: 3rem;
    width: 50%;
    border-bottom: 1px solid rgb(174, 174, 174);
    font-size: x-large;
}

.reviews {
    width: 100%;
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(300px, 1fr));
}

.no-reviews {
    margin: 2rem;
    font-size: larger;
}

.load-more {
    margin: 1rem;
    padding: .5rem 1rem;
    border: none;
    border-radius: 1rem;
    background-color: var(--color-secondary);
    font-weight: bold;
}
</style>