using CotizadorModel;
using CotizadorPresenter;
using static CotizadorModel.Camisa;
using static CotizadorModel.Pantalon;
using static CotizadorModel.Prenda;

namespace CotizadorPresenters
{
    public class CotizacionPresenter : ICotizacionPresenter
    {
        private static Tienda tienda = new Tienda("Tienda Curso", "Avenida Gamer 123");
        private static Vendedor vendedor = new Vendedor("Santiago", "Amaro", "COD001", tienda);
        static int stockCamisas = 1000;
        static int stockPantalones = 2000;

        public CotizacionPresenter()
        {

        }

        //Retorna los datos del vendedor en un string concatenado
        public string GetDatosVendedor()
        {
            return $"{vendedor.Nombre} {vendedor.Apellido} {vendedor.CodVendedor}";
        }

        //Retorna el nombre de la tienda
        public string GetNombreTienda()
        {
            return tienda.Nombre;
        }

        //Retorna la direccion de la tienda
        public string GetDireccionTienda()
        {
            return tienda.Direccion;
        }

        public int GetStockCamisas()
        {
            return stockCamisas;
        }

        public int GetStockPantalones()
        {
            return stockPantalones;
        }

        //Funcion que genera una nueva contizacion de camisa
        public decimal CotizarCamisa(int cantidad, decimal precio, string cuello, string manga, string calidad)
        {
            //Obtiene los enums dadas las selecciones del usuario
            ECuelloCamisa eCuelloCamisa = cuello == "mao" ? ECuelloCamisa.mao : ECuelloCamisa.comun;
            EMangaCamisa eMangaCamisa = manga == "corta" ? EMangaCamisa.corta : EMangaCamisa.larga;
            ECalidad eCalidadCamisa = calidad == "premium" ? ECalidad.premium : ECalidad.standard;

            Camisa nuevaCamisa = new Camisa(cantidad, precio, eCalidadCamisa, eCuelloCamisa, eMangaCamisa);
            return NuevaCotizacion(nuevaCamisa).CalculoTotal;
        }

        //Funcion que genera una nueva cotizacion de pantalon
        public decimal CotizarPantalon(int cantidad, decimal precio, string tipoPantalon, string calidad)
        {
            //Obtiene los enums dadas las selecciones del usuario
            ETipoPantalon eTipoPantalon = tipoPantalon == "comun" ? ETipoPantalon.comun : ETipoPantalon.chupin;
            ECalidad eCalidadPantalon = calidad == "premium" ? ECalidad.premium : ECalidad.standard;

            Pantalon nuevoPantalon = new Pantalon(cantidad, precio, eCalidadPantalon, eTipoPantalon);
            return NuevaCotizacion(nuevoPantalon).CalculoTotal;
        }

        //Funcion que agrega la cotizacion a la lista de cotizaciones del vendedor
        private Cotizacion NuevaCotizacion(Prenda prenda)
        {
            Cotizacion nuevaCotizacion = new Cotizacion(DateTime.Now, vendedor.CodVendedor, prenda);
            vendedor.Cotizaciones.Add(nuevaCotizacion);
            return nuevaCotizacion;
        }

        //Funcion que retorna una lista de strings que contienen la informacion de cada cotizacion
        public List<string> GetHistorialCotizaciones()
        {
            List<string> list = new List<string>();
            foreach(Cotizacion cot in vendedor.Cotizaciones)
            {
                string informacion = $"Id: {cot.Id} Fecha: {cot.Fecha} Unidades: {cot.Unidades} Precio: ${cot.Prenda.PrecioUnidad} Total: ${cot.CalculoTotal}";
                if (cot.Prenda.GetType().Equals(typeof(Camisa)))
                {
                    Camisa camisa = (Camisa)cot.Prenda;
                    
                }
                if (cot.Prenda.GetType().Equals(typeof(Pantalon)))
                {
                    Pantalon pant = (Pantalon)cot.Prenda;
                    informacion.Concat($" {pant.Calidad}");
                }
                list.Add(informacion);
            }
            return list;
        }
    }
}
