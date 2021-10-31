
namespace Sonirama.Proveedores
{
    partial class ProvListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvListado));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.NUMPRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENCARGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIUDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEDISC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVINCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIPOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMPRO,
            this.NOMBRE,
            this.ENCARGADO,
            this.DIRECCION,
            this.CIUDAD,
            this.TELEDISC,
            this.PROVINCIA,
            this.CODIPOS,
            this.TELEFONO,
            this.CUIT});
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 776);
            this.dataGridView1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(632, 55);
            this.label3.TabIndex = 79;
            this.label3.Text = "LISTADO PROVEEDORES";
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.Location = new System.Drawing.Point(12, 859);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(285, 90);
            this.BtnAtras.TabIndex = 80;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // NUMPRO
            // 
            this.NUMPRO.HeaderText = "Prov";
            this.NUMPRO.Name = "NUMPRO";
            this.NUMPRO.Width = 60;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 200;
            // 
            // ENCARGADO
            // 
            this.ENCARGADO.HeaderText = "Encargado";
            this.ENCARGADO.Name = "ENCARGADO";
            this.ENCARGADO.Width = 150;
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "Direccion";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.Width = 150;
            // 
            // CIUDAD
            // 
            this.CIUDAD.HeaderText = "Ciudad";
            this.CIUDAD.Name = "CIUDAD";
            // 
            // TELEDISC
            // 
            this.TELEDISC.HeaderText = "Carac";
            this.TELEDISC.Name = "TELEDISC";
            // 
            // PROVINCIA
            // 
            this.PROVINCIA.HeaderText = "Provincia";
            this.PROVINCIA.Name = "PROVINCIA";
            // 
            // CODIPOS
            // 
            this.CODIPOS.HeaderText = "Cod Postal";
            this.CODIPOS.Name = "CODIPOS";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "Telefono";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.Width = 140;
            // 
            // ProvListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProvListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProvListado";
            this.Load += new System.EventHandler(this.ProvListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMPRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENCARGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIUDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEDISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVINCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
    }
}