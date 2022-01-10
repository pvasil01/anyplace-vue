<template>
  <div id="map"></div>

<!--
  <building v-for="building in places" :key="building" ></building>
-->

</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';

import "leaflet/dist/leaflet.css";
import L from "leaflet";
import building from "@/components/building.vue";
import Building from "@/components/building.vue";

@Options({
  components: {Building},
  props: {
    msg: String,
    places: Array,
  },
  data() {
    return {
      map: null
    };
  },

  mounted() {
   // this.bindLeafletOSM(); // WAY1
     this.bindLeafletWithMapBox();  // WAY2
  },

    beforeDestroy() {
      if (this.map) {
        this.map.remove();
      }
    },
  methods: {
    bindLeafletOSM: function() {
      this.map = L.map('map').setView([51.959, -8.623], 12);
      L.tileLayer("http://{s}.tile.osm.org/{z}/{x}/{y}.png", {
        attribution:
            '&copy; <a href="http://osm.org/copyright">OpenStreetMap</a> contributors'
      }).addTo(this.map);
    },
    bindLeafletWithMapBox: function() {
      const MAPBOX_TOKEN = process.env.VUE_APP_MAPBOX_TOKEN; // sign up: 'https://account.mapbox.com/access-tokens'
      this.map = L.map('map').setView([37.8496184,25.2963279], 3);
      L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors, Imagery © <a href="https://www.mapbox.com/">Mapbox</a>',
        maxZoom: 18,
        minZoom:2.5,
        id: 'mapbox/streets-v11',
        tileSize: 512,
        zoomOffset: -1,
        accessToken: MAPBOX_TOKEN
      }).addTo(this.map);
      var marker = L.marker([51.5, -0.09]).addTo(this.map);
      marker.bindPopup("<b>Hello world!</b><br>I am a popup.").openPopup();

      /*  for (let i=0; i<this.places.length; i++) {
          var marker = L.marker([this.places[i].coordinates_lat, this.places[i].coordinates_lon]).addTo(this.map);

        }*/



    }
  },

})

export default class MapLeaflet extends Vue {
  msg!: string /** parameter accepted by the {@link MapLeaflet} class */
}
</script>

<!-- scoped: limits CSS to this component only -->
<style scoped lang="scss">
#map {
    width: 100vw;
    height: 100vh;
}
</style>
