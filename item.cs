using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public class item:ItemBase

    {


        public item(Articulo artic, int Cantidad) : base(artic, Cantidad)
        {

        }
        
        

        public override void imprimir()
        {
            Console.WriteLine($"{Id} {Nombre}  precio: ${Precio} catidad: {Cantidad}, subtotal {Subtotal()}\n Total: ${Total()}  ");
        }
    }

       
         
 }

