
namespace POS_Fiscal
{
    partial class Cantidades
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
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.LblArt = new System.Windows.Forms.Label();
            this.LblRub = new System.Windows.Forms.Label();
            this.LblProv = new System.Windows.Forms.Label();
            this.TxtDigito = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.LblRubro = new System.Windows.Forms.Label();
            this.LblArticulo = new System.Windows.Forms.Label();
            this.LblCantAnt = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblCantNu = new System.Windows.Forms.Label();
            this.TxtCantNueva = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(667, 47);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 20);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // LblArt
            // 
            this.LblArt.AutoSize = true;
            this.LblArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblArt.Location = new System.Drawing.Point(12, 237);
            this.LblArt.Name = "LblArt";
            this.LblArt.Size = new System.Drawing.Size(81, 17);
            this.LblArt.TabIndex = 26;
            this.LblArt.Text = "ARTICULO:";
            this.LblArt.Visible = false;
            // 
            // LblRub
            // 
            this.LblRub.AutoSize = true;
            this.LblRub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblRub.Location = new System.Drawing.Point(12, 185);
            this.LblRub.Name = "LblRub";
            this.LblRub.Size = new System.Drawing.Size(62, 17);
            this.LblRub.TabIndex = 25;
            this.LblRub.Text = "RUBRO:";
            this.LblRub.Visible = false;
            // 
            // LblProv
            // 
            this.LblProv.AutoSize = true;
            this.LblProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblProv.Location = new System.Drawing.Point(12, 122);
            this.LblProv.Name = "LblProv";
            this.LblProv.Size = new System.Drawing.Size(100, 17);
            this.LblProv.TabIndex = 24;
            this.LblProv.Text = "PROVEEDOR:";
            this.LblProv.Visible = false;
            // 
            // TxtDigito
            // 
            this.TxtDigito.Location = new System.Drawing.Point(619, 47);
            this.TxtDigito.Name = "TxtDigito";
            this.TxtDigito.Size = new System.Drawing.Size(36, 20);
            this.TxtDigito.TabIndex = 23;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(474, 47);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(62, 20);
            this.TxtCodigo.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(395, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "CODIGO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "CAMBIO CANTIDAD POR CODIGO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(548, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "DIGITO:";
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.LblProveedor.Location = new System.Drawing.Point(129, 122);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(0, 17);
            this.LblProveedor.TabIndex = 29;
            this.LblProveedor.Visible = false;
            // 
            // LblRubro
            // 
            this.LblRubro.AutoSize = true;
            this.LblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.LblRubro.Location = new System.Drawing.Point(129, 185);
            this.LblRubro.Name = "LblRubro";
            this.LblRubro.Size = new System.Drawing.Size(0, 17);
            this.LblRubro.TabIndex = 30;
            this.LblRubro.Visible = false;
            // 
            // LblArticulo
            // 
            this.LblArticulo.AutoSize = true;
            this.LblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.LblArticulo.Location = new System.Drawing.Point(129, 237);
            this.LblArticulo.Name = "LblArticulo";
            this.LblArticulo.Size = new System.Drawing.Size(0, 17);
            this.LblArticulo.TabIndex = 31;
            this.LblArticulo.Visible = false;
            // 
            // LblCantAnt
            // 
            this.LblCantAnt.AutoSize = true;
            this.LblCantAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblCantAnt.Location = new System.Drawing.Point(12, 366);
            this.LblCantAnt.Name = "LblCantAnt";
            this.LblCantAnt.Size = new System.Drawing.Size(146, 17);
            this.LblCantAnt.TabIndex = 32;
            this.LblCantAnt.Text = "CANTIDAD ANTIGUA:";
            this.LblCantAnt.Visible = false;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.LblCantidad.Location = new System.Drawing.Point(187, 366);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(0, 17);
            this.LblCantidad.TabIndex = 33;
            this.LblCantidad.Visible = false;
            // 
            // LblCantNu
            // 
            this.LblCantNu.AutoSize = true;
            this.LblCantNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LblCantNu.Location = new System.Drawing.Point(355, 366);
            this.LblCantNu.Name = "LblCantNu";
            this.LblCantNu.Size = new System.Drawing.Size(128, 17);
            this.LblCantNu.TabIndex = 34;
            this.LblCantNu.Text = "CANTIDAD NUEVA";
            this.LblCantNu.Visible = false;
            // 
            // TxtCantNueva
            // 
            this.TxtCantNueva.Location = new System.Drawing.Point(489, 366);
            this.TxtCantNueva.Name = "TxtCantNueva";
            this.TxtCantNueva.Size = new System.Drawing.Size(75, 20);
            this.TxtCantNueva.TabIndex = 35;
            this.TxtCantNueva.Visible = false;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(25, 441);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 20);
            this.BtnAtras.TabIndex = 37;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Location = new System.Drawing.Point(580, 366);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(75, 20);
            this.BtnCambiar.TabIndex = 36;
            this.BtnCambiar.Text = "Cambiar";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Visible = false;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-6, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(777, 82);
            this.label4.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(-6, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(777, 109);
            this.label5.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-6, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(777, 35);
            this.label6.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(-6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(777, 46);
            this.label7.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(-6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(777, 52);
            this.label8.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(-6, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(777, 46);
            this.label9.TabIndex = 43;
            // 
            // Cantidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 470);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnCambiar);
            this.Controls.Add(this.TxtCantNueva);
            this.Controls.Add(this.LblCantNu);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblCantAnt);
            this.Controls.Add(this.LblArticulo);
            this.Controls.Add(this.LblRubro);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblArt);
            this.Controls.Add(this.LblRub);
            this.Controls.Add(this.LblProv);
            this.Controls.Add(this.TxtDigito);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Cantidades";
            this.Text = "Cantidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblArt;
        private System.Windows.Forms.Label LblRub;
        private System.Windows.Forms.Label LblProv;
        private System.Windows.Forms.TextBox TxtDigito;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.Label LblRubro;
        private System.Windows.Forms.Label LblArticulo;
        private System.Windows.Forms.Label LblCantAnt;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblCantNu;
        private System.Windows.Forms.TextBox TxtCantNueva;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}