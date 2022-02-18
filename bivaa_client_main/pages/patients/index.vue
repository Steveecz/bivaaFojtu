<template>
    <v-row>
        <v-col v-for="patient in patients" :key="patient.ID" cols="12" sm="12">
            <v-card>
                <v-card-title>{{ patient.name }}</v-card-title>
                <v-card-text> Diagnóza: {{ patient.diagnose }} </v-card-text>
                <v-card-text> Číslo pokoje: {{ patient.room }} </v-card-text>
                <v-btn
                    :nuxt="true"
                    :to="{
                        name: 'patients-id',
                        params: { id: patient.id },
                    }"
                >
                    Zobrazit
                </v-btn>
                <v-btn
                    :nuxt="true"
                    :to="{
                        name: 'patients-id-edit',
                        params: { id: patient.id },
                    }"
                >
                    Upravit
                </v-btn>
                <ButtonDeletePatient @done="refresh" :id="patient.id">
                    Vymazat
                </ButtonDeletePatient>
            </v-card>
        </v-col>
    </v-row>
</template>

<script>
export default {
    async asyncData({ app, params }) {
        let patients = await app.$axios.$get('patient/all')
        return {
            patients,
        }
    },
    methods: {
        async refresh() {
            this.patients = await this.$axios.$get('patient/all')
        }
    }
}
</script>
