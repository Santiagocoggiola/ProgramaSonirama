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
    public partial class VerArticulos : Form
    {
        public VerArticulos()
        {
            InitializeComponent();
        }

        private void VerArticulos_Load(object sender, EventArgs e)
        {

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
    }
}
