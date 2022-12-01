<script setup lang="ts">

let email = "matti.mallikas@example.com"
let mailto = "mailto:" + email
</script>

<template>
  <main>
    <h1 class="title">
      Yhteystiedot
    </h1>
    <div class="content">
      <div class="call-to-action">
        <p>
          Olethan meihin yhteydessä suoraan
          <a :href="mailto">sähköpostitse!</a>
        </p>
        <p>
          Meidät tavoittaa myös puhelimitse numerosta 010 1234 567
        </p>
      </div>
      <div class="contact-info">
        <div class="row">
          <label>
            Sähköpostiosoite:
          </label>
          <div>{{ email }}</div>
        </div>
        <div class="row">
          <label>
            Puhelin:
          </label>
          <div>010 1234 567</div>
        </div>
        <div class="row">
          <label>
            Osoite:
          </label>
          <div>
            Pohjoinen Rautatienkatu 1<br>11130 Riihimäki
            <br>
            <a class="link-to-map" href="https://goo.gl/maps/62Q8tCE9zLqidE3j7" target="_blank">
              Kartalla
            </a>
          </div>
        </div>
      </div>
    </div>
  </main>
</template>

<style scoped>
main {
  display: flex;
  flex-direction: column;
  align-items: center;
}

.title {
  margin: 2rem auto;
}

.call-to-action {
  font-size: larger;
}

.contact-info {
  margin-top: 2rem;
}

.contact-info .row {
  margin-bottom: 1rem;
}

.contact-info label {
  display: block;
  font-size: large;
  font-weight: 600;
  color: rgb(96, 96, 96);
  margin-bottom: .2rem;
}

.link-to-map {
  font-size: small;
  font-weight: bold;
}
</style>