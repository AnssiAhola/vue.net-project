<script setup lang="ts">
</script>

<template>
    <form action="" class="my-form">
        <div class="input-container">
            <label for="name">Nimi</label>
            <input class="shadow" type="text" name="name" id="">
        </div>
        <div class="input-container">
            <label for="email">Sähköpostiosoite</label>
            <input class="shadow" type="email" name="email" id="">
        </div>
        <div class="input-container">
            <label for="address">Vapaa kenttä</label>
            <textarea class="shadow" type="textarea" name="address" id=""></textarea>
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

input, textarea {
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