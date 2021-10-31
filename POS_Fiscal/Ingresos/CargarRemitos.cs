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
    public partial class CargarRemitos : Form
    {
        public CargarRemitos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Helpers.cargaRemito(TxtNroFactura.Text, TxtSIva.Text.Replace(",", "."), TxtCIva.Text.Replace(",", "."),
               TxtIva.Text.Replace(",", "."), TxtProveedor.Text.Replace(",", "."), TxtFecha.Text.Replace("-", "/"));
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remitos rm = new Remitos();
            rm.Show();
        }
    }
}
