
namespace POS_Fiscal
{
    partial class VentasDiarias
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.BtnDiario = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(462, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "FECHA";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(575, 393);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(311, 38);
            this.TxtFecha.TabIndex = 17;
            // 
            // BtnDiario
            // 
            this.BtnDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnDiario.Location = new System.Drawing.Point(492, 216);
            this.BtnDiario.Name = "BtnDiario";
            this.BtnDiario.Size = new System.Drawing.Size(394, 163);
            this.BtnDiario.TabIndex = 16;
            this.BtnDiario.Text = "Ventas Diarias";
            this.BtnDiario.UseVisualStyleBackColor = true;
            this.BtnDiario.Click += new System.EventHandler(this.BtnDiario_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnAtras.Location = new System.Drawing.Point(12, 786);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(394, 163);
            this.BtnAtras.TabIndex = 19;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // VentasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.BtnDiario);
            this.Name = "VentasDiarias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasDiarias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Button BtnDiario;
        private System.Windows.Forms.Button BtnAtras;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}