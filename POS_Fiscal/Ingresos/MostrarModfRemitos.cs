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
    public partial class MostrarModfRemitos : Form
    {
        public MostrarModfRemitos()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remitos rm = new Remitos();
            rm.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(TxtNroFactura.Text != "" && TxtProveedor.Text != "" && TxtFecha.Text != "")
            {
                Helpers.mostrarRemito(TxtNroFactura.Text, TxtProveedor.Text, TxtFecha.Text, LblmontoSiva,
                LblmontoCiva, Lbliva, LblnumProv, LblnroFact, Lblfecha);
                BtnModificar.Enabled = true;
                TxtIva.Enabled = true;
                TxtCIva.Enabled = true;
                TxtSIva.Enabled = true;
                TxtNroFactura.Enabled = false;
                TxtFecha.Enabled = false;
                TxtProveedor.Enabled = false;
                BtnBuscar.Enabled = false;
            }
            else
            {
                MessageBox.Show("No ha ingresado la fecha, numero de factura o proveedor");
            }
            

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(TxtNroFactura.Text != "" && TxtProveedor.Text != "" && TxtFecha.Text != ""  && TxtIva.Text != "" && TxtCIva.Text != "" && TxtSIva.Text != "")
            {
                Helpers.modificarRemito(TxtNroFactura.Text, TxtSIva.Text, TxtCIva.Text, TxtIva.Text, TxtProveedor.Text, TxtFecha.Text);
                BtnModificar.Enabled = false;
                TxtIva.Enabled = false;
                TxtCIva.Enabled = false;
                TxtSIva.Enabled = false;
                TxtNroFactura.Enabled = true;
                TxtFecha.Enabled = true;
                TxtProveedor.Enabled = true;
                BtnBuscar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No ha ingresado alguno de los montos");
            }            
        }
    }
}
