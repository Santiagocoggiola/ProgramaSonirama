using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonirama
{
    public partial class BusquedaPorNombre : Form
    {
        public BusquedaPorNombre()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerArticulos art = new VerArticulos();
            art.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (TxtNombre.Text != "")
            {
                List<Helpers.Producto> productos = new List<Helpers.Producto>();
                Helpers.Producto p = new Helpers.Producto();
                string searchBy = "ARTICULO LIKE '%" + TxtNombre.Text + "%'";
                productos = Helpers.BusquedaStock(productos, searchBy);
                for (int i = 0; i < productos.Count; ++i)
                {
                    p = productos.ElementAt(i);
                    dataGridView1.Rows.Add(p.codigo, p.digito, p.codProv, p.Nombre, p.costo, p.cantidad, p.precioUnitario);
                }
            }
            else
            {
                MessageBox.Show("Ingrese algo para buscar");
            }
        }
    }
}
