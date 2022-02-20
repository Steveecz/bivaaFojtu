import Vue from 'vue'

Vue.mixin({
    methods: {
        validate(form) {
            if (form.name == '' || typeof form.name !== 'string') {
                window.alert('Jméno musí být zadáno')
                return false
            }
            if (typeof form.room !== 'number') {
                window.alert('Pokoj musí být číslo')
                return false
            }
            return true
        },
    },
})
