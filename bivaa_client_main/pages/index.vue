<template>
  <v-row justify="center" align="center">
    <v-col cols="12" sm="8" md="6">
      
      <v-card>
        <v-card-title class="headline">
          Vítejte v online aplikaci pro předávání služeb
        </v-card-title>
        <v-card-text>
          <p>
            Tato aplikace slouží k předávání služeb mezi lékaři Pneumologické kliniky FN Motol.
          </p>
          <p>
           Princip předávání služby: Ošetřující lékaři přepíší své pacienty do tabulky a lékař ve službě má
           díky tomu přehled, co za pacienty na oddělení má. 
          </p>
          <p>
            V současné době se používá k předávání pouze předtištěný list papíru, který je velmi náchylný k poškození či ztrátě
          </p>
          <p>
            Tato aplikace má sloužit jako prototyp, který bude demostrovat výhody elektronického řešení např:
            <ul>
            <li>Přenositelnost</li>
             <li>Zálohovatelnost</li> 
             <li>Ochrana proti ztrátě či poškození</li> 
            </ul>
            </p>
                      <p>
            Dalším krokem bude postupné přidávání funkcí jako například
            <ul>
            <li>Šifrování a autentizace</li>
             <li>Přidání ToDo listu</li> 
             <li>Optimalizace pro mobilní telefony</li> 
            </ul>
            </p>
          <p>
            Děkuji za Vaši podporu a za shovívavost vůči případným nedostatkům
          </p>
          <div class="text-xs-right">
            <em><small>&mdash; MUDr. Štěpán Fojtů</small></em>
          </div>

        </v-card-text>
        <v-card-actions>
          <v-spacer />
          <v-btn color="primary" nuxt to="/patients"> Pokračovat </v-btn>
        </v-card-actions>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
export default {
  name: 'IndexPage',
}
</script>
