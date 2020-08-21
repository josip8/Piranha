Vue.component("test-block", {
  props: ["uid", "toolbar", "model"],
  methods: {
      onBlur: function (e) {
          this.model.body.value = e.target.innerText;
      }
  },
  computed: {
      isEmpty: function () {
          return piranha.utils.isEmptyText(this.model.body.value);
      }
  },
  template:
      "Hello from custom block<div class='block-body' :class='{ empty: isEmpty }'>" +
      "  <i class='fas fa-quote-right quote'></i>" +
      "  <p class='lead' contenteditable='true' spellcheck='false' " +
      "    v-html='model.body.value' v-on:blur='onBlur'></p>" +
      "</div>"
});