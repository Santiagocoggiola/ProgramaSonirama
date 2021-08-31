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
    public partial class IngreInterno : Form
    {
        public IngreInterno()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Ingresos ing = new Ingresos();
            this.Hide();
            ing.Show();
        }
    }
}
