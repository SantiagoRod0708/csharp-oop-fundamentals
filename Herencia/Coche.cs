namespace Herencia
{
    internal class Coche : Vehiculo
    {
        public override string MostrarInformacion()
        {
            
            return base.MostrarInformacion() + $"\r\n Numero de puertas: {NumPuerta}";
        }
    }
}
