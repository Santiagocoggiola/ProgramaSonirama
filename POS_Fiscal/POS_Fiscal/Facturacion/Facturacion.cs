using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Fiscal
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void botonFacturaB_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacturaB fb = new FacturaB();
            fb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FacturaA fa = new FacturaA();
            fa.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            this.Hide();
            mp.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
             PrinterFun.CierreZ();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrinterFun.CierreX();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
