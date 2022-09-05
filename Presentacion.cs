using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace PuntoDeVenta
{
    internal class Presentacion
    {
        private static List<Articulo> _ListaArticulos;
      

        public static void CargarTabla()
            {
            StreamReader r = new StreamReader(@"C:\Users\toro0\Downloads\Articulos.json");
            string json = r.ReadToEnd();
            r.Close();
            _ListaArticulos = JsonConvert.DeserializeObject<List<Articulo>>(json);
            }

        public static void Usuario()
        {
            
            string option = "";

            do
            {
                Articulo art = new Articulo();
                Console.WriteLine("Digite el id");
                art.Id = int.Parse(Console.ReadLine());
                Console.Write("Cantidad\n");
                int cantidad = int.Parse(Console.ReadLine());
                 art = _ListaArticulos.Find(x => x.Id== art.Id);
              
                switch (art.Tipo)
                {
                    case TipoArticulo.Normal:
                        
                        Normal(art, cantidad);
                        
                        break;
                    case TipoArticulo.Descuento:
                        Console.WriteLine("digita el descuento");
                        decimal desc = decimal.Parse(Console.ReadLine());   
                        Descuento(art,cantidad,desc);
                        break;
                    case TipoArticulo.TiwmpoAire:
                        Console.WriteLine("Ingrese su numero de telefono");
                        string tiwmpoAire = Console.ReadLine();
                        Console.WriteLine("Ingrese su compania");
                        string compania=Console.ReadLine();
                        Console.WriteLine("Ingrese la comicion");
                        int comicion = int.Parse(Console.ReadLine());
                        Telefono(art,cantidad,tiwmpoAire,compania,comicion);
                        break;
                }
                Console.WriteLine("Quieres ingresar otra venta\n.-si\n.-no");
                option = Console.ReadLine();


            } while (option != "no");
            
         
   

        }
        public static void Normal(Articulo articulo, int cantidad)
        {
            item item = new item(articulo,cantidad);
            item.imprimir();
        }
        public static void Descuento(Articulo articulo, int cantidad, decimal descuento)
        {
            ItemDescuento item = new ItemDescuento(articulo,cantidad);
            item.Descuento = descuento;
            item.imprimir();

        }
        public static void Telefono(Articulo articulo, int cantidad, string telefono, string compania, int comision)
        {
            ItemTA item = new ItemTA(articulo,cantidad);
            item.Numero = telefono;
            item.Compania = compania;
            item.Comicion = comision;
            item.imprimir();
        }
    }
}
