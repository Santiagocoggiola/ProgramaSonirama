﻿
namespace POS_Fiscal
{
    partial class FacturaB
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
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelTotalNum = new System.Windows.Forms.Label();
            this.botonAñadir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_reconectar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.botonCliente = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // botonSalir
            // 
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonSalir.Location = new System.Drawing.Point(845, 540);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(129, 54);
            this.botonSalir.TabIndex = 0;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonImprimir
            // 
            this.botonImprimir.Enabled = false;
            this.botonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonImprimir.Location = new System.Drawing.Point(0, 536);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(129, 54);
            this.botonImprimir.TabIndex = 1;
            this.botonImprimir.Text = "Imprimir";
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCodigo.Location = new System.Drawing.Point(12, 9);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(61, 20);
            this.labelCodigo.TabIndex = 2;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelNombre.Location = new System.Drawing.Point(96, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(140, 20);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre Producto";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelMonto.Location = new System.Drawing.Point(525, 9);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(67, 20);
            this.labelMonto.TabIndex = 4;
            this.labelMonto.Text = "Unitario";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelTotal.Location = new System.Drawing.Point(538, 377);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(83, 31);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelCantidad.Location = new System.Drawing.Point(400, 9);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(75, 20);
            this.labelCantidad.TabIndex = 6;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelTotalNum
            // 
            this.labelTotalNum.AutoSize = true;
            this.labelTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.labelTotalNum.Location = new System.Drawing.Point(637, 383);
            this.labelTotalNum.Name = "labelTotalNum";
            this.labelTotalNum.Size = new System.Drawing.Size(60, 25);
            this.labelTotalNum.TabIndex = 11;
            this.labelTotalNum.Text = "Total";
            // 
            // botonAñadir
            // 
            this.botonAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonAñadir.Location = new System.Drawing.Point(855, 45);
            this.botonAñadir.Name = "botonAñadir";
            this.botonAñadir.Size = new System.Drawing.Size(119, 31);
            this.botonAñadir.TabIndex = 12;
            this.botonAñadir.Text = "Añadir";
            this.botonAñadir.UseVisualStyleBackColor = true;
            this.botonAñadir.Click += new System.EventHandler(this.botonAñadir_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 342);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(855, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 15;
            this.button1.Tag = "";
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(626, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total";
            // 
            // button_reconectar
            // 
            this.button_reconectar.Location = new System.Drawing.Point(383, 571);
            this.button_reconectar.Name = "button_reconectar";
            this.button_reconectar.Size = new System.Drawing.Size(130, 23);
            this.button_reconectar.TabIndex = 42;
            this.button_reconectar.Text = "Reconectar Impresora";
            this.button_reconectar.UseVisualStyleBackColor = true;
            this.button_reconectar.Click += new System.EventHandler(this.button_reconectar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 596);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(986, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 43;
            // 
            // botonCliente
            // 
            this.botonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.botonCliente.Location = new System.Drawing.Point(265, 391);
            this.botonCliente.Name = "botonCliente";
            this.botonCliente.Size = new System.Drawing.Size(161, 31);
            this.botonCliente.TabIndex = 54;
            this.botonCliente.Tag = "";
            this.botonCliente.Text = "Guardar Cliente";
            this.botonCliente.UseVisualStyleBackColor = true;
            this.botonCliente.Click += new System.EventHandler(this.botonCliente_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(89, 507);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(337, 20);
            this.txtDireccion.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Dirección";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(89, 481);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(337, 20);
            this.txtDni.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 46;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 455);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(337, 20);
            this.txtNombre.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nombre";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IVA Sujeto Exento",
            "Consumidor Final"});
            this.comboBox1.Location = new System.Drawing.Point(89, 395);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "SIN DOCUMENTO"});
            this.comboBox2.Location = new System.Drawing.Point(89, 428);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Credito",
            "Efectivo"});
            this.comboBox3.Location = new System.Drawing.Point(550, 454);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(147, 21);
            this.comboBox3.TabIndex = 58;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Tipo de Pago";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(550, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 101);
            this.panel2.TabIndex = 60;
            // 
            // FacturaB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonCliente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_reconectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonAñadir);
            this.Controls.Add(this.labelTotalNum);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.panel1);
            this.Name = "FacturaB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonImprimir;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelTotalNum;
        private System.Windows.Forms.Button botonAñadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reconectar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button botonCliente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}