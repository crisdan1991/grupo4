import axios from "axios";
import { BASE_TRX_WEB_API } from "@/config/api.js";

import HelperMixin from "../../mixins/mixin"


var DirectorioServicio = {
  methods: {
    async consultarDirectorios(){
       try {
        const params = {
        }

        const url = `${BASE_TRX_WEB_API}/Composite/ConsultarDirectorios`

        const data = await (await axios.post(url, params)).data

        return data
        
      } catch (exception) {
        console.error(exception);
      }
    },

    async guardarComponente({Id, IdPadre, Nombre, EsArchivo, TipoArchivo, Tamanio}){
      try {
       const params = {
        Id, IdPadre, Nombre, EsArchivo, TipoArchivo, Tamanio
       }

       HelperMixin.methods.consolePrint(params)

       const url = `${BASE_TRX_WEB_API}/Composite/AgregarHijo`

       const data = await (await axios.post(url, params)).data

       return data
       
     } catch (exception) {
       console.error(exception);
     }
   },
 },
};

export default DirectorioServicio;