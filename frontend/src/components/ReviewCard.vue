<script setup lang="ts">
import type { Review } from '@/models/Review';
defineProps<{
    review: Review
}>()

function formatDate(date: Date | string) {
    if (typeof date == "string") {
        date = new Date(date)
    }
    return date.toLocaleDateString()
}
</script>

<template>
    <div class="card shadow">
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
</template>

<style scoped>
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
</style>