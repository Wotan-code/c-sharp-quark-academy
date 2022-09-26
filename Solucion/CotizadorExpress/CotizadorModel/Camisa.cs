namespace CotizadorModel
{
    public class Camisa : Prenda
    {
        public ECuelloCamisa CuelloCamisa { get; set; }
        public EMangaCamisa MangaCamisa { get; set; }

        public enum ECuelloCamisa
        {
            mao,
            comun
        }

        public enum EMangaCamisa
        {
            corta,
            larga
        }

        public Camisa(int cantidad, decimal precioUnidad, ECalidad calidad, ECuelloCamisa cuelloCamisa, EMangaCamisa mangaCamisa) : base(cantidad, precioUnidad, calidad)
        {
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            Calidad = calidad;
            CuelloCamisa = cuelloCamisa;
            MangaCamisa = mangaCamisa;
        }

        //Devuelve la cotizacion de la camisa
        public decimal CotizarCamisa()
        {
            decimal cotizacion = 0;
            if (MangaCamisa.Equals(EMangaCamisa.corta))
            {
                cotizacion = cotizacion - 10;
            }
            if (CuelloCamisa.Equals(ECuelloCamisa.mao))
            {
                cotizacion = cotizacion + 3;
            }
            return cotizacion;
        }
    }
}
