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
    public partial class Modificaciones : Form
    {
        public Modificaciones()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            this.Hide();
            st.Show();
        }

        private void BtnPrecioPUn_Click(object sender, EventArgs e)
        {
            CambioPrecio cp = new CambioPrecio();
            this.Hide();
            cp.Show();
        }

        private void BtnCantidades_Click(object sender, EventArgs e)
        {
            Cantidades cant = new Cantidades();
            this.Hide();
            cant.Show();
        }

        private void BtnPrecioPMargen_Click(object sender, EventArgs e)
        {
            PMargen p = new PMargen();
            this.Hide();
            p.Show();
        }

        private void BtnCambioInt_Click(object sender, EventArgs e)
        {
            CambioInteres cam = new CambioInteres();
            cam.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambioPrecioGlobal glo = new CambioPrecioGlobal();
            glo.Show();
        }
    }
}
