<template>
  <v-row justify="center">
    <v-dialog v-model="dialogEliminarTarea" persistent>
      <v-card max-width="300">
        <v-card-title>
          <span class="text-h5">Eliminar tarea ? {{id}}</span>
        </v-card-title>

        <v-divider></v-divider>
        <v-card-text>
          <v-container>
            Confirma que deseas eliminar la tarea
          </v-container>
        </v-card-text>

        <v-divider></v-divider>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="blue-darken-1" text @click="emitCloseDialogEliminarTarea()">
            Regresar
          </v-btn>
          <v-btn color="blue-darken-1" text @click="emitEliminarTarea()">
            Confirmar
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-row>
</template>
 
<script>
import TareaServicio from "@/components/Tarea/TareaServicio.js"
import HelperMixin from '../../mixins/mixin'

  export default {
    props: ['tareaSeleccionada', 'dialogEliminarTarea', 'dialogEliminarTarea'],

    data: () => ({
    }),

    async mounted(){

    },

    methods:{
      emitCloseDialogEliminarTarea(){
        this.$emit("emitCloseDialogEliminarTarea")
      },

      emitEliminarTarea(){
        this.$emit("emitEliminarTarea")
      }
    }
  }
</script>