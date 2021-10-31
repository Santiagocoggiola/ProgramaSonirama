
namespace Sonirama
{
    partial class MenuPrincipal
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
            this.BtnStock = new System.Windows.Forms.Button();
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.BtnIngresos = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.TxtSalir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.Location = new System.Drawing.Point(492, 272);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(281, 145);
            this.BtnStock.TabIndex = 3;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturacion.Location = new System.Drawing.Point(492, 109);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(281, 145);
            this.BtnFacturacion.TabIndex = 2;
            this.BtnFacturacion.Text = "Facturacion";
            this.BtnFacturacion.UseVisualStyleBackColor = false;
            this.BtnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // BtnIngresos
            // 
            this.BtnIngresos.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresos.Location = new System.Drawing.Point(492, 435);
            this.BtnIngresos.Name = "BtnIngresos";
            this.BtnIngresos.Size = new System.Drawing.Size(281, 145);
            this.BtnIngresos.TabIndex = 4;
            this.BtnIngresos.Text = "Ingresos";
            this.BtnIngresos.UseVisualStyleBackColor = false;
            this.BtnIngresos.Click += new System.EventHandler(this.BtnIngresos_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.Location = new System.Drawing.Point(492, 598);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(281, 145);
            this.BtnProveedores.TabIndex = 5;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // TxtSalir
            // 
            this.TxtSalir.BackColor = System.Drawing.Color.Salmon;
            this.TxtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalir.Location = new System.Drawing.Point(492, 761);
            this.TxtSalir.Name = "TxtSalir";
            this.TxtSalir.Size = new System.Drawing.Size(281, 145);
            this.TxtSalir.TabIndex = 6;
            this.TxtSalir.Text = "Salir";
            this.TxtSalir.UseVisualStyleBackColor = false;
            this.TxtSalir.Click += new System.EventHandler(this.TxtSalir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(447, 55);
            this.label8.TabIndex = 65;
            this.label8.Text = "MENU PRINCIPAL";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSalir);
            this.Controls.Add(this.BtnProveedores);
            this.Controls.Add(this.BtnIngresos);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.BtnFacturacion);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Button BtnIngresos;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button TxtSalir;
        private System.Windows.Forms.Label label8;
    }
}