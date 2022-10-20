import axios from "axios";
import { BASE_TRX_WEB_API } from "@/config/api.js";

import HelperMixin from "../../mixins/mixin"


var VehiculoServicio = {
  methods: {
    async consultaVehiculoPorPlaca({placa}){
       try {
        const params = {
          Placa: placa
        }

        const url = `${BASE_TRX_WEB_API}/Auto/ConsultaVehiculoPorPlaca`

        const data = await (await axios.post(url, params)).data

        return data
        
      } catch (exception) {
        console.error(exception);
      }
    },

    async calcularMatricula({placa}){
      try {
       const params = {
         Placa: placa
       }

       const url = `${BASE_TRX_WEB_API}/Auto/CalcularMatricula`

       const data = await (await axios.post(url, params)).data

       return data
       
     } catch (exception) {
       console.error(exception);
     }
   },
 },
};

export default VehiculoServicio;