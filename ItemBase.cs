using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public abstract class ItemBase
    {
        private decimal _Precio;
        

        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        
        public int Cantidad { get; set; }




        public ItemBase() { }


        public ItemBase(Articulo propiedades, int  Cantidad)
        {
            this.Id = propiedades.Id;
            this.Nombre = propiedades.Nombre;
            Precio = propiedades.Precio;
           
            
            this.Cantidad = Cantidad;
        }

        public virtual decimal Subtotal() => Precio * Cantidad;


        public virtual decimal Total() => Precio * Cantidad;
     

        public abstract void imprimir();
    }
}
