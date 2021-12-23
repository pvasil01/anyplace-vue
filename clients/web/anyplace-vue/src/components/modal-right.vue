<template>
  <div class="modal-user-profile modal fade right" id="modal-user-account" aria-labelledby="exampleModalLabel"
       aria-hidden="true">
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <i class="fas fa-user fa-2x pe-3"></i>
          <h5 class="modal-title" id="exampleModalLabel">Alan Turing</h5>
          <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
        </div>
        <div class="modal-body">
          <button class="dropdown-item" type="button">Profile</button>
          <a href="settings" class="dropdown-item" type="button">Settings</a>
        </div>
        <div class="modal-footer">
          <a href="about" class="dropdown-item" type="button">About</a>
          <button class="dropdown-item" type="button">Terms of Service</button>
          <button class="dropdown-item" type="button">Privacy</button>
          <small class="text-muted mx-auto" style="font-size: 8px">Anyplace &copy; 2021</small>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "modal-right"
}
</script>

<style scoped>

</style>