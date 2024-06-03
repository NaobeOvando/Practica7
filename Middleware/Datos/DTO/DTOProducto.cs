using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DTO
{
    public class DTOProducto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Iva {  get; set; }
        public string Tienda { get; set; }
        public DTOProducto() { }
    }
}
