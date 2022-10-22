package bridge;


    public class InscripcionTecnologia extends Inscripcion {

        public InscripcionTecnologia(InscripcionImpl inscripcionImpl) {
            super(inscripcionImpl);
        }

        @Override
        public boolean controlNivelEstudio() {
            var retorno = false;
            if(this.getNivelEstudio().equals(NivelEstudio.TECNOLOGIA)){
                retorno=true;
            }
            return retorno;
        }
}
