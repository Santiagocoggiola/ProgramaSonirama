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
    public partial class CambioPrecioGlobal : Form
    {
        public CambioPrecioGlobal()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificaciones mod = new Modificaciones();
            mod.Show();
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cambiar el precio de toda la base de datos?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                float porcentaje = float.Parse(TxtPorcentaje.Text);
                Helpers.cambioPrecioGlobal(porcentaje);
            }
        }
    }
}
