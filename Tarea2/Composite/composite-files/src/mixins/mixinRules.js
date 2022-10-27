var MixinRules = {
    data: ()=> ({
        mixinRule: {
            required: value => !!value || "Campo Obligatorio",

            requiredNoZero: (value) => {
                let esvalido = true;
                let valor = parseInt(value);
                
                if(valor == 0 || !valor){
                    esvalido = false;
                }

                return esvalido ||  'Campo Obligatorio'
            },

            requiredWithZero: (value) => {
                let esvalido = true;
                let valor = parseInt(value);
                
                if(!valor){
                    esvalido = false;
                }

                return esvalido ||  'Campo Obligatorio'
            },

            soloNumerosYLetrasSinEspacio: value => {
                const pattern = /^([a-zA-Z0-9|]+)$/;
                return pattern.test(value) || "Ingrese solo numeros y letras";
            },
        
            soloNumerosYLetrasConEspacio: value => {
                const pattern = /^([a-zA-Z 0-9]+)$/;
                return pattern.test(value) || "Ingrese solo numeros y letras";
            },

            telefono: (value, size) => {
                return value.length === size || 'Teléfono no válido'
            },

            rangeValidator: (value, minValue, maxValue, texto) => {
                //console.log('value: ' + value + ' minValue: ' + minValue + ' maxValue: ' + maxValue)
                if(!value)
                {
                    return true;
                }

                if(value >= minValue &&  value <= maxValue){
                    return true;
                }else{
                    return texto + (value < minValue ? 
                                                    ' Mínimo es ' + minValue : 
                                                    ' Máximo es ' + maxValue)
                }
                
            },

            rangeValidatorWithCero: (value, minValue, maxValue, texto) => {
                //console.log('value: ' + value + ' minValue: ' + minValue + ' maxValue: ' + maxValue)

                if(value >= minValue &&  value <= maxValue){
                    return true;
                }else{
                    return texto + (value < minValue ? 
                                                    ' Mínimo es ' + minValue : 
                                                    ' Máximo es ' + maxValue)
                }
                
            },

            rangeDateValidator: (value, minValue, maxValue, texto) => {
                let valueDate = new Date(value);
                let minValueDate = new Date(minValue);
                let maxValueDate = new Date(maxValue);

                if(!valueDate)
                {
                    return true;
                }

                if(valueDate >= minValueDate &&  valueDate <= maxValueDate){
                    return true;
                }else{
                    return texto + (valueDate < minValueDate ? 
                                                    ' Mínimo es ' + minValue : 
                                                    ' Máximo es ' + maxValue)
                }
                
            },

            maxValidator: (value, maxValue, texto) => {
                return value <= maxValue || 'El ' + texto + ' máximo es ' + maxValue + ' meses.'
            },

            maxValidatorValue: (value, maxValue, texto) => {
                return value <= maxValue || 'El valor ' + texto + ' máximo es ' + maxValue + '.'
            },

            requiredSelect: value => !!value || "Campo Obligatorio",

            nacionalidadNoEcu: value => value === 'ECU' ||  "Solo Créditos Nacionales",

            emailRequired: v => {
                const pattern = /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
                return pattern.test(v) || "Correo no válido";
            },

            soloNumerosYLetrasSinEspacio: value => {
                const pattern = /^([a-zA-Z0-9]+)$/;
                return pattern.test(value) || "Ingrese solo numeros y letras";
            },

            codigoDactilar: value => {
                const pattern = /^([a-zA-Z0-9|]+)$/;
                return pattern.test(value) || "Ingrese solo numeros y letras";
            },

            esCedulaValida: (esCedulaValida, mensajeCedulaNovalida) => {
                if (!esCedulaValida) return mensajeCedulaNovalida;
                else return true;
            },

            esTelefonoRepetido: (esTelefonoRepetido, mensajeTelefonoRepetido) => {
                if (esTelefonoRepetido) return mensajeTelefonoRepetido;
                else return true;
            },

            esCedulaValidaConyuge: (esCedulaValidaConyuge, mensajeCedulaNovalidaConyuge) => {
                if (!esCedulaValidaConyuge) return mensajeCedulaNovalidaConyuge;
                else return true;
            },

            textNumberSpaces: value => {
                const pattern = /^([a-zA-Z0-9ÑñÁáÉéÍíÓóÚú\s]+)$/;
                return pattern.test(value) || "No se permite caracteres especiales ni ñ";
            },

            textNumberNoSpaces: value => {
                const pattern = /^([a-zA-Z0-9ÑñÁáÉéÍíÓóÚú]+)$/;
                return pattern.test(value) || "No se permite caracteres especiales ni ñ";
            },

            textSpaces: value => {
                const pattern = /^([a-zA-ZÑñÁáÉéÍíÓóÚú\s]+)$/;
                return pattern.test(value) || "Ingrese solo letras";
            },

            textSpacesNoTilde: value => {
                const pattern = /^([a-zA-ZÑñ\s]+)*$/;
                return pattern.test(value) || "Ingrese solo letras sin tilde";
            },

            textNoSpaces: value => {
                const pattern = /^([a-zA-ZÑñÁáÉéÍíÓóÚú]+)$/;
                
                if(value){
                    return pattern.test(value) || "Ingrese solo letras sin espacio";
                }

                return true;
            },

            noNegativeNumbers: value => {
                const pattern = /^[+]?([0-9]+(?:[\.][0-9]*)?|\.[0-9]+)$/;
                return pattern.test(value) || "No se acepta valor negativo";
            },

            compareValidator: (firtsValue, secondValue, text1, text2, esMayor) => {
                if(!firtsValue || !secondValue)
                {
                    return true;
                }
                
                let mayorMenor = esMayor ? 'Mayor': 'Menor';

                if(Number(firtsValue) <= Number(secondValue) && esMayor){
                    return text1 + ' debe ser '+ mayorMenor +' a ' + text2
                }

                if(Number(firtsValue) >= Number(secondValue) && !esMayor){
                    return text1 + ' debe ser '+ mayorMenor +' a ' + text2
                }

                return true;
                
            },




            /************************************** User Rules ******************************/
            numeroMinCaracteres: value => value.length > 7 || "Mínimo 8 caracteres",

            numeroMinCaracteresUsuario: value => value.length > 3 || "Mínimo 4 caracteres",

            minimo6Caracteres: value => value.length >= 6 || "Mínimo 6 caracteres",

            minimo4Caracteres: value => value.length >= 4 || "Mínimo 4 caracteres",

            contadorToken: value => value.length <= 6 || "Maximo 6 digitos",

            minChar: (value, min) => {
                return value.length >= min || "Mínimo "+  min +" caracteres"
            },

            loginPatern: value => {
                const pattern = /^([*.ña-zÑA-Z0-9]+)$/;
                return pattern.test(value) || "No se permite caracteres especiales ni ñ";
            },

            claveSegura: value => {
                const pattern = /^(?=.*\d)(?=.*[a-záéíóúüñ]).*[A-ZÁÉÍÓÚÜÑ]/;
                return (
                pattern.test(value) ||
                "Tu clave debe tener al menos un número, una minúscula y una mayúscula"
                );
            },

            coincideClave: (passwordNuevo, passwordNuevoRepite) => {
                if (passwordNuevo !== passwordNuevoRepite)
                return "La clave no coincide";
                else return true;
            },

            hasRepeatedChars: (value) => {
                const pattern = /^(?!.*?(.)\1\1).+/mg;
            
                return pattern.test(value);
            },

            hasRepeatedCharsInUserName: (value) => {
                const pattern = /^(?!.*?(.)\1\1).+/mg;
            
                return pattern.test(value) || "NO más de 2 caracteres seguidos repetidos";
            },

            exist: (value) => {
                if(value){
                    return 'Este nombre ya está ocupado..!!'
                }
                else{
                    return true;
                }
            },

            codigoValido: (value, message) => {
                return value === true || message
            },
        }
    })
};

export default MixinRules;


