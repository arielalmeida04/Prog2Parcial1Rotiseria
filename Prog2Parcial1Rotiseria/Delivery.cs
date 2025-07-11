using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Parcial1Rotiseria
{
    internal class Delivery:Pedido
    {
        double distancia = 0;
        public Delivery(double distancia,int numero, string cliente):base(cliente,numero) 
        {
            this.distancia = distancia;
        }
        public double Precio()
        {
            return precio+(precio*distancia*0.08)+150;
        }
    
    }
}
