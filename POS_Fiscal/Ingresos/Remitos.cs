using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sonirama
{
    public partial class Remitos : Form
    {
        public Remitos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresos ing = new Ingresos();
            ing.Show();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            this.Hide();
            CargarRemitos rm = new CargarRemitos();
            rm.Show();
        }

        private void BtnConMod_Click(object sender, EventArgs e)
        {
            this.Hide();
            MostrarModfRemitos mod = new MostrarModfRemitos();
            mod.Show();
        }

        private void BtnAtras_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ingresos ing = new Ingresos();
            ing.Show();
        }
    }
}
