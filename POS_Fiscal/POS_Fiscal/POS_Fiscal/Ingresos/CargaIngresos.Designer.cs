
namespace POS_Fiscal
{
    partial class CargaIngresos
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDolar = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrecioLista = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblArticulo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPack = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtDescuento1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtDescuento2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CheckPrecio = new System.Windows.Forms.CheckBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LblCantidadElem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.BtnCargarFac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO FACTURA";
            // 
            // TxtNumeroFactura
            // 
            this.TxtNumeroFactura.Location = new System.Drawing.Point(344, 47);
            this.TxtNumeroFactura.Name = "TxtNumeroFactura";
            this.TxtNumeroFactura.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroFactura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESO DE FACTURA PROVEEDOR A INGRESOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(468, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "VALOR DOLAR";
            // 
            // TxtDolar
            // 
            this.TxtDolar.Location = new System.Drawing.Point(635, 47);
            this.TxtDolar.Name = "TxtDolar";
            this.TxtDolar.Size = new System.Drawing.Size(100, 20);
            this.TxtDolar.TabIndex = 4;
            this.TxtDolar.Text = "0";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(852, 47);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(100, 20);
            this.TxtFecha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(763, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "FECHA";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(23, 230);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 8;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(635, 230);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(631, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "CANTIDAD:";
            // 
            // TxtPrecioLista
            // 
            this.TxtPrecioLista.Location = new System.Drawing.Point(789, 230);
            this.TxtPrecioLista.Name = "TxtPrecioLista";
            this.TxtPrecioLista.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioLista.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(785, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "PRECIO FACTURA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(19, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "CODIGO ART:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label8.Location = new System.Drawing.Point(184, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "ARTICULO:";
            // 
            // LblArticulo
            // 
            this.LblArticulo.AutoSize = true;
            this.LblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.LblArticulo.Location = new System.Drawing.Point(184, 226);
            this.LblArticulo.Name = "LblArticulo";
            this.LblArticulo.Size = new System.Drawing.Size(0, 24);
            this.LblArticulo.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(-5, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1149, 88);
            this.label9.TabIndex = 45;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(986, 205);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 45);
            this.BtnCargar.TabIndex = 47;
            this.BtnCargar.Text = "CARGAR LINEA";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(1080, 204);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 46);
            this.BtnBorrar.TabIndex = 48;
            this.BtnBorrar.Text = "BORRAR TEXTO";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrarTexto_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.Location = new System.Drawing.Point(24, 638);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 24);
            this.label13.TabIndex = 54;
            this.label13.Text = "DESCUENTO";
            // 
            // TxtPack
            // 
            this.TxtPack.Location = new System.Drawing.Point(564, 666);
            this.TxtPack.Name = "TxtPack";
            this.TxtPack.Size = new System.Drawing.Size(100, 20);
            this.TxtPack.TabIndex = 51;
            this.TxtPack.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label15.Location = new System.Drawing.Point(560, 638);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 24);
            this.label15.TabIndex = 50;
            this.label15.Text = "PACK:";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(28, 666);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(100, 20);
            this.TxtDescuento.TabIndex = 49;
            this.TxtDescuento.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.Location = new System.Drawing.Point(189, 638);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "DESCUENTO(1)";
            // 
            // TxtDescuento1
            // 
            this.TxtDescuento1.Location = new System.Drawing.Point(193, 666);
            this.TxtDescuento1.Name = "TxtDescuento1";
            this.TxtDescuento1.Size = new System.Drawing.Size(100, 20);
            this.TxtDescuento1.TabIndex = 55;
            this.TxtDescuento1.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.Location = new System.Drawing.Point(396, 638);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 24);
            this.label12.TabIndex = 58;
            this.label12.Text = "DESCUENTO(2)";
            // 
            // TxtDescuento2
            // 
            this.TxtDescuento2.Location = new System.Drawing.Point(400, 666);
            this.TxtDescuento2.Name = "TxtDescuento2";
            this.TxtDescuento2.Size = new System.Drawing.Size(100, 20);
            this.TxtDescuento2.TabIndex = 57;
            this.TxtDescuento2.Text = "0";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(0, 689);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1135, 55);
            this.label14.TabIndex = 59;
            // 
            // CheckPrecio
            // 
            this.CheckPrecio.AutoSize = true;
            this.CheckPrecio.Checked = true;
            this.CheckPrecio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CheckPrecio.Location = new System.Drawing.Point(699, 660);
            this.CheckPrecio.Name = "CheckPrecio";
            this.CheckPrecio.Size = new System.Drawing.Size(188, 28);
            this.CheckPrecio.TabIndex = 60;
            this.CheckPrecio.Text = "CAMBIAR PRECIO";
            this.CheckPrecio.UseVisualStyleBackColor = true;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(906, 646);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(95, 40);
            this.BtnAtras.TabIndex = 61;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(285, 87);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(100, 20);
            this.TxtProveedor.TabIndex = 63;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label16.Location = new System.Drawing.Point(128, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 25);
            this.label16.TabIndex = 62;
            this.label16.Text = "PROVEEDOR:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label17.Location = new System.Drawing.Point(468, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(411, 25);
            this.label17.TabIndex = 64;
            this.label17.Text = "CANTIDAD ELEMENTOS CARGADOS -->";
            // 
            // LblCantidadElem
            // 
            this.LblCantidadElem.AutoSize = true;
            this.LblCantidadElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LblCantidadElem.Location = new System.Drawing.Point(895, 85);
            this.LblCantidadElem.Name = "LblCantidadElem";
            this.LblCantidadElem.Size = new System.Drawing.Size(0, 25);
            this.LblCantidadElem.TabIndex = 65;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1180, 205);
            this.button1.Name = "BtnBorrarLinea";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 66;
            this.button1.Text = "BORRAR LINEA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnBorrarLinea_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1244, 379);
            this.dataGridView1.TabIndex = 67;
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
            // BtnCargarFac
            // 
            this.BtnCargarFac.Location = new System.Drawing.Point(1040, 646);
            this.BtnCargarFac.Name = "BtnCargarFac";
            this.BtnCargarFac.Size = new System.Drawing.Size(95, 40);
            this.BtnCargarFac.TabIndex = 68;
            this.BtnCargarFac.Text = "Cargar Factura";
            this.BtnCargarFac.UseVisualStyleBackColor = true;
            this.BtnCargarFac.Click += new System.EventHandler(this.BtnCargarFac_Click);
            // 
            // CargaIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 744);
            this.Controls.Add(this.BtnCargarFac);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblCantidadElem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.CheckPrecio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtDescuento2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtDescuento1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtPack);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblArticulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPrecioLista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumeroFactura);
            this.Controls.Add(this.label1);
            this.Name = "CargaIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargaIngresos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumeroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDolar;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrecioLista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblArticulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtPack;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtDescuento1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtDescuento2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CheckPrecio;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LblCantidadElem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCargarFac;
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
    }
}