import Vue from 'vue';

// Initialize the annoying-background directive.
export const ReemplazaTexto = {
  bind(el) {    
    //console.log('DIRECTIVA CUSTOM ' + el.innerHTML + ' tipo ' + typeof(el.innerHTML));

    if(el.innerHTML.includes('No existen movimientos'))
      return;

    el.innerHTML = 
      el.innerHTML.toString()
                             .replace(/`TRANSFERENCIA`/g, 'TRANS')
                             .replace(/CUENTA/g, 'CTA')
                             .replace(/CAJERO/g, 'CAJ')
                             .replace(/AUTOMATICO/g, 'AUTOMATIC')
                             .replace(/ADMINISTRATIVO/g, 'ADM')
                             .replace(/SUCURSAL/g, 'SUC')

    //console.log('DIRECTIVA CUSTOM REEMP: ' + el.innerHTML);
  }
}

// You can also make it available globally.
Vue.directive('reemplaza-texto', ReemplazaTexto)


export const BackgroundRow = {
  bind(el) {    
    el = 
      el.style
  }
}

Vue.directive('background-row', BackgroundRow)

export const UpperCase = {
  twoWay: true,
  update(el, _, vnode) {
    el.addEventListener('input', async function(e) {
      e.target.value = e.target.value.toUpperCase()
      vnode.componentInstance.$emit('input', e.target.value.toUpperCase())
    })
  }
}

Vue.directive('uppercase', UpperCase)

export const LowerCase = {
  twoWay: true,
  update(el, _, vnode) {
    el.addEventListener('input', async function(e) {
      e.target.value = e.target.value.toLowerCase()
      vnode.componentInstance.$emit('input', e.target.value.toLowerCase())
    })
  }
}

Vue.directive('lowercase', LowerCase)

export const SoloNumeros = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      //console.log(e.keyCode)
      let keyCode = e.keyCode ? e.keyCode : e.which;

      if (keyCode < 48 || keyCode > 57) {
        e.preventDefault();
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}

Vue.directive('solonumeros', SoloNumeros)

export const SoloLetras = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      //console.log(e.keyCode)
      let keyCode = e.keyCode ? e.keyCode : e.which;

      if ((event.keyCode != 32) && (event.keyCode < 65) || (event.keyCode > 90) && (event.keyCode < 97) || (event.keyCode > 122)) 
      {
        if(event.keyCode != 241){
          e.preventDefault();
        }
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}

Vue.directive('sololetras', SoloLetras)



/***********************************************************************************************/
export const TextNumberSpaces = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      //console.log(e.keyCode)
      let keyCode = e.keyCode ? e.keyCode : e.which;

      if (e.key.match(/[a-z0-9ñáéíóú\s]/i)===null) 
      {
        if(event.keyCode != 241){
          e.preventDefault();
        }
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}
Vue.directive('text-number-spaces', TextNumberSpaces)

/***********************************************************************************************/
export const TextNumberNoSpaces = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      //console.log(e.keyCode)
      let keyCode = e.keyCode ? e.keyCode : e.which;

      if (e.key.match(/[a-z0-9ñáéíóú]/i)===null) 
      {
        if(event.keyCode != 241){
          e.preventDefault();
        }
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}
Vue.directive('text-number-no-spaces', TextNumberNoSpaces)

/***********************************************************************************************/
export const TextNoSpaces = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      //console.log(e.keyCode)
      let keyCode = e.keyCode ? e.keyCode : e.which;

      if (e.key.match(/[a-zñáéíóú]/i)===null) 
      {
        if(event.keyCode != 241){
          e.preventDefault();
        }
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}
Vue.directive('text-no-spaces', TextNoSpaces)


/***********************************************************************************************/
export const TextSpaces = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      //console.log(e.keyCode)
      let keyCode = e.keyCode ? e.keyCode : e.which;

      if (e.key.match(/[a-zñáéíóú\s]/i)===null) 
      {
        if(event.keyCode != 241){
          e.preventDefault();
        }
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}
Vue.directive('text-spaces', TextSpaces)

