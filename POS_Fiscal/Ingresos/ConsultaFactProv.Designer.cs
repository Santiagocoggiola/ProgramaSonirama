
namespace Sonirama
{
    partial class ConsultaFactProv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFactProv));
            this.BtnAtras = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CambioPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.LblFact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnAtras.Location = new System.Drawing.Point(12, 864);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(185, 85);
            this.BtnAtras.TabIndex = 1;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Articulo,
            this.Cantidad,
            this.PrecioLista,
            this.PrecioCosto,
            this.Descuento,
            this.Descuento1,
            this.Descuento2,
            this.Pack,
            this.CambioPrecio,
            this.TotalParcial});
            this.dataGridView1.Location = new System.Drawing.Point(14, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 762);
            this.dataGridView1.TabIndex = 68;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioLista
            // 
            this.PrecioLista.HeaderText = "Precio Lista";
            this.PrecioLista.Name = "PrecioLista";
            this.PrecioLista.ReadOnly = true;
            // 
            // PrecioCosto
            // 
            this.PrecioCosto.HeaderText = "Precio Costo";
            this.PrecioCosto.Name = "PrecioCosto";
            this.PrecioCosto.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Descuento1
            // 
            this.Descuento1.HeaderText = "Descuento(1)";
            this.Descuento1.Name = "Descuento1";
            this.Descuento1.ReadOnly = true;
            // 
            // Descuento2
            // 
            this.Descuento2.HeaderText = "Descuento(2)";
            this.Descuento2.Name = "Descuento2";
            this.Descuento2.ReadOnly = true;
            // 
            // Pack
            // 
            this.Pack.HeaderText = "Pack";
            this.Pack.Name = "Pack";
            this.Pack.ReadOnly = true;
            // 
            // CambioPrecio
            // 
            this.CambioPrecio.HeaderText = "Cambio de Precio";
            this.CambioPrecio.Name = "CambioPrecio";
            this.CambioPrecio.ReadOnly = true;
            // 
            // TotalParcial
            // 
            this.TotalParcial.HeaderText = "Total Parcial";
            this.TotalParcial.Name = "TotalParcial";
            this.TotalParcial.ReadOnly = true;
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Location = new System.Drawing.Point(12, 40);
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroFactura.TabIndex = 69;
            // 
            // LblFact
            // 
            this.LblFact.AutoSize = true;
            this.LblFact.Location = new System.Drawing.Point(14, 13);
            this.LblFact.Name = "LblFact";
            this.LblFact.Size = new System.Drawing.Size(83, 13);
            this.LblFact.TabIndex = 70;
            this.LblFact.Text = "Numero Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Proveedor";
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(139, 40);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtProveedor.TabIndex = 71;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnBuscar.Location = new System.Drawing.Point(301, 16);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(92, 44);
            this.BtnBuscar.TabIndex = 73;
            this.BtnBuscar.Text = "Buscar Factura";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(839, 55);
            this.label8.TabIndex = 74;
            this.label8.Text = "CONSULTA FACTURAS COMPRAS";
            // 
            // ConsultaFactProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.LblFact);
            this.Controls.Add(this.TxtNumeroFactura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaFactProv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaFactProv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pack;
        private System.Windows.Forms.DataGridViewTextBoxColumn CambioPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalParcial;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.Label LblFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label8;
    }
}