namespace Herencia
{
    internal class Vehiculo
    {
        private string color;
        private int año, numPuerta;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get => color; set => color = value; }
        public int Año { get => año; set => año = value; }
        public int NumPuerta { get => numPuerta; set => numPuerta = value; }

        public virtual string MostrarInformacion() 
        {
            return $"\r\n Marca: {Marca} \r\n Modelo: {Modelo} \r\n Año: {Año} \r\n Color: {Color}";
        }
    }
}
