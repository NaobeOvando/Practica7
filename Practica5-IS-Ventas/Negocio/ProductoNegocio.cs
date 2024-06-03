using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegocio
    {
        ProductoDatos productos;
        public ProductoNegocio() { 
            productos = new ProductoDatos();
        }
        public List<Producto> All()
        {
            return productos.Listar();
        }
        public Producto ById(int id)
        {
            return productos.Listar().Where(p=>p.idProducto==id).SingleOrDefault();
        }
        public bool insertarProducto(Producto productoNuevo)
        {
            return productos.Nuevo(productoNuevo);
        }
    }
}
