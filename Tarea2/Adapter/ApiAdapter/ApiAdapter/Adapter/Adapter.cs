namespace adapter.Adapter
{
    public class Adapter : IDispositivo
    {
        private Dispositivo2 dispositivo2 = new Dispositivo2();

      public decimal ObtenerTemperatura(string bloque)
        {
            decimal valorF = this.dispositivo2.ObtenerTemperaturafahrenheit(bloque);
            return TransformarDato(valorF);
        }

     public string ObtenerTipoMedida()
        {
            throw new NotImplementedException();
        }

        private decimal TransformarDato(decimal Temperatura)
        {
            return (Temperatura - 32) / 1.8M;
        
        }
    }
}
