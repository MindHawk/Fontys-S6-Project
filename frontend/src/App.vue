<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <Room/>
  </div>
</template>

<script>
import Room from './components/Room.vue'

export default {
  name: 'App',
  components: {
    Room,
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
