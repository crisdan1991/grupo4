package singleton;

public class RegistroCalificacion
{
    private static RegistroCalificacion instance;
    private int contador;

    public int getContador() {
        return contador;
    }

    public void setContador(int contador) {
        this.contador = contador;
    }

    private RegistroCalificacion() {

    }

    public static RegistroCalificacion getInstance() {
        if(instance == null)
        {
            instance = new RegistroCalificacion();
        }
        return instance;

    }
    public void MostrarCalificacion(String text){
        System.out.println(text +
                "contador: " + ++contador +
                "\n" + "---------");
    }



}
