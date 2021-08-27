using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Fiscal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            Facturacion fac = new Facturacion();
            this.Hide();
            fac.Show();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            Stock ar = new Stock();
            this.Hide();
            ar.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            this.Hide();
            prov.Show();
        }

        private void BtnIngresos_Click(object sender, EventArgs e)
        {
            Ingresos ing = new Ingresos();
            this.Hide();
            ing.Show();
        }
    }
}
