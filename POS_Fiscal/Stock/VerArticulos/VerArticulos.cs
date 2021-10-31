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
    public partial class VerArticulos : Form
    {
        public VerArticulos()
        {
            InitializeComponent();
        }


        private void BtnVerArticulos_Click(object sender, EventArgs e)
        {
            VerArtCod art = new VerArtCod();
            this.Hide();
            art.Show();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Stock stc = new Stock();
            this.Hide();
            stc.Show();
        }

        private void BtnRubro_Click(object sender, EventArgs e)
        {
            BusquedaPorRubro rub = new BusquedaPorRubro();
            rub.Show();
            this.Hide();
        }

        private void BtnCodProv_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaPorCodigoProveedor prov = new BusquedaPorCodigoProveedor();
            prov.Show();
        }

        private void BtnArtComp_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaPorCompra comp = new BusquedaPorCompra();
            comp.Show();
        }

        private void BtnNombreArt_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaPorNombre nom = new BusquedaPorNombre();
            nom.Show();
        }

        private void BtnPProvee_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaPorProveedor prov = new BusquedaPorProveedor();
            prov.Show();
        }
    }
}
