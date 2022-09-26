namespace CotizadorModel
{
    public class Cotizacion
    {
        static int ultimoId = 1;//Almacena el ultimo Id por cada instanciacion del objeto
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string CodVendedor { get; set; }
        public Prenda Prenda{ get; set; }
        public int Unidades { get; set; }
        public decimal CalculoTotal { get; set; }

        public Cotizacion(DateTime fecha, string codVendedor, Prenda prenda)
        {
            Id = ultimoId;
            ultimoId++;//Secuencia de numero por cada instanciacion de clase
            Fecha = fecha;
            CodVendedor = codVendedor;
            Prenda = prenda;
            Unidades = prenda.Cantidad;
            CalculoTotal = prenda.CotizarPrenda();//Cotiza la prenda a la hora de instanciarse el objeto
        }
    }
}
