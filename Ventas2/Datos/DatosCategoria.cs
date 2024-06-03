using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosCategoria : IDatos<Categorias>
    {
        private ventasBDEntities contexto;
        public DatosCategoria()
        {
            contexto = new ventasBDEntities();
        }
        public bool Add(Categorias item)
        {
            throw new NotImplementedException();
        }

        public Categorias FindById(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public List<Categorias> GetAll()
        {
            return contexto.Categorias.ToList();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Categorias item)
        {
            throw new NotImplementedException();
        }
    }
}
