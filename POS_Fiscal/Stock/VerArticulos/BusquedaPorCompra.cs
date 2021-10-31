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
    public partial class BusquedaPorCompra : Form
    {
        public BusquedaPorCompra()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (TxtCompra.Text != "")
            {
                List<CargaIngresos.items> items = new List<CargaIngresos.items>();
                CargaIngresos.items it = new CargaIngresos.items();
                string searchBy = "CODIGO LIKE '%" + TxtCompra.Text + "%'";
                items = Helpers.BusquedaFactura(items, searchBy);
                for (int i = 0; i < items.Count; ++i)
                {
                     it = items.ElementAt(i);
                    dataGridView1.Rows.Add(it.NroFactura,it.prov, it.codigo,it.nombreItem, it.cantidad, it.preciocosto, it.fecha);
                }
            }
            else
            {
                MessageBox.Show("Ingrese algo para buscar");
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerArticulos art = new VerArticulos();
            art.Show();
        }
    }
}
