using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1Rotiseria
{
    internal class Pedido : IComparable<Pedido>
    {
        string cliente;
        public readonly int Numero;

        protected double precio;

        List<ItemMenu> items = new List<ItemMenu>();
        public Pedido(string cliente,int numero)
        {
            this.cliente = cliente;
            this.Numero = numero;
        }
   
        public double Precio()
        {
            foreach (ItemMenu item in items)
            {
                precio += item.precio;
                
            }
            if (precio > 2000)
            {
                double descuento = precio * .05;
                precio -= descuento;
            }
            return precio;
        }
        public void AgregarItem(ItemMenu menu, int cantidad)
        {
            if (menu != null) 
            {
               double menucito = menu.precio * cantidad;
                menu.precio=menucito;

                items.Add(menu);
            }
            
        }
        public override string ToString()
        {
            return cliente+"  numero de pedido: "+Numero;
        }

        public int CompareTo(Pedido other)
        {
            return this.precio.CompareTo(other.precio);
        }
    }
}
