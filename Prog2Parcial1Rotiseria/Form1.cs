﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Parcial1Rotiseria
{
    public partial class Form1 : Form
    {
        Rotiseria roti = new Rotiseria();
        Pedido tipoDePedido;
        int totalpedidos = 0;
        public Form1()
        {
            InitializeComponent();
            ItemMenu it1 = new ItemMenu("Pizza Napolitana Especial", 1200);
            ItemMenu it2 = new ItemMenu("Gaseosa de Litro", 850);
            cb1.Items.Add(it1);
            cb1.Items.Add(it2);
        }

        private void bttTomarPedido_Click(object sender, EventArgs e)
        {
            
            TomarPedido tp = new TomarPedido();
           if (tp.ShowDialog() == DialogResult.OK) 
            {

                totalpedidos++;
                string nombre  = tp.txbCliente.Text;
                if (tp.cbDelivery.Checked)
                {
                    
                    double km = Convert.ToDouble(tp.txbkm.Text);
                    tipoDePedido = new Delivery(km, totalpedidos, nombre);
                    roti.AgregarPedido(tipoDePedido);
                    

                }
                else
                {
                    tipoDePedido = new Pedido(nombre, totalpedidos);
                    roti.AgregarPedido(tipoDePedido);
                    
                }
            }
            tp.Dispose();
        }

        private void bttAgregarMenu_Click(object sender, EventArgs e)
        {
            ItemMenu rq = cb1.SelectedItem as ItemMenu;
            int cantidad = Convert.ToInt32(txbCantidad.Text);
            tipoDePedido.AgregarItem(rq, cantidad);
            lBpedido.Items.Add(rq);
        }

        private void bttCerrar_Click(object sender, EventArgs e)
        {
            Pedido pedilo = roti.VerPedido(totalpedidos);

            MessageBox.Show("Precio Final: " + pedilo.Precio());
            lBpedido.Items.Clear();
            roti.Ordenar();
            foreach (Pedido item in roti.ObtenerLista())
            {
                lBlistapedidos.Items.Add(item);
            }
        }
    }
}
