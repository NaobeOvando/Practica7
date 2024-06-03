using Datos.DTO;
using Datos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MiddlewareProductos
    {
        servicioTienda.WebServiceVentas webTiendaMil = new servicioTienda.WebServiceVentas();

        public List<servicioTienda.Producto> ListaTiendaMil()
        {
            return webTiendaMil.ListarProductos().ToList();
        }

        public List<DTOProducto> ListaProductosSOAP()
        {
            List<DTOProducto> lista = new List<DTOProducto>();
            foreach (var item in ListaTiendaMil())
            {
                DTOProducto datoProducto = new DTOProducto();
                datoProducto.Id = item.idProducto;
                datoProducto.Name = item.nombre;
                datoProducto.Price = (double) item.precio_unitario;
                if(item.iva == 1)
                    datoProducto.Iva = true;
                else datoProducto.Iva = false;
                lista.Add(datoProducto);
            }

            return lista;
        }
        public List<ProductosSuperX> listarProductosSuperX()
        {
            string url = "http://localhost:50070/api/Productos";
            WebClient respuesta = new WebClient();
            string get = respuesta.DownloadString(new Uri(url));
            List<ProductosSuperX> listaSuperX = JsonConvert.DeserializeObject<List<ProductosSuperX>>(get);
            return listaSuperX;
        }

    }
}
