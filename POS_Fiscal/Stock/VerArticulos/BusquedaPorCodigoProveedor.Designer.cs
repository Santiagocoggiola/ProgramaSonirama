
namespace Sonirama
{
    partial class BusquedaPorCodigoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaPorCodigoProveedor));
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCodProv = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.PowderBlue;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnBuscar.Location = new System.Drawing.Point(847, 14);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(118, 65);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Digito,
            this.CodigoProv,
            this.Articulo,
            this.Cantidad,
            this.Costo,
            this.Publico});
            this.dataGridView1.Location = new System.Drawing.Point(124, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1004, 794);
            this.dataGridView1.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Digito
            // 
            this.Digito.HeaderText = "Digito";
            this.Digito.Name = "Digito";
            this.Digito.ReadOnly = true;
            // 
            // CodigoProv
            // 
            this.CodigoProv.HeaderText = "Codigo Proveedor";
            this.CodigoProv.Name = "CodigoProv";
            this.CodigoProv.ReadOnly = true;
            this.CodigoProv.Width = 150;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Publico
            // 
            this.Publico.HeaderText = "Publico";
            this.Publico.Name = "Publico";
            this.Publico.ReadOnly = true;
            this.Publico.Width = 110;
            // 
            // TxtCodProv
            // 
            this.TxtCodProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.TxtCodProv.Location = new System.Drawing.Point(982, 30);
            this.TxtCodProv.Name = "TxtCodProv";
            this.TxtCodProv.Size = new System.Drawing.Size(146, 31);
            this.TxtCodProv.TabIndex = 14;
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Salmon;
            this.BtnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnAtras.Location = new System.Drawing.Point(15, 885);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(118, 65);
            this.BtnAtras.TabIndex = 13;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(119, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Busqueda por Codigo Proveedor ---->";
            // 
            // BusquedaPorCodigoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 961);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtCodProv);
            this.Controls.Add(this.BtnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaPorCodigoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusquedaPorCodigoProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publico;
        private System.Windows.Forms.TextBox TxtCodProv;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Label label1;
    }
}