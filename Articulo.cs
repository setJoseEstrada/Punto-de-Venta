using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace PuntoDeVenta
{
    public class Articulo
    {

        public int Id {get;set;}
        public string Nombre {get;set;}
        public decimal Precio { get;set;}
        public TipoArticulo Tipo { get;set;}





    }
}
