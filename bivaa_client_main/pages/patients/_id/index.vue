<template>
    <v-row>
        <v-col cols="12" sm="12">
            <v-card>
                <v-card-title>{{ patient.name }}</v-card-title>
                <v-card-text>Diagnóza: {{ patient.diagnose }}</v-card-text>
                <v-card-text>Číslo pokoje: {{ patient.room }}</v-card-text>
                <v-btn
                    :nuxt="true"
                    :to="{
                        name: 'patients-id-edit',
                        params: { id: patient.id },
                    }"
                >
                    Upravit
                </v-btn>
                <ButtonDeletePatient :id="patient.id">
                    Vymazat
                </ButtonDeletePatient>
                <v-btn color="primary" nuxt to="/patients">
                Zpět 
                </v-btn>
            </v-card>
        </v-col>
    </v-row>
</template>

<script>
export default {
    async asyncData({ app, params }) {
        let patient = await app.$axios.$get(`/patient/detail/${params.id}`)
        return {
            patient,
        }
    },
}
</script>
