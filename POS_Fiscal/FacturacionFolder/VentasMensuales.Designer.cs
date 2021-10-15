
namespace POS_Fiscal
{
    partial class VentasMensuales
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMes = new System.Windows.Forms.TextBox();
            this.BtnMensual = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnAtras.Location = new System.Drawing.Point(12, 786);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(394, 163);
            this.BtnAtras.TabIndex = 23;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(442, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mes/Año";
            // 
            // TxtMes
            // 
            this.TxtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMes.Location = new System.Drawing.Point(569, 483);
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(311, 38);
            this.TxtMes.TabIndex = 21;
            // 
            // BtnMensual
            // 
            this.BtnMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnMensual.Location = new System.Drawing.Point(486, 306);
            this.BtnMensual.Name = "BtnMensual";
            this.BtnMensual.Size = new System.Drawing.Size(394, 163);
            this.BtnMensual.TabIndex = 20;
            this.BtnMensual.Text = "Ventas Mensuales";
            this.BtnMensual.UseVisualStyleBackColor = true;
            this.BtnMensual.Click += new System.EventHandler(this.BtnMensual_Click);
            // 
            // VentasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMes);
            this.Controls.Add(this.BtnMensual);
            this.Name = "VentasMensuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasMensuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMes;
        private System.Windows.Forms.Button BtnMensual;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}