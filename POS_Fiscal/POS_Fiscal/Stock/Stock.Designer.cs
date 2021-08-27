
namespace POS_Fiscal
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
            this.BtnVerArticulos = new System.Windows.Forms.Button();
            this.BtnModificaciones = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVerArticulos
            // 
            this.BtnVerArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerArticulos.Location = new System.Drawing.Point(182, 221);
            this.BtnVerArticulos.Name = "BtnVerArticulos";
            this.BtnVerArticulos.Size = new System.Drawing.Size(150, 76);
            this.BtnVerArticulos.TabIndex = 5;
            this.BtnVerArticulos.Text = "Ver Articulos";
            this.BtnVerArticulos.UseVisualStyleBackColor = true;
            this.BtnVerArticulos.Click += new System.EventHandler(this.BtnVerArticulos_Click);
            // 
            // BtnModificaciones
            // 
            this.BtnModificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificaciones.Location = new System.Drawing.Point(182, 98);
            this.BtnModificaciones.Name = "BtnModificaciones";
            this.BtnModificaciones.Size = new System.Drawing.Size(150, 76);
            this.BtnModificaciones.TabIndex = 4;
            this.BtnModificaciones.Text = "Modificaciones";
            this.BtnModificaciones.UseVisualStyleBackColor = true;
            this.BtnModificaciones.Click += new System.EventHandler(this.BtnModificaciones_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(182, 344);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(150, 76);
            this.BtnAtras.TabIndex = 6;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 540);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnVerArticulos);
            this.Controls.Add(this.BtnModificaciones);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVerArticulos;
        private System.Windows.Forms.Button BtnModificaciones;
        private System.Windows.Forms.Button BtnAtras;
    }
}