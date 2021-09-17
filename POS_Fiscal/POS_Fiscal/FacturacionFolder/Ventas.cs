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
    public partial class Ventas : Form
    {
        static string fecha = "";
        public Ventas()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion fac = new Facturacion();
        }

        private void BtnAnual_Click(object sender, EventArgs e)
        {

        }

        private void BtnMensual_Click(object sender, EventArgs e)
        {

        }

        private void BtnDiario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Imprimir Las Ventas Diarias?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Helpers.sumarPorComprobante("stock.ventasb", "stock.ventasbtotales");
                //sumarPorComprobante("stock.ventasa", "stock.ventasatotales");
                fecha = TxtFecha.Text;
                Helpers.imprimirComprobante(printDocument1);
            }
        }
    }
}