/***********************************************************************************************/
export const AlphaNumSCharNoSpaces = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      //console.log(e.keyCode)
      let keyCode = e.keyCode ? e.keyCode : e.which;

      if (e.key.match(/[a-z0-9|]/i)===null) 
      {
        if(event.keyCode != 241){
          e.preventDefault();
        }
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}
Vue.directive('alpha-num-schar-no-spaces', AlphaNumSCharNoSpaces)



//:style="{backgroundColor: (props.item.SaldoContable > 30 ? 'red' : 'transparent')}"


export const Solo2Decimales = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keyup', async function(e) {
      let valor = e.target.value;

      let keyCode = e.keyCode ? e.keyCode : e.which;
      console.log('keyup: '+ keyCode)

      console.log(valor)

      let contadorDecimales = 0;

      if(valor.toString().split('.').length > 1){
        contadorDecimales = valor.toString().split('.')[1].length;

        if(contadorDecimales > 2){
          valor = Number(valor).toFixed(2);
          e.target.value = Number(valor);
        }
      }
      
      vnode.componentInstance.$emit('keyup', Number(e.target.value))
    })
  }
}

Vue.directive('solo2Decimales', Solo2Decimales)


export const SoloMoneda = {
  twoWay: true,
  update(el, _, vnode) {
    
    el.addEventListener('keypress', async function(e) {
      let keyCode = e.keyCode ? e.keyCode : e.which;

      let valor = e.target.value;

      let valorIndexOf = valor.indexOf('.');

      //only allow number and one dot
      if ((keyCode < 48 || keyCode > 57) && (keyCode !== 46 || valorIndexOf != -1)) { // 46 is dot
        e.preventDefault();
      }

      // restrict to 2 decimal places
      if(valor!=null && valorIndexOf >-1 && (valor.split('.')[1].length > 1)){
       e.preventDefault();
      }

      vnode.componentInstance.$emit('keypress', e.target.value)
    })
  }
}

Vue.directive('soloMoneda', SoloMoneda)



// ************************************ IMPRESION ******************************************* //
//const print = {}; 

export const print = {
  bind(el, binding) {
   // insertar css especial para la impresión, esto mostrar un contenedor especial y ocultara el resto de contenido
   let style = document.createElement('style');
   style.type = 'text/css';
   style.appendChild(document.createTextNode("@media screen{#printSection{display:none}}@media print{#printSection,body{overflow:visible!important}body *{visibility:hidden}#printSection,#printSection *{visibility:visible}#printSection{position:absolute;left:0;top:0;right:0}#printSection table{width:100%!important}}"));
   document.body.appendChild(style);

   // busco si existe mi sección para imprimir
   let printSection = document.getElementById('printSection');

   // si no existe la creo y la inserto en el body
   if (!printSection) {
      printSection = document.createElement('div');
      printSection.id = 'printSection';
      document.body.appendChild(printSection);
  }

   // creo el evento del click para cada que se de click en imprimir
   el.addEventListener('click', () => {

      // busco el contenido a imprimir, esto ya que como parametro tenia el id
      var elemToPrint = document.getElementById(binding.value);

      //si existe el contenido entonces lo imprimiré
      if (elemToPrint) {
         printSection.innerHTML = ''; // limpio el contenido anterior de mi sección a imprimir
         printElement(elemToPrint);
      }
   });

   // funcion para imprimir
   function printElement( elem ){

      // creo un nodo y lo inserto dentro de mi sección a imprimir
      let domClone = elem.cloneNode(true);
      printSection.appendChild(domClone);
      window.print(); //mando a imprimir
   }
}
}


// registro la directiva
// print.install = function( Vue ){
//    Vue.directive('print',{
//       bind( el, binding){
//          printSection( el, binding )
//       }
//    })
// }

// exporto mi directiva
Vue.directive('print', print)

// import { VueMaskDirective } from 'v-mask'
// Vue.directive('mask', VueMaskDirective);