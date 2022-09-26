namespace CotizadorModel
{
    public abstract class Prenda
    {
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public ECalidad Calidad { get; set; }

        public enum ECalidad
        {
            standard,
            premium
        }

        public Prenda(int cantidad, decimal precioUnidad, ECalidad calidad)
        {
            Cantidad = cantidad;
            PrecioUnidad = precioUnidad;
            Calidad = calidad;
        }

        public decimal CotizarPrenda()
        {
            decimal porcentaje = 0;
            //Si la prenda es una camisa
            if (this.GetType().Equals(typeof(Camisa)))
            {
                Camisa camisa = (Camisa)this;
                porcentaje = camisa.CotizarCamisa();
            }
            //Si la prenda es un pantalon
            if (this.GetType().Equals(typeof(Pantalon)))
            {
                Pantalon pantalon = (Pantalon)this;
                porcentaje = pantalon.CotizarPantalon();
            }
            porcentaje = porcentaje + this.CotizarCalidad();//Cotiza la calidad de la prenda

            //Se realiza el calculo acorde al porcentaje de cada cotizacion sumado a la cantidad * precio
            decimal cotizacion = (porcentaje / 100) * (this.Cantidad * this.PrecioUnidad);
            return (this.Cantidad * this.PrecioUnidad) + cotizacion;
        }

        public decimal CotizarCalidad()
        {
            return Calidad.Equals(ECalidad.premium) ? 30 : 0;
        }
    }
}
