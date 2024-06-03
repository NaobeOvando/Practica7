using AccesoDatos;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        CategoriaDatos categoriaDatos;
        public CategoriaNegocio() { 
            categoriaDatos = new CategoriaDatos();
        }
        public List<SP_ClientesCategorias_Result> listadoClientesCategorias()
        {
            return categoriaDatos.SP_ClientesCategorias().ToList();
        }

    }
}
