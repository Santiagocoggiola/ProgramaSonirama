﻿
namespace POS_Fiscal
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
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.BtnCargaIng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(107, 267);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(150, 40);
            this.BtnAtras.TabIndex = 32;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultas.Location = new System.Drawing.Point(107, 174);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(150, 40);
            this.BtnConsultas.TabIndex = 30;
            this.BtnConsultas.Text = "Consulta";
            this.BtnConsultas.UseVisualStyleBackColor = true;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // BtnCargaIng
            // 
            this.BtnCargaIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargaIng.Location = new System.Drawing.Point(107, 88);
            this.BtnCargaIng.Name = "BtnCargaIng";
            this.BtnCargaIng.Size = new System.Drawing.Size(150, 40);
            this.BtnCargaIng.TabIndex = 28;
            this.BtnCargaIng.Text = "Carga Ing";
            this.BtnCargaIng.UseVisualStyleBackColor = true;
            this.BtnCargaIng.Click += new System.EventHandler(this.BtnCargaIng_Click);
            // 
            // IngreInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 497);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnConsultas);
            this.Controls.Add(this.BtnCargaIng);
            this.Name = "IngreInterno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngreInterno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button BtnCargaIng;
    }
}