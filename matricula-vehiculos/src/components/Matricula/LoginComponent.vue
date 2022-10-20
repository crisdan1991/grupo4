<template>
  <div class="login-page wrapper">
    <v-row justify="center">
      <v-col cols="12" sm="12" md="6">
        <v-card>
          <v-card-title> CALCULAR MATRICULA VEHICULAR </v-card-title>

          <v-divider class="mx-3"></v-divider>

          <v-card-text>
            <v-form
              ref="formRegistroUsuario"
              v-model="formValid"
              lazy-validation
            >
            <v-row>
              <v-col>
                <CampoTexto
                    v-model.trim="placa"
                    :label="'Placa'"
                    :maxlength="10"
                    :rules="[mixinRule.required]"
                  />
              </v-col>

              <v-col>
                <v-btn :loading="loading" block color="teal" @click="consultaVehiculoPorPlaca()">
                  Consultar
                </v-btn>
              </v-col>
            </v-row>

            <CampoTexto
                v-model.trim="nombrePropietario"
                :label="'Propietario'"
                :maxlength="50"
                :rules="[mixinRule.required]"
              />

              <v-row>
                <v-col>
                  <CampoTexto
                v-model.trim="marca"
                :label="'Marca'"
                :maxlength="50"
                :rules="[mixinRule.required]"
              />
                </v-col>

                <v-col>
                  <CampoTexto
                    v-model.trim="avaluo"
                    :label="'Avalúo'"
                    :maxlength="50"
                    :rules="[mixinRule.required]"
                  />
                </v-col>
              </v-row>

              <v-row>
                <v-col>
                  <CampoTexto
                    v-model.trim="anioFabricacion"
                    :label="'Año de Fabricación'"
                    :maxlength="10"
                    :rules="[mixinRule.required]"
                  />
                </v-col>

                <v-col>
                  <CampoTexto
                    v-model.trim="cilindraje"
                    :label="'Motor/Cilindraje'"
                    :maxlength="50"
                    :rules="[mixinRule.required]"
                  />
                </v-col>
              </v-row>


              <CampoTexto
                v-model.trim="paisOrigen"
                :label="'País de Origen'"
                :maxlength="10"
                :rules="[mixinRule.required]"
              />

              <CampoTexto
                v-model.trim="color"
                :label="'Color'"
                :maxlength="50"
                :rules="[mixinRule.required]"
              />
            </v-form>

            <AlertComponent
              :showAlert="showerror"
              :title="title"
              :color="color"
              :description="error"
            />

            <v-divider></v-divider>

            <p style="font-size:1.8rem" class="mt-3">El valor a pagar es: ${{valorMatricula}}</p>

            <v-row class="mt-6">
              <v-spacer></v-spacer>
              <v-btn block color="teal" @click="calcularMatricula()">
                Calcular Matricula
              </v-btn>
              <v-spacer></v-spacer>
            </v-row>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </div>
</template>

<script>
import UsuarioComponent from "@/components/controles/TextLowerNoSpacesComponent.vue"
import CampoTexto from "@/components/controles/TextLowerNoSpacesComponent.vue";
import PasswordComponent from "@/components/controles/PasswordComponent.vue";
import VehiculoServicio from "@/components/Matricula/VehiculoServicio.js";
import HelperMixin from "../../mixins/mixin";
import AlertComponent from "@/components/controles/AlertComponent.vue";

export default {
  components: {
    UsuarioComponent,
    AlertComponent,

    CampoTexto,
    PasswordComponent,
    AlertComponent
  },

   data: ()=> ({
    placa: "",
    anioFabricacion: 0,
    paisOrigen: "",
    nombrePropietario:"",
    avaluo: 0,
    color:"",
    cilindraje:0,
    marca:"",

    valorMatricula: 0,




    formValid: true,
    mostrarLoading: false,

    showerror: false,
    error: null,
    loading: false
  }),

  methods: {
    async consultaVehiculoPorPlaca(){
        this.loading = false

        this.loading = true

        this.error = null
        this.showerror = false

        const data = await VehiculoServicio.methods.consultaVehiculoPorPlaca({placa: this.placa})

        this.placa = data.placa;
        this.anioFabricacion = data.anioFabricacion;
        this.paisOrigen = data.paisOrigen;
        this.nombrePropietario = data.nombrePropietario;
        this.avaluo = data.avaluo;
        this.color = data.color;
        this.cilindraje = data.cilindraje;
        this.marca = data.marca;

        this.loading = false
      },

      async calcularMatricula(){
        this.loading = false

        this.loading = true

        this.error = null
        this.showerror = false

        const data = await VehiculoServicio.methods.calcularMatricula({placa: this.placa})

        this.valorMatricula = data.toFixed(2);

        this.loading = false
      }
    }
}
</script>
<style>
.login-box-container {
      width: 920px;
      height: 420px;
      background: rgb(0, 0, 0, 0.5);
      color: var(--blue-primary);
      top: 50%;
      left: 50%;
      position: absolute;
      transform: translate(-50%, -50%);
      box-sizing: border-box;
      padding: 70px 30px;  
      -webkit-box-shadow: 5px 5px 7px #5D6778;
    }

.login-box {
      width: 420px;
      height: 515px;
      background: #ffffff;
      color: var(--blue-primary);
      top: 50%;
      left: 50%;
      position: absolute;
      transform: translate(-50%, -50%);
      box-sizing: border-box;
      padding: 70px 30px;
      border-radius: 30px 30px 30px 30px;
      border-top: solid 3px var(--red-primary);
    }

.login-box-container .avatar {
      width: 200px;
      height: 200px;
      border-radius: 5%;
      position: absolute;
      top: -50px;
      left: calc(50% - 50px);
      z-index: 99999 !important;
    }


p {
  line-height: 1rem;
}

.v-card {
  padding: 20px;
}

.login-page {
  align-items: center;
  display: flex;
  height: 100vh;
}
.avatar {
  margin-left: 30%;
  margin-top: -110px;
}
.text-light {
  text-align: center;
  font-size: 27px;
}
.wrapper {
  justify-content: center;
  align-items: center;
  background: rgb(213, 13, 74);
  background: linear-gradient(180deg, #4ad8e2 0%, #0e8ed4 78%, #29c1ad 100%);
}
.v-btn {
  border: 100px;
}
</style>