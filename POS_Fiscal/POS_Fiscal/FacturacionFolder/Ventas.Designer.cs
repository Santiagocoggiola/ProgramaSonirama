
namespace POS_Fiscal
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
            this.BtnMensual = new System.Windows.Forms.Button();
            this.BtnDiario = new System.Windows.Forms.Button();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.BtnAnual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // BtnMensual
            // 
            this.BtnMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMensual.Location = new System.Drawing.Point(429, 407);
            this.BtnMensual.Name = "BtnMensual";
            this.BtnMensual.Size = new System.Drawing.Size(177, 76);
            this.BtnMensual.TabIndex = 11;
            this.BtnMensual.Text = "Ventas Mensuales";
            this.BtnMensual.UseVisualStyleBackColor = true;
            this.BtnMensual.Click += new System.EventHandler(this.BtnMensual_Click);
            // 
            // BtnDiario
            // 
            this.BtnDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiario.Location = new System.Drawing.Point(429, 263);
            this.BtnDiario.Name = "BtnDiario";
            this.BtnDiario.Size = new System.Drawing.Size(177, 76);
            this.BtnDiario.TabIndex = 10;
            this.BtnDiario.Text = "Ventas Diarias";
            this.BtnDiario.UseVisualStyleBackColor = true;
            this.BtnDiario.Click += new System.EventHandler(this.BtnDiario_Click);
            // 
            // TxtFecha
            // 
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtFecha.Location = new System.Drawing.Point(512, 353);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(100, 30);
            this.TxtFecha.TabIndex = 12;
            // 
            // BtnAnual
            // 
            this.BtnAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnual.Location = new System.Drawing.Point(429, 549);
            this.BtnAnual.Name = "BtnAnual";
            this.BtnAnual.Size = new System.Drawing.Size(177, 76);
            this.BtnAnual.TabIndex = 14;
            this.BtnAnual.Text = "Ventas Anuales";
            this.BtnAnual.UseVisualStyleBackColor = true;
            this.BtnAnual.Click += new System.EventHandler(this.BtnAnual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(426, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "FECHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(424, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "MES/AÑO";
            // 
            // TxtMes
            // 
            this.TxtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtMes.Location = new System.Drawing.Point(536, 500);
            this.TxtMes.Name = "TxtMes";
            this.TxtMes.Size = new System.Drawing.Size(100, 30);
            this.TxtMes.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(426, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "AÑO";
            // 
            // TxtAño
            // 
            this.TxtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtAño.Location = new System.Drawing.Point(512, 636);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(100, 30);
            this.TxtAño.TabIndex = 18;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(12, 873);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(177, 76);
            this.BtnAtras.TabIndex = 20;
            this.BtnAtras.Text = "ATRAS";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAnual);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.BtnMensual);
            this.Controls.Add(this.BtnDiario);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMensual;
        private System.Windows.Forms.Button BtnDiario;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Button BtnAnual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.Button BtnAtras;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}