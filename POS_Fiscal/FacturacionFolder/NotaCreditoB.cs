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
    public partial class NotaCreditoB : Form
    {
        List<PrinterFun.datos> list = new List<PrinterFun.datos>();
        public NotaCreditoB()
        {
            InitializeComponent();
        }

        //Busca en la base de datos la factura para cargarla y mostrarla en pantalla.
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            list = PrinterFun.Buscar(txtComprobante.Text, "stock.ventasb");
            for (int i = 0; i < list.Count; ++i)
            {
                PrinterFun.datos dat = list.ElementAt(i);
                dataGridView1.Rows.Add(dat.NroComprobante, dat.NombreItem, dat.Cantidad, dat.PrecioUnitario, dat.Codigo, dat.Fecha, dat.Doc);
            }
            BtnImprimir.Enabled = true;
        }
        //Utiliza la factura previamente buscada para imprimirla como nota de credito
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            string comprobante = "82-00000-" + txtComprobante.Text;
            string dni = "", nombre = "", direccion = "";
            int condicion = 5;
            int tipodoc = 1;
            if (comboBox1.GetItemText(comboBox1.SelectedItem) != "Consumidor Final")
            {
                condicion = 6;
            }
            else
            {
                dni = txtDni.Text;
                nombre = txtNombre.Text;
                direccion = txtDireccion.Text;
            }
            if (txtDni.Text == "" && txtNombre.Text == "" && txtDireccion.Text == "")
            {
                dni = "1";
                nombre = "A";
                direccion = "A";


            }
            else
            {
                dni = txtDni.Text;
                nombre = txtNombre.Text;
                direccion = txtDireccion.Text;
            }
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "CUIT")
            {
                tipodoc = 3;
            }
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "CUIL")
            {
                tipodoc = 2;
            }
            PrinterFun.ImprimirNotaCredito(comprobante, list, nombre, direccion, tipodoc, dni, condicion, 3, txtDescripcion.Text);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Facturacion fac = new Facturacion();
            this.Hide();
            fac.Show();
        }
    }
}
