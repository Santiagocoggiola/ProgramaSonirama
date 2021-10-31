
namespace Sonirama
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.BtnVerArticulos = new System.Windows.Forms.Button();
            this.BtnModificaciones = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVerArticulos
            // 
            this.BtnVerArticulos.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnVerArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerArticulos.Location = new System.Drawing.Point(472, 436);
            this.BtnVerArticulos.Name = "BtnVerArticulos";
            this.BtnVerArticulos.Size = new System.Drawing.Size(318, 169);
            this.BtnVerArticulos.TabIndex = 5;
            this.BtnVerArticulos.Text = "Ver Articulos";
            this.BtnVerArticulos.UseVisualStyleBackColor = false;
            this.BtnVerArticulos.Click += new System.EventHandler(this.BtnVerArticulos_Click);
            // 
            // BtnModificaciones
            // 
            this.BtnModificaciones.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnModificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificaciones.Location = new System.Drawing.Point(472, 177);
            this.BtnModificaciones.Name = "BtnModificaciones";
            this.BtnModificaciones.Size = new System.Drawing.Size(318, 169);
            this.BtnModificaciones.TabIndex = 4;
            this.BtnModificaciones.Text = "Modificaciones";
            this.BtnModificaciones.UseVisualStyleBackColor = false;
            this.BtnModificaciones.Click += new System.EventHandler(this.BtnModificaciones_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(472, 695);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(318, 169);
            this.BtnAtras.TabIndex = 6;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 55);
            this.label8.TabIndex = 65;
            this.label8.Text = "MENU STOCK";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnVerArticulos);
            this.Controls.Add(this.BtnModificaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVerArticulos;
        private System.Windows.Forms.Button BtnModificaciones;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label label8;
    }
}