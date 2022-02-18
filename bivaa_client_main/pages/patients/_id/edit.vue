<template>
    <v-form>
        <v-text-field
            v-model="form.name"
            label="Jméno pacienta"
            required
        ></v-text-field>

        <v-text-field
            v-model="form.diagnose"
            label="Diagnóza"
            required
        ></v-text-field>

        <v-text-field
            v-model="form.room"
            label="Číslo pokoje"
            required
        ></v-text-field>

        <v-btn color="success" class="mr-4" @click="submit()">
            Uložit
        </v-btn>
        <v-btn color="primary" nuxt to="/patients">
        Zpět 
        </v-btn>
    </v-form>
</template>

<script>
export default {
  async asyncData({ app, params }) {
    let patient = await app.$axios.$get(`/patient/detail/${params.id}`)
    return {
      form: patient,
    }
  },
  methods: {
    submit() {
      this.$axios
        .$put(`/patient/update/${this.form.id}`, this.form)
        .then(() => {
          this.$router.push('/patients')
        })
        .catch((error) => {
          console.log(error)
        })
    },
  },
}
</script>
