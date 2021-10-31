
namespace Sonirama
{
    partial class Remitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remitos));
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.BtnConMod = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(12, 820);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(358, 129);
            this.BtnAtras.TabIndex = 29;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click_1);
            // 
            // BtnCargar
            // 
            this.BtnCargar.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargar.Location = new System.Drawing.Point(417, 292);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(452, 119);
            this.BtnCargar.TabIndex = 28;
            this.BtnCargar.Text = "Cargar Remitos";
            this.BtnCargar.UseVisualStyleBackColor = false;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // BtnConMod
            // 
            this.BtnConMod.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnConMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConMod.Location = new System.Drawing.Point(417, 439);
            this.BtnConMod.Name = "BtnConMod";
            this.BtnConMod.Size = new System.Drawing.Size(452, 119);
            this.BtnConMod.TabIndex = 30;
            this.BtnConMod.Text = "Consultar/Modificar Remitos";
            this.BtnConMod.UseVisualStyleBackColor = false;
            this.BtnConMod.Click += new System.EventHandler(this.BtnConMod_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 55);
            this.label8.TabIndex = 64;
            this.label8.Text = "MENU REMITOS";
            // 
            // Remitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnConMod);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnCargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remitos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.Button BtnConMod;
        private System.Windows.Forms.Label label8;
    }
}