
namespace Sonirama
{
    partial class IngreInterno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngreInterno));
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.BtnCargaIng = new System.Windows.Forms.Button();
            this.BtnIvaCompras = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(472, 619);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(251, 133);
            this.BtnAtras.TabIndex = 32;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultas.Location = new System.Drawing.Point(472, 287);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(251, 133);
            this.BtnConsultas.TabIndex = 30;
            this.BtnConsultas.Text = "Consulta";
            this.BtnConsultas.UseVisualStyleBackColor = false;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // BtnCargaIng
            // 
            this.BtnCargaIng.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnCargaIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargaIng.Location = new System.Drawing.Point(472, 121);
            this.BtnCargaIng.Name = "BtnCargaIng";
            this.BtnCargaIng.Size = new System.Drawing.Size(251, 133);
            this.BtnCargaIng.TabIndex = 28;
            this.BtnCargaIng.Text = "Carga Ing";
            this.BtnCargaIng.UseVisualStyleBackColor = false;
            this.BtnCargaIng.Click += new System.EventHandler(this.BtnCargaIng_Click);
            // 
            // BtnIvaCompras
            // 
            this.BtnIvaCompras.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnIvaCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIvaCompras.Location = new System.Drawing.Point(472, 453);
            this.BtnIvaCompras.Name = "BtnIvaCompras";
            this.BtnIvaCompras.Size = new System.Drawing.Size(251, 133);
            this.BtnIvaCompras.TabIndex = 33;
            this.BtnIvaCompras.Text = "Iva Compras";
            this.BtnIvaCompras.UseVisualStyleBackColor = false;
            this.BtnIvaCompras.Click += new System.EventHandler(this.BtnIvaCompras_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 55);
            this.label8.TabIndex = 64;
            this.label8.Text = "INGRESOS";
            // 
            // IngreInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnIvaCompras);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnConsultas);
            this.Controls.Add(this.BtnCargaIng);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IngreInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngreInterno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button BtnCargaIng;
        private System.Windows.Forms.Button BtnIvaCompras;
        private System.Windows.Forms.Label label8;
    }
}