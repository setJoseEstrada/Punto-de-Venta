using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    public class ItemTA:ItemBase

    {
        public string Numero { get; set; }
        public string Compania { get; set; }
        public int Comicion { get; set; }   
        public ItemTA(Articulo articulo, int cantidad) : base(articulo,cantidad)
        {

        }

        public override decimal Total() => Subtotal()+Comicion;
       

        public override void imprimir()
        {
            Console.WriteLine($"{Id} Tiempo Aire precio: {Precio} cantidad: {Cantidad} SubTotal: {Subtotal()}\n" +
                $"Teelefono: {Numero} compañia: {Compania} Comision: {Comicion}\n" +
                $"Total: {Total()}");
        }
    }
}
