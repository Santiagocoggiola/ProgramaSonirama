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
    public partial class VentasMensuales : Form
    {
        public VentasMensuales()
        {
            InitializeComponent();
        }

        private void BtnMensual_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Imprimir Las Ventas Mensuales?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Helpers.sumarMensual("stock.ventasadiarias", "stock.ventasamensual", TxtMes.Text);
                Helpers.sumarMensual("stock.ventasbdiarias", "stock.ventasbmensual", TxtMes.Text);
                Helpers.imprimirMes(printDocument1);
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas ven = new Ventas();
            ven.Show();
        }
    }
}
