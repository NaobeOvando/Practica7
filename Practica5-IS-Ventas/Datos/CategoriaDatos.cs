using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDatos : IDatos<Categoria>
    {
        serviciosEntities contexto;
        public CategoriaDatos()
        {
            contexto = new serviciosEntities();
        }
        public bool Actualizar(Categoria item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Categoria item)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> Listar()
        {
            return contexto.Categoria.ToList();
        }

        public bool Nuevo(Categoria item)
        {
            contexto.Categoria.Add(item);
            contexto.SaveChanges();
            return true;
        }

        public ObjectResult <SP_ClientesCategorias_Result> SP_ClientesCategorias()
        {
            return contexto.SP_ClientesCategorias();
        }

    }
}
