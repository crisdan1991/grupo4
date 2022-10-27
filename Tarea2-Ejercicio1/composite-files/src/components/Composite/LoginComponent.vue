<template>
  <div class="login-page wrapper">
    <v-row justify="center">
      <v-col cols="12" sm="12" md="6">
        <v-card>
          <v-card-title> ADMINISTRADOR DE ARCHIVOS </v-card-title>

          <v-divider class="mx-3"></v-divider>

          <v-card-text>
            <v-form
              ref="formRegistroUsuario"
              v-model="formValid"
              lazy-validation
            >
          <v-row>
            <v-col class="mb-n3 font-weight-bold" style="font-size: 1.2rem;">Crear:</v-col>
          </v-row>
          
          <v-row>
            <v-col>
              <v-radio-group inline v-model="opcion">
                <v-radio label="Directorio raíz" value="1"></v-radio>
                <v-radio v-if="directorios.length" label="Directorio Hijo" value="2"></v-radio>
                <v-radio v-if="directorios.length" label="Archivo" value="3"></v-radio>
              </v-radio-group>
            </v-col>
          </v-row>

          <CampoTexto v-if="crearRaiz || crearHijo || crearArchivo"
                v-model.trim="nombre"
                :label="'Nombre'"
                :maxlength="50"
                :rules="[mixinRule.required]"
              />

              <SelectListComponent v-if="crearHijo || crearArchivo"
              :label="'Directorio Padre'"
                  v-model="directorioSelected"
                  :lista="directorios"
                />
            
              <SelectListComponent v-if="crearArchivo"
              :label="'Tipo de Archivo'"
                  v-model="tipoArchivoSelected"
                  :lista="tipoArchivoLista"
                />

              <v-row>
                <v-col>
                  <CampoTexto v-if="crearArchivo"
                    v-model.trim="tamanio"
                    :label="'Tamaño'"
                    :maxlength="50"
                    :rules="[mixinRule.required]"
                  />
                </v-col>
              </v-row>
            </v-form>

            <AlertComponent
              :showAlert="showerror"
              :title="title"
              :color="color"
              :description="error"
            />

            <v-divider></v-divider>

            <!-- <p style="font-size:1.8rem" class="mt-3">El valor a pagar es: ${{valorMatricula}}</p> -->

            <v-row class="mt-6">
              <v-spacer></v-spacer>
              <v-btn block color="green" @click="guardarComponente()">
                CREAR
              </v-btn>
              <v-spacer></v-spacer>
            </v-row>
          </v-card-text>
          
          <v-card-text>
            <v-treeview :items="items"></v-treeview>
          </v-card-text>

        </v-card>
      </v-col>
    </v-row>
  </div>
</template>

<script>
import UsuarioComponent from "@/components/controles/TextLowerNoSpacesComponent.vue"
import CampoTexto from "@/components/controles/TextLowerNoSpacesComponent.vue";
import DirectorioServicio from "@/components/Composite/DirectorioServicio.js";
import HelperMixin from "../../mixins/mixin";
import AlertComponent from "@/components/controles/AlertComponent.vue";
import SelectListComponent from "@/components/controles/SelectListComponent.vue";

export default {
  components: {
    UsuarioComponent,
    AlertComponent,
    SelectListComponent,

    CampoTexto,
    AlertComponent
  },

   data: ()=> ({
    esRoot: false,
    nombre: "",

    tipoArchivoLista: [{id: "Exel", nombre: "Excel" }, 
                       {id: "Word", nombre: "Word" },
                       {id: "Pdf", nombre: "Pdf" }],
    tipoArchivoSelected: null,
    opcion: null,
    tamanio:0,
    directorios:[],
    directorioSelected: null,

    valorMatricula: 0,

    formValid: true,
    mostrarLoading: false,

    showerror: false,
    error: null,
    loading: false,
    
    items: [
        {
          id: 1,
          name: 'Applications :',
          children: [
            { id: 2, name: 'Calendar : app' },
            { id: 3, name: 'Chrome : app' },
            { id: 4, name: 'Webstorm : app' },
          ],
        },
        {
          id: 5,
          name: 'Documents :',
          children: [
            {
              id: 6,
              name: 'vuetify :',
              children: [
                {
                  id: 7,
                  name: 'src :',
                  children: [
                    { id: 8, name: 'index : ts' },
                    { id: 9, name: 'bootstrap : ts' },
                  ],
                },
              ],
            },
            {
              id: 10,
              name: 'material2 :',
              children: [
                {
                  id: 11,
                  name: 'src :',
                  children: [
                    { id: 12, name: 'v-btn : ts' },
                    { id: 13, name: 'v-card : ts' },
                    { id: 14, name: 'v-window : ts' },
                  ],
                },
              ],
            },
          ],
        },
        {
          id: 15,
          name: 'Downloads :',
          children: [
            { id: 16, name: 'October : pdf' },
            { id: 17, name: 'November : pdf' },
            { id: 18, name: 'Tutorial : html' },
          ],
        },
        {
          id: 19,
          name: 'Videos :',
          children: [
            {
              id: 20,
              name: 'Tutorials :',
              children: [
                { id: 21, name: 'Basic layouts : mp4' },
                { id: 22, name: 'Advanced techniques : mp4' },
                { id: 23, name: 'All about app : dir' },
              ],
            },
            { id: 24, name: 'Intro : mov' },
            { id: 25, name: 'Conference introduction : avi' },
          ],
        },
      ],
  }),

  watch: {
    directorioSelected(){
      console.log(this.directorioSelected)
    },

    tipoArchivoSelected(){
      console.log(this.tipoArchivoSelected)
    }
  },

  computed:{
    crearRaiz(){
      return this.opcion==1 || this.opcion==2 || this.opcion==3;
    },

    crearHijo(){
      return this.opcion==2;
    },

    crearArchivo(){
      return this.opcion==3;
    },
  },

  async mounted(){
    await this.consultaDirectorios();
  },

  methods: {
    async consultaDirectorios(){
        this.loading = false

        this.loading = true

        this.error = null
        this.showerror = false

        const data = await DirectorioServicio.methods.consultarDirectorios()

        this.directorios = data;

        console.log(this.directorios)

        this.loading = false
      },

      async guardarComponente(){
        this.loading = false

        this.loading = true

        this.error = null
        this.showerror = false

        HelperMixin.methods.consolePrint(this.directorioSelected)
        HelperMixin.methods.consolePrint(this.tipoArchivoSelected)

        const data = await DirectorioServicio.methods.guardarComponente(
          {
            Id: 0, 
            IdPadre: this.directorioSelected ? this.directorioSelected.id : 0, 
            Nombre: this.nombre, 
            EsArchivo: this.crearArchivo,
            TipoArchivo: this.tipoArchivoSelected ? this.tipoArchivoSelected.id : "", 
            Tamanio: this.tamanio
          });

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
  background: linear-gradient(180deg, #055b10 0%, #18d78e 78%, #00c968 100%);
}
.v-btn {
  border: 100px;
}
</style>