using AccesoDatos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace ApiREST.Controllers
{
    [EnableCors(origins: "http://localhost:49997", headers:"*", methods:"*")]
    public class ProductosController : ApiController
    {
        ProductoNegocio productoNegocio = new ProductoNegocio();
        
        //Get  - listar todos
        public IHttpActionResult Get()
        {
            var respuesta= productoNegocio.All();
            return Ok(respuesta);
        }

        //Get/id - mostrar producto por id
        public IHttpActionResult Get(int id)
        {
            Producto producto = productoNegocio.ById(id);
            if(producto != null) { 
                return Ok(producto);
            }
            return NotFound();
        }
        // Post - insertar un nuevo Producto
        public IHttpActionResult Post(Producto producto)
        {
            productoNegocio.insertarProducto(producto);
            return Ok("Insertado correctamente");
        }

        // Put  -- actualizar un producto


        // Delete -- eliminar un producto

    }
}