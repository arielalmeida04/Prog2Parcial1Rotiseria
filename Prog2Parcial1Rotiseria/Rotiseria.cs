using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Parcial1Rotiseria
{
    internal class Rotiseria
    {
        List<Pedido> pepe = new List<Pedido>();
        public double totalRecudado {  get; set; }
        public int TotalPedidos { get; set; }
        public void AgregarPedido(Pedido p)
        {
            if (p != null) 
            {
                pepe.Add(p);
                totalRecudado += p.Precio();
                TotalPedidos++;
            }
            
            
        }
        public void Ordenar()
        {
            pepe.Sort();
        }
        public List<Pedido> ObtenerLista()
        {
            return pepe;
        }

     

        public Pedido VerPedido(int i)
        {
            foreach (Pedido item in pepe)
            {
                if (item.Numero==i)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
