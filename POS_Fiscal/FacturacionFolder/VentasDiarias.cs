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
    public partial class VentasDiarias : Form
    {
        public VentasDiarias()
        {
            InitializeComponent();
        }

        private void BtnDiario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Imprimir Las Ventas Diarias?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Helpers.sumarPorComprobante("stock.ventasb", "stock.ventasbdiarias", TxtFecha.Text);
                Helpers.sumarPorComprobante("stock.ventasa", "stock.ventasadiarias", TxtFecha.Text);
                Helpers.imprimirComprobante(printDocument1);
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
