using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1Rotiseria
{
    internal class ItemMenu
    {
        string descripcion;
        public double precio { get; set; }

        public ItemMenu(string descripcion, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
        }
        public override string ToString()
        {
             return descripcion+" "+precio;
        }
    }
}
