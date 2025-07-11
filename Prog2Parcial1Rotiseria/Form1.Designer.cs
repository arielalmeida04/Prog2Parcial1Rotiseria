namespace Prog2Parcial1Rotiseria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttTomarPedido = new System.Windows.Forms.Button();
            this.bttAgregarMenu = new System.Windows.Forms.Button();
            this.bttCerrar = new System.Windows.Forms.Button();
            this.lBpedido = new System.Windows.Forms.ListBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.lBlistapedidos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttTomarPedido
            // 
            this.bttTomarPedido.Location = new System.Drawing.Point(12, 12);
            this.bttTomarPedido.Name = "bttTomarPedido";
            this.bttTomarPedido.Size = new System.Drawing.Size(218, 23);
            this.bttTomarPedido.TabIndex = 0;
            this.bttTomarPedido.Text = "Tomar Pedido";
            this.bttTomarPedido.UseVisualStyleBackColor = true;
            this.bttTomarPedido.Click += new System.EventHandler(this.bttTomarPedido_Click);
            // 
            // bttAgregarMenu
            // 
            this.bttAgregarMenu.Location = new System.Drawing.Point(185, 51);
            this.bttAgregarMenu.Name = "bttAgregarMenu";
            this.bttAgregarMenu.Size = new System.Drawing.Size(68, 50);
            this.bttAgregarMenu.TabIndex = 1;
            this.bttAgregarMenu.Text = "Agregar Menu";
            this.bttAgregarMenu.UseVisualStyleBackColor = true;
            this.bttAgregarMenu.Click += new System.EventHandler(this.bttAgregarMenu_Click);
            // 
            // bttCerrar
            // 
            this.bttCerrar.Location = new System.Drawing.Point(12, 215);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(218, 23);
            this.bttCerrar.TabIndex = 2;
            this.bttCerrar.Text = "Cerrar pedido";
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.bttCerrar_Click);
            // 
            // lBpedido
            // 
            this.lBpedido.FormattingEnabled = true;
            this.lBpedido.Location = new System.Drawing.Point(12, 114);
            this.lBpedido.Name = "lBpedido";
            this.lBpedido.Size = new System.Drawing.Size(218, 95);
            this.lBpedido.TabIndex = 3;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(64, 88);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(115, 20);
            this.txbCantidad.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(12, 41);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(167, 21);
            this.cb1.TabIndex = 6;
            // 
            // lBlistapedidos
            // 
            this.lBlistapedidos.FormattingEnabled = true;
            this.lBlistapedidos.Location = new System.Drawing.Point(12, 258);
            this.lBlistapedidos.Name = "lBlistapedidos";
            this.lBlistapedidos.Size = new System.Drawing.Size(218, 95);
            this.lBlistapedidos.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 361);
            this.Controls.Add(this.lBlistapedidos);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.lBpedido);
            this.Controls.Add(this.bttCerrar);
            this.Controls.Add(this.bttAgregarMenu);
            this.Controls.Add(this.bttTomarPedido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttTomarPedido;
        private System.Windows.Forms.Button bttAgregarMenu;
        private System.Windows.Forms.Button bttCerrar;
        private System.Windows.Forms.ListBox lBpedido;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ListBox lBlistapedidos;
    }
}

