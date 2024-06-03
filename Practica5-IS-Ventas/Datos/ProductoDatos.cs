using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos : IDatos<Producto>
    {
        serviciosEntities contexto;

        public ProductoDatos()
        {
            contexto = new serviciosEntities();
        }
       public bool Nuevo(Producto producto)
        {
            if (contexto.Producto.Add(producto) != null)
            {
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
        public ObjectResult listarClientesCategoria() {
            return contexto.SP_Clientes();
        }
      
        public List<Producto> Listar()
        {
            return contexto.Producto.ToList();
        }

        public Producto BuscarId(int id)
        {
            return contexto.Producto.Where(p=>p.idProducto== id).FirstOrDefault(); 
        }
        public bool Actualizar(Producto item)
        {
            Producto temp = BuscarId(item.idProducto);
            //temp.idProducto = item.idProducto;
            temp.iva = item.iva;
            temp.precio_unitario = item.precio_unitario;
            temp.nombre = item.nombre;
            contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Producto item)
        {
            Producto temp = BuscarId(item.idProducto);
            if ( temp != null)
            {
                contexto.Producto.Remove(temp);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
