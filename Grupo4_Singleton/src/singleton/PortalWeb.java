package singleton;

public class PortalWeb
{
    public static void main(String[] args)
    {
        System.out.println("Singleton");
        RegistroCalificacion singleton = RegistroCalificacion.getInstance("matematicas",99.00);
        RegistroCalificacion otrosingleton = RegistroCalificacion.getInstance("ingles",89.00);
        System.out.println(singleton.getAsignatura() + " " + singleton.getCalificacion());
        System.out.println(singleton.getAsignatura() + " " + singleton.getCalificacion());


    }
}
