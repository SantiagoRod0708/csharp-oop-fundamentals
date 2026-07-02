namespace Constructores
{
    internal class Producto
    {
        
        private string nombre;
        private int precio;
        private string descripcion;
        private int clave;

        
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Clave { get => clave; set => clave = value; }

        public Producto(string nombre, int precio, string descripcion, int clave) 
        {
            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.clave = clave;
        }
    }
}
