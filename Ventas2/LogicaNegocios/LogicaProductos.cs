using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocios
{
    public class LogicaProductos
    {
        DatosProducto productosDatos;
        public LogicaProductos() { 
            productosDatos = new DatosProducto();
        }
        public List<Productos> ListarProductos()
        {
            return productosDatos.GetAll();
        }
    }
}
