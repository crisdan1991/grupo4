package singleton;

public class RegistroCalificacion
{
    private static RegistroCalificacion instance;
    private double calificacion;
    private String asignatura;

    private RegistroCalificacion(String asignatura,double calificacion) {
        this.asignatura = asignatura;
        this.calificacion = calificacion;
    }

    public static RegistroCalificacion getInstance(String asignatura, double calificacion) {
        if(instance == null)
        {
            instance = new RegistroCalificacion(asignatura,calificacion);
        }
        return instance;

    }
    public double getCalificacion() {
        return calificacion;
    }

    public void setCalificacion(double calificacion) {
        this.calificacion = calificacion;
    }

    public String getAsignatura() {
        return asignatura;
    }

    public void setAsignatura(String asignatura) {
        this.asignatura = asignatura;
    }


}
