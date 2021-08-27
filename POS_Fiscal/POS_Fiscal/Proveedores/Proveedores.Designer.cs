
namespace POS_Fiscal
{
    partial class Proveedores
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
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnGastos = new System.Windows.Forms.Button();
            this.BtnProveed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(140, 303);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(150, 76);
            this.BtnAtras.TabIndex = 7;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnGastos
            // 
            this.BtnGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGastos.Location = new System.Drawing.Point(140, 197);
            this.BtnGastos.Name = "BtnGastos";
            this.BtnGastos.Size = new System.Drawing.Size(150, 76);
            this.BtnGastos.TabIndex = 6;
            this.BtnGastos.Text = "Gastos";
            this.BtnGastos.UseVisualStyleBackColor = true;
            // 
            // BtnProveed
            // 
            this.BtnProveed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveed.Location = new System.Drawing.Point(140, 91);
            this.BtnProveed.Name = "BtnProveed";
            this.BtnProveed.Size = new System.Drawing.Size(150, 76);
            this.BtnProveed.TabIndex = 5;
            this.BtnProveed.Text = "Proveedores";
            this.BtnProveed.UseVisualStyleBackColor = true;
            this.BtnProveed.Click += new System.EventHandler(this.BtnProveed_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 507);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnGastos);
            this.Controls.Add(this.BtnProveed);
            this.Name = "Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnGastos;
        private System.Windows.Forms.Button BtnProveed;
    }
}