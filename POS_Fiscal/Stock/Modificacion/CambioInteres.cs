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
    public partial class CambioInteres : Form
    {
        public CambioInteres()
        {
            InitializeComponent();
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cambiar el Interes?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                float porcentaje = float.Parse(TxtPorcentaje.Text);
                Helpers.cambioInteres(porcentaje);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificaciones mod = new Modificaciones();
            mod.Show();
        }
    }
}
