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
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void BtnIngresos_Click(object sender, EventArgs e)
        {
            IngreInterno ing = new IngreInterno();
            this.Hide();
            ing.Show();
        }

        private void BtnRemitos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remitos rem = new Remitos();
            rem.Show();
        }
    }
}
