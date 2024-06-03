using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosProducto : IDatos<Productos>
    {
        private ventasBDEntities contexto;
        public DatosProducto()
        {
            contexto = new ventasBDEntities();
        }
        public bool Add(Productos item)
        {
            contexto.Productos.Add(item);
            contexto.SaveChanges();
            return true;
        }

        public Productos FindById(int id)
        {
            return contexto.Productos.Find(id);
        }

        public List<Productos> GetAll()
        {
            return contexto.Productos.ToList();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Productos item)
        {
            throw new NotImplementedException();
        }
    }
}
