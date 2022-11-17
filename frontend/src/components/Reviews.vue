<script setup lang="ts">

function formatDate(date: Date) {
    return date.toLocaleDateString()
}


const reviews: Review[] = [
    {
        name: "Matti Meikäläinen",
        email: "mattimeikalainen@gmail.com",
        content: "Vitae quod repudiandae eligendi sequi recusandae dolores.",
        timestamp: new Date()
    },
    {
        name: "Maija Mallikas",
        email: "maija.m@outlook.com",
        content: "Lorem ipsum dolor sit amet consectetur adipisicing elit.",
        timestamp: new Date()
    },
    {
        name: "Anssi Ahola",
        email: "anssia.ahola@gmail.com",
        content: `
        Porro, iste minima adipisci et fugit facere mollitia ut alias
        Porro, iste minima adipisci et fugit facere mollitia ut alias
        Porro, iste minima adipisci et fugit facere mollitia ut alias
        Porro, iste minima adipisci et fugit facere mollitia ut alias
        Porro, iste minima adipisci et fugit facere mollitia ut alias
        `,
        timestamp: new Date()
    },
    {
        name: "Jane Doe",
        email: "jane.doe@missing.com",
        content:
            `
        Veniam laborum iusto, velit consequuntur?
        Veniam laborum iusto, velit consequuntur?
        Veniam laborum iusto, velit consequuntur?
        Veniam laborum iusto, velit consequuntur?
        Veniam laborum iusto, velit consequuntur?
        Veniam laborum iusto, velit consequuntur?
        `,
        timestamp: new Date("2022-01-01 00:12:00")
    }
]
</script>

<template>
    <div class="container">
        <div class="title">
            <h4>Arviot</h4>
        </div>
        <div class="reviews">
            <div class="card shadow" v-for="review in reviews">
                <div class="header">
                    <span class="reviewer">{{ review.name }}</span>
                    <span class="timestamp">{{ formatDate(review.timestamp) }}</span>
                </div>
                <div class="content">
                    <i>
                        "{{ review.content }}"
                    </i>
                </div>
            </div>
        </div>
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