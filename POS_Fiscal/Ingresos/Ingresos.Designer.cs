
namespace POS_Fiscal
{
    partial class Ingresos
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
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.BtnIngresos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(531, 622);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(293, 181);
            this.BtnAtras.TabIndex = 30;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.Location = new System.Drawing.Point(531, 393);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(293, 181);
            this.BtnPedidos.TabIndex = 29;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.UseVisualStyleBackColor = true;
            // 
            // BtnIngresos
            // 
            this.BtnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresos.Location = new System.Drawing.Point(531, 164);
            this.BtnIngresos.Name = "BtnIngresos";
            this.BtnIngresos.Size = new System.Drawing.Size(293, 181);
            this.BtnIngresos.TabIndex = 28;
            this.BtnIngresos.Text = "Ingresos";
            this.BtnIngresos.UseVisualStyleBackColor = true;
            this.BtnIngresos.Click += new System.EventHandler(this.BtnIngresos_Click);
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnPedidos);
            this.Controls.Add(this.BtnIngresos);
            this.Name = "Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnPedidos;
        private System.Windows.Forms.Button BtnIngresos;
    }
}