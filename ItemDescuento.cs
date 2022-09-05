using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public class ItemDescuento : ItemBase
    {
      public decimal Descuento { get; set; }  
      public decimal ImpDescuento {
            get { return Subtotal() *Descuento; }
                
                
                
                } 
        public ItemDescuento(Articulo articulo, int cantidad): base(articulo, cantidad)
        {
        }

        public override decimal Total()=>Subtotal()-Descuento ;
        
       
        public override void imprimir() {

            Console.WriteLine($"{Id} {Nombre} {Precio} Cantidad: {Cantidad} Subtotal: {Subtotal()}\n" +
                $" Descuento:{Descuento} ({Descuento * 100 / Subtotal()}%)" +
                $"\nTotal= {Total()}");
        }
    }

    
}
 