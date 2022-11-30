<script setup lang="ts">

import type { Review } from '@/models/Review';
import { ReviewService } from '@/services/ReviewService';
import { onMounted, ref } from 'vue';

let reviewService = new ReviewService

let reviews = ref<Review[]>([])

function formatDate(date: Date | string) {
    if (typeof date == "string") {
        date = new Date(date)
    }
    return date.toLocaleDateString()
}

function loadMore() {
    reviewService.fetch(9, reviews.value.length)
        .then(_reviews => reviews.value = reviews.value.concat(_reviews))
}

onMounted(() => loadMore())

</script>

<template>
    <div class="container">
        <div class="title">
            <h4>Arviot</h4>
        </div>
        <div class="no-reviews" v-if="reviews.length == 0">Ei arvioita</div>
        <div class="reviews" v-if="reviews">
            <div class="card shadow" v-for="review in reviews">
                <div class="header">
                    <span class="reviewer">{{ review.reviewerName }}</span>
                    <span class="timestamp">{{ formatDate(review.createdAt) }}</span>
                </div>
                <div class="content">
                    <i>
                        "{{ review.content }}"
                    </i>
                </div>
            </div>
        </div>
        <button @click="loadMore" class="load-more shadow">
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

.card {
    overflow: hidden;
    border-radius: .5rem;
    background-color: rgba(203, 203, 219, 0.434);
    margin: 1rem;
}

.card .header {
    display: flex;
    align-items: center;
    justify-content: space-between;
    font-weight: bold;
    color: rgb(43, 43, 43);
    padding: 1rem;
    background-color: rgba(245, 245, 245, 0.514);
}

.card .content {
    overflow-y: auto;
    max-height: 300px;
    padding: 1.5rem;
    color: rgb(82, 82, 82);
    font-size: .9rem;
}

.reviewer {
    overflow: hidden;
    white-space: nowrap;
    text-overflow: ellipsis;
}

.timestamp {
    font-style: italic;
    font-size: small;
}

.load-more {
    margin: 1rem;
    padding: .5rem 1rem;
    border: none;
    border-radius: 1rem;
    background-color: rgb(155, 191, 56);
    font-weight: bold;
}
</style>