using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SOAP_Ventas
{
    /// <summary>
    /// Descripción breve de WebServiceVentas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceVentas : System.Web.Services.WebService
    {
        private ProductoNegocio producto = new ProductoNegocio();

        [WebMethod]
        public List<Producto> ListarProductos()
        {
            return producto.All();
        }
        [WebMethod]
        public Producto BuscarXId(int id)
        {
            Producto temp = new Producto();
            temp=producto.ById(id);
            if (temp!= null)
            {
                return temp;
            }
            return null;
                
        }
    }
}
