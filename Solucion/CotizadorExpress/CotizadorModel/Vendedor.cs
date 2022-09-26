namespace CotizadorModel
{
    public class Vendedor
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string CodVendedor { get; set; }
        public List<Cotizacion> Cotizaciones { get; set; }
        public Tienda Tienda { get; set; }

        public Vendedor(string nombre, string apellido, string codVendedor, Tienda tienda)
        {
            Nombre = nombre;
            Apellido = apellido;
            CodVendedor = codVendedor;
            Cotizaciones = new List<Cotizacion>();
            Tienda = tienda;
        }
    }
}
