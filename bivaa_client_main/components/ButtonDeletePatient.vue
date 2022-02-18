<template>
    <v-btn @click="submit()">
        <slot></slot>
    </v-btn>
</template>

<script>
export default {
    props: {
        id: {
            type: Number,
            required: true,
        },
    },
    methods: {
        submit() {
            if (!confirm('Opravdu chcete smazat pacienta?')) return
            
            this.$axios
                .delete(`/patient/delete/${this.id}`)
                .then((data) => {
                    this.$emit("done")
                    this.$router.push('/patients')
                })
                .catch((error) => {
                    console.log(error)
                })
        },
    },
}
</script>
