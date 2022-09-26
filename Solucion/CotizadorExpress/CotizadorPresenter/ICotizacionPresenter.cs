namespace CotizadorPresenter
{
    public interface ICotizacionPresenter
    {
        public string GetDatosVendedor();
        public string GetNombreTienda();
        public string GetDireccionTienda();
        public int GetStockCamisas();
        public int GetStockPantalones();
        public decimal CotizarCamisa(int cantidad, decimal precio, string cuello, string manga, string calidad);
        public decimal CotizarPantalon(int cantidad, decimal precio, string tipoPantalon, string calidad);
        public List<string> GetHistorialCotizaciones();
    }
}
