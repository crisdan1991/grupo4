package singleton;

public class Ejecutar
{
    public static void main(String[] args)
    {
        System.out.println("-------Singleton-----");
        Alumno juan = new Alumno("juan","ingles",99);
        juan.imprimirComun();
        Alumno maria = new Alumno("maria","math",79);
        maria.imprimirComun();
        Alumno pedro = new Alumno("pedro","lenguaje",89);
        pedro.imprimirComun();
        Alumno pepe = new Alumno("pepe","computacion",80);
        pepe.imprimirComun();

    }
}
