using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiREST.Controllers
{
    public class CategoriasController : ApiController
    {
        CategoriaNegocio c = new CategoriaNegocio();
        // GET: Categorias
        public IHttpActionResult Get()
        {
            var respuesta = c.listadoClientesCategorias();
            return Ok(respuesta);
        }
    }
}