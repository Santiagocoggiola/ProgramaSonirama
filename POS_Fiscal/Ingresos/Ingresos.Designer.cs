
namespace Sonirama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresos));
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnIngresos = new System.Windows.Forms.Button();
            this.BtnRemitos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(459, 592);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(293, 181);
            this.BtnAtras.TabIndex = 30;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnIngresos
            // 
            this.BtnIngresos.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresos.Location = new System.Drawing.Point(459, 134);
            this.BtnIngresos.Name = "BtnIngresos";
            this.BtnIngresos.Size = new System.Drawing.Size(293, 181);
            this.BtnIngresos.TabIndex = 28;
            this.BtnIngresos.Text = "Ingresos";
            this.BtnIngresos.UseVisualStyleBackColor = false;
            this.BtnIngresos.Click += new System.EventHandler(this.BtnIngresos_Click);
            // 
            // BtnRemitos
            // 
            this.BtnRemitos.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnRemitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemitos.Location = new System.Drawing.Point(459, 331);
            this.BtnRemitos.Name = "BtnRemitos";
            this.BtnRemitos.Size = new System.Drawing.Size(293, 181);
            this.BtnRemitos.TabIndex = 31;
            this.BtnRemitos.Text = "Remitos";
            this.BtnRemitos.UseVisualStyleBackColor = false;
            this.BtnRemitos.Click += new System.EventHandler(this.BtnRemitos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 55);
            this.label8.TabIndex = 64;
            this.label8.Text = "MENU COMPRAS";
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnRemitos);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnIngresos;
        private System.Windows.Forms.Button BtnRemitos;
        private System.Windows.Forms.Label label8;
    }
}