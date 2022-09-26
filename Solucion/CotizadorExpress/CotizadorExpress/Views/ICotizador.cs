namespace CotizadorExpress.Views
{
    public interface ICotizador
    {
        public void MostrarDatos();
        public bool DatosValidos();
        public void ActualizarHistorial();
        public void MostrarError(string msg);
    }
}
