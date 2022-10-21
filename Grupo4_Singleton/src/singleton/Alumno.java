package singleton;

public class Alumno
{
    private final String nombre;
    private final String asignatura;
    private final int calificacion;

    public Alumno(String nombre, String asignatura, int calificacion) {
        this.nombre = nombre;
        this.asignatura = asignatura;
        this.calificacion = calificacion;
    }

    public void imprimirComun()
    {
        var registro = RegistroCalificacion.getInstance();
        if (registro.getContador()<3)
        {
            registro.MostrarCalificacion
                    (
                            "alumno: " + nombre + "\n"+
                                    "asignatura: " + asignatura + "\n"+
                                    "calificacion: " + calificacion + "\n"

                    );
        }
        else
        {
            registro.MostrarCalificacion
                    (
                            "hay mas de 3 instancias Alumno no creado : "

                    );
        }

    }
}
