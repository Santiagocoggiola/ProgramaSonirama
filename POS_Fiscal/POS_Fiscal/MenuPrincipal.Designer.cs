
namespace POS_Fiscal
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
            this.SuspendLayout();
            // 
            // BtnStock
            // 
            this.BtnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.Location = new System.Drawing.Point(186, 184);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(150, 76);
            this.BtnStock.TabIndex = 3;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = true;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturacion.Location = new System.Drawing.Point(186, 78);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(150, 76);
            this.BtnFacturacion.TabIndex = 2;
            this.BtnFacturacion.Text = "Facturacion";
            this.BtnFacturacion.UseVisualStyleBackColor = true;
            this.BtnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // BtnIngresos
            // 
            this.BtnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresos.Location = new System.Drawing.Point(186, 290);
            this.BtnIngresos.Name = "BtnIngresos";
            this.BtnIngresos.Size = new System.Drawing.Size(150, 76);
            this.BtnIngresos.TabIndex = 4;
            this.BtnIngresos.Text = "Ingresos";
            this.BtnIngresos.UseVisualStyleBackColor = true;
            this.BtnIngresos.Click += new System.EventHandler(this.BtnIngresos_Click);
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.Location = new System.Drawing.Point(186, 396);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(150, 76);
            this.BtnProveedores.TabIndex = 5;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.UseVisualStyleBackColor = true;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 555);
            this.Controls.Add(this.BtnProveedores);
            this.Controls.Add(this.BtnIngresos);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.BtnFacturacion);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Button BtnIngresos;
        private System.Windows.Forms.Button BtnProveedores;
    }
}