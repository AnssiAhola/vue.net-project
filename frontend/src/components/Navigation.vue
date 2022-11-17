<script setup lang="ts">
import { RouterLink } from 'vue-router';
</script>

<template>
    <header>
        <nav>
            <div class="nav-item">
                <RouterLink to="/" exact>Etusivu</RouterLink>
            </div>
            <!-- <div class="nav-item">
                <RouterLink to="/esittely" exact>Esittely</RouterLink>
            </div> -->
            <div class="nav-item">
                <RouterLink to="/yhteystiedot" exact>Yhteystiedot</RouterLink>
            </div>
            <div class="nav-item">
                <RouterLink to="/arvioi" exact>Arvioi</RouterLink>
            </div>
        </nav>
    </header>
</template>

<style scoped>
nav {
    height: 5rem;
    background-color: rgb(53, 49, 49);
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
    column-gap: 1rem;
    width: 100%;

    box-shadow: 0px 1px 8px 0px rgba(0, 0, 0, 0.7);
    -webkit-box-shadow: 0px 1px 8px 0px rgba(0, 0, 0, 0.7);
    -moz-box-shadow: 0px 1px 8px 0px rgba(0, 0, 0, 0.7);
}

.nav-item {
    height: 40px;
    border-radius: 2rem;
    transition: background-color ease-in-out .2s;
}

.nav-item:hover,
.nav-item:focus {
    background-color: rgba(91, 91, 91, 0.374);
}

.router-link-active {
    border-radius: 2rem;
    border: 1px solid rgba(123, 180, 120, 0.612);
}

.nav-item a {
    height: 100%;
    padding: 0 1rem;
    color: aliceblue;
    display: flex;
    align-items: center;
    justify-items: center;
}

@media (max-width: 800px) {
    nav {
        font-size: smaller;
        column-gap: 0rem;
    }
}

@media (max-width: 350px) {
    nav {
        font-size:x-small;
        column-gap: 0rem;
    }
}
</style>