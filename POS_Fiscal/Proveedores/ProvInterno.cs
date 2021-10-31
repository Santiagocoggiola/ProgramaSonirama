using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sonirama.Proveedores;
namespace Sonirama
{
    public partial class ProvInterno : Form
    {
        public ProvInterno()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal pro = new MenuPrincipal();
            this.Hide();
            pro.Show();
        }

        private void BtnAltas_Click(object sender, EventArgs e)
        {
            ProvAltas alt = new ProvAltas();
            alt.Show();
            this.Hide();
        }

        private void BtnModificaciones_Click(object sender, EventArgs e)
        {
            ProvModificaciones mod = new ProvModificaciones();
            mod.Show();
            this.Hide();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            ProvConsultas con = new ProvConsultas();
            con.Show();
            this.Hide();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            ProvBorrar bor = new ProvBorrar();
            bor.Show();
            this.Hide();
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            ProvListado list = new ProvListado();
            list.Show();
            this.Hide();
        }
    }
}
