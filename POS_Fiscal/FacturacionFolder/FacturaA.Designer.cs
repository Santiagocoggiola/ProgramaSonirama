
namespace Sonirama
{
    partial class FacturaA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaA));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.botonAñadirA = new System.Windows.Forms.Button();
            this.labelTotalNumA = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.botonImprimirA = new System.Windows.Forms.Button();
            this.botonSalirA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonCliente = new System.Windows.Forms.Button();
            this.button_reconectar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBoxDoc = new System.Windows.Forms.ComboBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusquedaNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscarNombre = new System.Windows.Forms.Button();
            this.BtnBuscarCuit = new System.Windows.Forms.Button();
            this.txtBusquedaCuit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 597);
            this.panel1.TabIndex = 15;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.BtnGenerar.Location = new System.Drawing.Point(1132, 198);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(119, 31);
            this.BtnGenerar.TabIndex = 26;
            this.BtnGenerar.Tag = "";
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // botonAñadirA
            // 
            this.botonAñadirA.BackColor = System.Drawing.Color.PowderBlue;
            this.botonAñadirA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonAñadirA.Location = new System.Drawing.Point(1132, 87);
            this.botonAñadirA.Name = "botonAñadirA";
            this.botonAñadirA.Size = new System.Drawing.Size(119, 31);
            this.botonAñadirA.TabIndex = 25;
            this.botonAñadirA.Text = "Añadir";
            this.botonAñadirA.UseVisualStyleBackColor = false;
            this.botonAñadirA.Click += new System.EventHandler(this.BotonAñadirA_Click_1);
            // 
            // labelTotalNumA
            // 
            this.labelTotalNumA.AutoSize = true;
            this.labelTotalNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelTotalNumA.Location = new System.Drawing.Point(533, 700);
            this.labelTotalNumA.Name = "labelTotalNumA";
            this.labelTotalNumA.Size = new System.Drawing.Size(18, 20);
            this.labelTotalNumA.TabIndex = 24;
            this.labelTotalNumA.Text = "0";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelTotal.Location = new System.Drawing.Point(444, 690);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(83, 31);
            this.labelTotal.TabIndex = 22;
            this.labelTotal.Text = "Total:";
            // 
            // botonImprimirA
            // 
            this.botonImprimirA.BackColor = System.Drawing.Color.PowderBlue;
            this.botonImprimirA.Enabled = false;
            this.botonImprimirA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonImprimirA.Location = new System.Drawing.Point(746, 891);
            this.botonImprimirA.Name = "botonImprimirA";
            this.botonImprimirA.Size = new System.Drawing.Size(129, 54);
            this.botonImprimirA.TabIndex = 18;
            this.botonImprimirA.Text = "Imprimir";
            this.botonImprimirA.UseVisualStyleBackColor = false;
            this.botonImprimirA.Click += new System.EventHandler(this.BotonImprimirA_Click);
            // 
            // botonSalirA
            // 
            this.botonSalirA.BackColor = System.Drawing.Color.Salmon;
            this.botonSalirA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalirA.Location = new System.Drawing.Point(12, 857);
            this.botonSalirA.Name = "botonSalirA";
            this.botonSalirA.Size = new System.Drawing.Size(277, 92);
            this.botonSalirA.TabIndex = 17;
            this.botonSalirA.Text = "Salir";
            this.botonSalirA.UseVisualStyleBackColor = false;
            this.botonSalirA.Click += new System.EventHandler(this.BotonSalirA_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(745, 813);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Razon Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(821, 808);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(337, 20);
            this.txtRazonSocial.TabIndex = 28;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(821, 836);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(337, 20);
            this.txtCuit.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 839);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "CUIT";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(821, 864);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(337, 20);
            this.txtDireccion.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 867);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Dirección";
            // 
            // botonCliente
            // 
            this.botonCliente.BackColor = System.Drawing.Color.PowderBlue;
            this.botonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonCliente.Location = new System.Drawing.Point(997, 752);
            this.botonCliente.Name = "botonCliente";
            this.botonCliente.Size = new System.Drawing.Size(161, 31);
            this.botonCliente.TabIndex = 37;
            this.botonCliente.Tag = "";
            this.botonCliente.Text = "Guardar Cliente";
            this.botonCliente.UseVisualStyleBackColor = false;
            this.botonCliente.Click += new System.EventHandler(this.BotonCliente_Click);
            // 
            // button_reconectar
            // 
            this.button_reconectar.BackColor = System.Drawing.Color.PowderBlue;
            this.button_reconectar.Location = new System.Drawing.Point(1117, 926);
            this.button_reconectar.Name = "button_reconectar";
            this.button_reconectar.Size = new System.Drawing.Size(130, 23);
            this.button_reconectar.TabIndex = 40;
            this.button_reconectar.Text = "Reconectar Impresora";
            this.button_reconectar.UseVisualStyleBackColor = false;
            this.button_reconectar.Click += new System.EventHandler(this.Button_reconectar_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 951);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1264, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 41;
            // 
            // comboBoxDoc
            // 
            this.comboBoxDoc.FormattingEnabled = true;
            this.comboBoxDoc.Items.AddRange(new object[] {
            "CUIT"});
            this.comboBoxDoc.Location = new System.Drawing.Point(821, 785);
            this.comboBoxDoc.Name = "comboBoxDoc";
            this.comboBoxDoc.Size = new System.Drawing.Size(147, 21);
            this.comboBoxDoc.TabIndex = 59;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "IVA Responsable Inscripto",
            "Responsable Monotributo"});
            this.comboBoxTipo.Location = new System.Drawing.Point(821, 758);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(147, 21);
            this.comboBoxTipo.TabIndex = 58;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(456, 794);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 101);
            this.panel2.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 741);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tipo de Pago";
            // 
            // comboBoxPago
            // 
            this.comboBoxPago.FormattingEnabled = true;
            this.comboBoxPago.Items.AddRange(new object[] {
            "Credito",
            "Efectivo"});
            this.comboBoxPago.Location = new System.Drawing.Point(456, 767);
            this.comboBoxPago.Name = "comboBoxPago";
            this.comboBoxPago.Size = new System.Drawing.Size(147, 21);
            this.comboBoxPago.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(740, 714);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 64;
            this.label4.Text = "Busqueda por Nombre";
            // 
            // txtBusquedaNombre
            // 
            this.txtBusquedaNombre.Location = new System.Drawing.Point(950, 717);
            this.txtBusquedaNombre.Name = "txtBusquedaNombre";
            this.txtBusquedaNombre.Size = new System.Drawing.Size(153, 20);
            this.txtBusquedaNombre.TabIndex = 65;
            // 
            // BtnBuscarNombre
            // 
            this.BtnBuscarNombre.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnBuscarNombre.Location = new System.Drawing.Point(1109, 717);
            this.BtnBuscarNombre.Name = "BtnBuscarNombre";
            this.BtnBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarNombre.TabIndex = 66;
            this.BtnBuscarNombre.Text = "Buscar";
            this.BtnBuscarNombre.UseVisualStyleBackColor = false;
            this.BtnBuscarNombre.Click += new System.EventHandler(this.BtnBuscarNombre_Click);
            // 
            // BtnBuscarCuit
            // 
            this.BtnBuscarCuit.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnBuscarCuit.Location = new System.Drawing.Point(1109, 693);
            this.BtnBuscarCuit.Name = "BtnBuscarCuit";
            this.BtnBuscarCuit.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarCuit.TabIndex = 69;
            this.BtnBuscarCuit.Text = "Buscar";
            this.BtnBuscarCuit.UseVisualStyleBackColor = false;
            this.BtnBuscarCuit.Click += new System.EventHandler(this.BtnBuscarCuit_Click);
            // 
            // txtBusquedaCuit
            // 
            this.txtBusquedaCuit.Location = new System.Drawing.Point(950, 693);
            this.txtBusquedaCuit.Name = "txtBusquedaCuit";
            this.txtBusquedaCuit.Size = new System.Drawing.Size(153, 20);
            this.txtBusquedaCuit.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(740, 690);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 67;
            this.label7.Text = "Busqueda por CUIT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 37);
            this.label8.TabIndex = 70;
            this.label8.Text = "Menu Facturacion A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(75, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "Digito";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(742, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Total";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCantidad.Location = new System.Drawing.Point(528, 55);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(75, 20);
            this.labelCantidad.TabIndex = 76;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelMonto.Location = new System.Drawing.Point(649, 55);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(67, 20);
            this.labelMonto.TabIndex = 75;
            this.labelMonto.Text = "Unitario";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNombre.Location = new System.Drawing.Point(134, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(140, 20);
            this.labelNombre.TabIndex = 74;
            this.labelNombre.Text = "Nombre Producto";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCodigo.Location = new System.Drawing.Point(8, 55);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(61, 20);
            this.labelCodigo.TabIndex = 73;
            this.labelCodigo.Text = "Codigo";
            // 
            // FacturaA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.BtnBuscarCuit);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.txtBusquedaCuit);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnBuscarNombre);
            this.Controls.Add(this.txtBusquedaNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPago);
            this.Controls.Add(this.comboBoxDoc);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_reconectar);
            this.Controls.Add(this.botonCliente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.botonAñadirA);
            this.Controls.Add(this.botonSalirA);
            this.Controls.Add(this.labelTotalNumA);
            this.Controls.Add(this.botonImprimirA);
            this.Controls.Add(this.labelTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturaA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Button botonAñadirA;
        private System.Windows.Forms.Label labelTotalNumA;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button botonImprimirA;
        private System.Windows.Forms.Button botonSalirA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonCliente;
        private System.Windows.Forms.Button button_reconectar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBoxDoc;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusquedaNombre;
        private System.Windows.Forms.Button BtnBuscarNombre;
        private System.Windows.Forms.Button BtnBuscarCuit;
        private System.Windows.Forms.TextBox txtBusquedaCuit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
    }
}