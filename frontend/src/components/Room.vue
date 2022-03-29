<script>
export default {
  data(){
    return {
      rooms: [],
      room_size: 0,
      room_occupied: false,
    }
  },
  methods: {
    getRooms(){
      fetch('http://localhost:8050/room')
      .then(response => response.json())
      .then(data => {
        this.rooms = data;
      })
    },
    postRoom() {
      fetch('http://localhost:8050/room', {
        method: 'POST',
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          roomSize: this.room_size,
          roomOccupied: this.room_occupied
        })
      })
      .then(response => response.json())
      .then(data => {
        this.rooms.push(data);
      })
    },
    deleteRoom(room) {
      fetch('http://localhost:8050/room/' + room.roomID, {
        method: 'DELETE',
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        }
      })
      .then(response => response.json())
      .then(data => {
          this.rooms = this.rooms.filter(r => r.roomID !== data.roomID);
      })
    }
  },
  mounted(){
    this.getRooms();
  }
}
</script>

<template>
  <div>
    <input v-model="room_size" type="text" placeholder="Room size">
    <input v-model="room_occupied" type="checkbox" placeholder="Room occupied">
    <button @click="postRoom">Add room</button>
    <ul>
      <h2>Rooms:</h2>
      <li v-for="room in rooms" v-bind:key="room.roomID">
        <p>Room ID: {{ room.roomID }}. Room Size: {{ room.roomSize }}. Room Occupied: {{ room.roomOccupied }}</p>
        <button @click="deleteRoom(room)">Delete room</button>
      </li>
    </ul>
  </div>
</template>