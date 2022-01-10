<template>
  <option><slot></slot></option>
</template>

<script>
export default {
  name: "building",
/*
  props: {
    coordinates_lat:null,
    name:null,
    buid:null,
    coordinates_lon:null,
    is_published:null,
    space_type:null
  },
  */
  data() {
    return {
    coordinates_lat: null,
      name: null,
      buid: null,
      coordinates_lon: null,
      is_published: null,
      space_type: null


    }
  },
  methods: {
    getLon: function() {
      return this.coordinates_lon;
},

    getLat: function() {
      return this.coordinates_lat;
    }
  }

}
</script>

<style scoped>

</style>