
namespace Sonirama
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.BtnMensual = new System.Windows.Forms.Button();
            this.BtnDiario = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMensual
            // 
            this.BtnMensual.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnMensual.Location = new System.Drawing.Point(429, 466);
            this.BtnMensual.Name = "BtnMensual";
            this.BtnMensual.Size = new System.Drawing.Size(363, 169);
            this.BtnMensual.TabIndex = 11;
            this.BtnMensual.Text = "Ventas Mensuales";
            this.BtnMensual.UseVisualStyleBackColor = false;
            this.BtnMensual.Click += new System.EventHandler(this.BtnMensual_Click);
            // 
            // BtnDiario
            // 
            this.BtnDiario.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnDiario.Location = new System.Drawing.Point(429, 170);
            this.BtnDiario.Name = "BtnDiario";
            this.BtnDiario.Size = new System.Drawing.Size(363, 169);
            this.BtnDiario.TabIndex = 10;
            this.BtnDiario.Text = "Ventas Diarias";
            this.BtnDiario.UseVisualStyleBackColor = false;
            this.BtnDiario.Click += new System.EventHandler(this.BtnDiario_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.BtnAtras.Location = new System.Drawing.Point(12, 780);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(363, 169);
            this.BtnAtras.TabIndex = 21;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(382, 55);
            this.label8.TabIndex = 64;
            this.label8.Text = "MENU VENTAS";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnMensual);
            this.Controls.Add(this.BtnDiario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMensual;
        private System.Windows.Forms.Button BtnDiario;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label label8;
    }
}