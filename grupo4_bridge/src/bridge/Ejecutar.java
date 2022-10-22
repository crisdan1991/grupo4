package bridge;

public class Ejecutar
{
    public static void main(String[] args)
    {
        System.out.println("Bridge");
        var inscripcion1 = new InscripcionGrado(new InscripcionPresencialImpl());
        inscripcion1.setNivelEstudio(NivelEstudio.GRADO);
        var inscripcion2 = new InscripcionPosgrado(new InscripcionPresencialImpl());
        inscripcion2.setNivelEstudio(NivelEstudio.POSGRADO);
        var inscripcion3 = new InscripcionTecnologia(new InscripcionPresencialImpl());
        inscripcion3.setNivelEstudio(NivelEstudio.TECNOLOGIA);


        if(inscripcion1.controlNivelEstudio()){
            inscripcion1.inscribir();
        }
        else{
            System.out.println("No es posible inscribir al estudiante");
        }
        if(inscripcion2.controlNivelEstudio()){
            inscripcion2.inscribir();
        }
        else{
            System.out.println("No es posible inscribir al estudiante");
        }
        if(inscripcion3.controlNivelEstudio()){
            inscripcion2.inscribir();
        }
        else{
            System.out.println("No es posible inscribir al estudiante");
        }
    }
}
