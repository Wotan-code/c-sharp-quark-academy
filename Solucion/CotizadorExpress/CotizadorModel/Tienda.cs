namespace CotizadorModel
{
    public class Tienda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Prenda> Prendas { get; set; }

        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            Prendas = new List<Prenda>();
        }
    }
}
