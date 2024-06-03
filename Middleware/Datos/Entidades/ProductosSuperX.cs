using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class ProductosSuperX
    {
        public int id {  get; set; }
        public string name { get; set; }
        public double pvp { get; set; }
        public bool impuesto { get; set; }
        public bool estado { get; set; }
        public string marca { get; set; }
        public ProductosSuperX()
        {

        }
        public ProductosSuperX(string datoJson)
        {
            JObject dato = JObject.Parse(datoJson);
            id =(int) dato["id"];
            name =(string)dato["name"];
            pvp = (double) dato["pvp"];
            impuesto = (bool) dato["impuesto"];
            estado = (bool)dato["estado"];
            marca = (string)dato["marca"];
        }
    }
}
