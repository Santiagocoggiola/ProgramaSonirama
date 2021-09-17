
namespace POS_Fiscal
{
    partial class VerArticulos
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
            this.BtnArtComp = new System.Windows.Forms.Button();
            this.BtnCodProv = new System.Windows.Forms.Button();
            this.BtnRubro = new System.Windows.Forms.Button();
            this.BtnPProvee = new System.Windows.Forms.Button();
            this.BtnVerArticulos = new System.Windows.Forms.Button();
            this.BtnNombreArt = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnArtComp
            // 
            this.BtnArtComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArtComp.Location = new System.Drawing.Point(577, 310);
            this.BtnArtComp.Name = "BtnArtComp";
            this.BtnArtComp.Size = new System.Drawing.Size(200, 100);
            this.BtnArtComp.TabIndex = 9;
            this.BtnArtComp.Text = "Articulos por Ultima Compra";
            this.BtnArtComp.UseVisualStyleBackColor = true;
            this.BtnArtComp.Click += new System.EventHandler(this.BtnArtComp_Click);
            // 
            // BtnCodProv
            // 
            this.BtnCodProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCodProv.Location = new System.Drawing.Point(577, 194);
            this.BtnCodProv.Name = "BtnCodProv";
            this.BtnCodProv.Size = new System.Drawing.Size(200, 100);
            this.BtnCodProv.TabIndex = 8;
            this.BtnCodProv.Text = "Articulos por Codigo Proveedor";
            this.BtnCodProv.UseVisualStyleBackColor = true;
            this.BtnCodProv.Click += new System.EventHandler(this.BtnCodProv_Click);
            // 
            // BtnRubro
            // 
            this.BtnRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRubro.Location = new System.Drawing.Point(577, 78);
            this.BtnRubro.Name = "BtnRubro";
            this.BtnRubro.Size = new System.Drawing.Size(200, 100);
            this.BtnRubro.TabIndex = 7;
            this.BtnRubro.Text = "Articulos por Rubro";
            this.BtnRubro.UseVisualStyleBackColor = true;
            this.BtnRubro.Click += new System.EventHandler(this.BtnRubro_Click);
            // 
            // BtnPProvee
            // 
            this.BtnPProvee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPProvee.Location = new System.Drawing.Point(577, 658);
            this.BtnPProvee.Name = "BtnPProvee";
            this.BtnPProvee.Size = new System.Drawing.Size(200, 100);
            this.BtnPProvee.TabIndex = 12;
            this.BtnPProvee.Text = "Articulos por Proveedor";
            this.BtnPProvee.UseVisualStyleBackColor = true;
            this.BtnPProvee.Click += new System.EventHandler(this.BtnPProvee_Click);
            // 
            // BtnVerArticulos
            // 
            this.BtnVerArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerArticulos.Location = new System.Drawing.Point(577, 542);
            this.BtnVerArticulos.Name = "BtnVerArticulos";
            this.BtnVerArticulos.Size = new System.Drawing.Size(200, 100);
            this.BtnVerArticulos.TabIndex = 11;
            this.BtnVerArticulos.Text = "Ver Articulos";
            this.BtnVerArticulos.UseVisualStyleBackColor = true;
            this.BtnVerArticulos.Click += new System.EventHandler(this.BtnVerArticulos_Click);
            // 
            // BtnNombreArt
            // 
            this.BtnNombreArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNombreArt.Location = new System.Drawing.Point(577, 426);
            this.BtnNombreArt.Name = "BtnNombreArt";
            this.BtnNombreArt.Size = new System.Drawing.Size(200, 100);
            this.BtnNombreArt.TabIndex = 10;
            this.BtnNombreArt.Text = "Articulos por Nombre";
            this.BtnNombreArt.UseVisualStyleBackColor = true;
            this.BtnNombreArt.Click += new System.EventHandler(this.BtnNombreArt_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(577, 774);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(200, 100);
            this.BtnAtras.TabIndex = 14;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // VerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnPProvee);
            this.Controls.Add(this.BtnVerArticulos);
            this.Controls.Add(this.BtnNombreArt);
            this.Controls.Add(this.BtnArtComp);
            this.Controls.Add(this.BtnCodProv);
            this.Controls.Add(this.BtnRubro);
            this.Name = "VerArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerArticulos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnArtComp;
        private System.Windows.Forms.Button BtnCodProv;
        private System.Windows.Forms.Button BtnRubro;
        private System.Windows.Forms.Button BtnPProvee;
        private System.Windows.Forms.Button BtnVerArticulos;
        private System.Windows.Forms.Button BtnNombreArt;
        private System.Windows.Forms.Button BtnAtras;
    }
}