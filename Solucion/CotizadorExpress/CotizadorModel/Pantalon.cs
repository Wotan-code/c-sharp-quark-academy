namespace CotizadorModel
{
    public class Pantalon : Prenda
    {
        public ETipoPantalon TipoPantalon { get; set; }

        public enum ETipoPantalon
        {
            comun,
            chupin
        }

        public Pantalon(int cantidad, decimal precioUnidad, ECalidad calidad, ETipoPantalon tipoPantalon) : base(cantidad, precioUnidad, calidad)
        {
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            Calidad = calidad;
            TipoPantalon = tipoPantalon;
        }

        //Devuelve la cotizacion del pantalon
        public decimal CotizarPantalon()
        {
            return TipoPantalon.Equals(ETipoPantalon.chupin) ? -12 : 0;
        }
    }
}
