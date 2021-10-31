using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonirama.Proveedores
{
    public partial class ProvListado : Form
    {
        public ProvListado()
        {
            InitializeComponent();
        }

        private void ProvListado_Load(object sender, EventArgs e)
        {
            List<Helpers.Proveedor> listProd = new List<Helpers.Proveedor>();
            listProd = Proveedor.provListado();
            for(int i = 0; i < listProd.Count; ++i)
            {
                dataGridView1.Rows.Add(listProd[i].numProv, listProd[i].nombre, listProd[i].encargado, listProd[i].direccion, listProd[i].ciudad, listProd[i].provincia, listProd[i].codPos,
                    listProd[i].carac, listProd[i].telefono, listProd[i].cuit);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProvInterno prov = new ProvInterno();
            prov.Show();
        }
    }
}
