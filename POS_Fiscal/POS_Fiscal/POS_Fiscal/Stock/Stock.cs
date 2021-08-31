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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void BtnVerArticulos_Click(object sender, EventArgs e)
        {
            VerArticulos ar = new VerArticulos();
            this.Hide();
            ar.Show();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void BtnModificaciones_Click(object sender, EventArgs e)
        {
            Modificaciones mod = new Modificaciones();
            this.Hide();
            mod.Show();
        }
    }
}
