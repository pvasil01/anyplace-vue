<template>

  <div class="home">

    <map-leaflet :places="places"></map-leaflet>
    <div class="container-fluid">
      <!-- TOP ROW: button-menu-left, search-box, profile-menu -->
      <div class="row">
        <div class="d-flex justify-content-between align-items-center py-4">
          <!--  btn-group: button-menu-left AND button-search IN LARGE SCREEN -->
          <!--  MAIN-MENU:     -->
          <div class="btn-group " role="group" id="mobLeftIcons">
            <div id="wrapper-menu-search" class="input-group">
              <button id="button-menu-left" class="input-group-text bg-white"><i class="fas fa-bars"></i></button>
              <!--  menu-left content: -->

              <menu-left> </menu-left>

              <!--SEARCH INPUT:-->
              <search-location :places="places"></search-location>



            </div>
          </div>

          <!-- PROFILE - MENU-->
          <profile-menu></profile-menu>

        </div>

      </div>

    </div><!-- end of container-fluid-->


    <!--   ALIGN-BUTTONS-ON-BOTTOM : align circle buttons on right-end of page -->
    <div class="container-fluid">
      <div class="row align-buttons-on-bottom">
        <div class="col">
            <bottom-right></bottom-right>
        </div>
      </div>
    </div>  <!-- end of container-fluid -->

    <!-- MODALS -->
    <!-- PROFILE-MODAL -->
    <modal-right> </modal-right>

  </div>
</template>

<script lang="ts">
import {Options, Vue} from 'vue-class-component';
import MapLeaflet from "@/components/MapLeaflet.vue";
import MenuLeft from "@/components/menu-left.vue";
import SearchLocation from "@/components/search-location.vue";
import ProfileMenu from "@/components/profile-menu.vue";
import BottomRight from "@/components/bottom-right.vue";
import ModalRight from "@/components/modal-right.vue";
import axios from "axios"; // @ is an alias to /src
//import {SCREEN_SIZE_MEDIUM} from "@/main.ts";

@Options({
  name: "Anyplace",
  components: {
    ModalRight,
    BottomRight,
    ProfileMenu,
    SearchLocation,
    MenuLeft,
    MapLeaflet,
  },
  data() {
    return {
      places: null
    }
  },
  mounted() {

       // enableUiWithoutVue() // TODO break it up and do it with vue
    axios
        .post('https://ap.cs.ucy.ac.cy:44/api/mapping/space/public',{})
      //   .then(data=>console.log(data.data.spaces))
        .then(data=> (this.places=data.data.spaces))


        .catch(err=>console.log(err))

  },

  methods: {
  }
})

export default class Home extends Vue { }

// TODO with vue/components/etc..
function enableUiWithoutVue(): void {
  console.log("enableUiWithoutVue")



//  const SCREEN_SIZE_MEDIUM = 1007
  //const SCREEN_SIZE_MEDIUM=process.env.VUE_APP_SCREEN_SIZE_MEDIUM

  // UNIQUE ELEMENTS:
  /** search box. on mobile is hidden when not in use. */
  const elInputSearch: HTMLInputElement = document.getElementById('input-search') as HTMLInputElement
  /** bars button that shows the left menu ({@link elMenuLeft}) */
  const elButtonOpenMenuLeft: HTMLButtonElement = document.getElementById('button-menu-left') as HTMLButtonElement
  /** Left full-height menu for app-specific options (e.g. anyplace architect) */
  const elMenuLeft: HTMLDivElement = document.getElementById('menu-left') as HTMLDivElement
  /** button that closes {@link elMenuLeft} */
  const elButtonCloseMenuLeft: HTMLButtonElement = document.getElementById('button-close-menu-left') as HTMLButtonElement
  /** When clicked is submits a search query */
  const elButtonSearch: HTMLButtonElement = document.getElementById('button-search') as HTMLButtonElement

  /** Wrapper of the **top-left** menu-search component that consists of:
   *    - bars-menu button {@link elButtonOpenMenuLeft},
   *    - search input {@link elInputSearch}, and
   *    - search button {@link elButtonSearch}
   */
  const elWrapperMenuAndSearch: HTMLDivElement = document.getElementById('wrapper-menu-search') as HTMLDivElement

  /** Wrapper for the bottom-right buttons */
  const elWrapperActions: HTMLDivElement = document.getElementById('wrapper-actions') as HTMLDivElement
  /** Toggles the bottom-right action buttons */
  const elButtonToggleActions: HTMLButtonElement = document.getElementById('button-toggle-actions') as HTMLButtonElement

/*

  function isScreenMediumOrSmall() {
    return document.body.clientWidth < SCREEN_SIZE_MEDIUM
  }

  function isHiddenInputSearchOnMobile() {
    return elInputSearch.classList.contains("d-none")
  }

  function showInputSearchOnMobile() {
    return elInputSearch.classList.remove("d-none")
  }

  function hideInputSearchOnMobile() {
    return elInputSearch.classList.add("d-none")
  }
*/


  // SEARCH: on enter

  //elInputSearch.addEventListener("keyup", function (event) {
   // if (event.key === 'Enter') {
   //   trySearch()
  //  }
  //});


  // /!* SEARCH: on {@link elButtonSearch} press *!/

/*
  elButtonSearch.addEventListener("click", function () {
    if (isScreenMediumOrSmall()) {
      if (isHiddenInputSearchOnMobile()) {
        showInputSearchOnMobile();
        elInputSearch.focus()
      } else {
        trySearch();
        // hideInputSearchOnMobile() // optional..
      }
    } else { // large screens
      trySearch();
    }
  });
*/


  // TOGGLE LEFT MENU (app-specific menu)

  elButtonOpenMenuLeft.addEventListener("click", function (event) {
    elMenuLeft.style.display = "block";
  });
  elButtonCloseMenuLeft.addEventListener("click", function (event) {
    elMenuLeft.style.display = "none";
  });


  /** When loosing focus from the wrapper, or its children:
   * - {@link elButtonOpenMenuLeft }
   * - {@link elInputSearch}
   * - {@link elButtonSearch }
   */
/*
  elWrapperMenuAndSearch.addEventListener('focusout', (function (event) {
    // when the event concerns any other object than the child of the wrapper
    if (!this.contains((event.relatedTarget) as HTMLElement)) {
      hideInputSearchOnMobile()
    }
  }));
*/

  /** If {@link elInputSearch } has any text, then perform a query. */
  function trySearch() {
    if (elInputSearch.value) {
      // TODO: implement query
      console.log("query:'" + elInputSearch.value + "'")
    }
  }

  /** When clicked on {@link elButtonToggleActions }, show/hidden {@link elWrapperActions }  */
  elButtonToggleActions.addEventListener("click", function () {
    if (elWrapperActions.classList.contains("d-none")) {  // if hidden show
      elWrapperActions.classList.remove("d-none")
    } else { // hide
      elWrapperActions.classList.add("d-none");
    }
  });

  const myModalEl: HTMLElement = document.getElementById('modal-user-account') as HTMLElement;
  // eslint-disable-next-line @typescript-eslint/no-unused-vars
  myModalEl.addEventListener('hidden.bs.modal', function () {
    // keyboard: false
  })

}
</script>
