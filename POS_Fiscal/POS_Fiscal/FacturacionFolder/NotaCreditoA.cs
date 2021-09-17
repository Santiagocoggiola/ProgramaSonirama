﻿using System;
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
    public partial class NotaCreditoA : Form
    {
        List<PrinterFun.datos> list = new List<PrinterFun.datos>();
        public NotaCreditoA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            list = PrinterFun.Buscar(txtComprobante.Text, "stock.ventasa");
            for (int i = 0; i < list.Count; ++i)
            {
                PrinterFun.datos dat = list.ElementAt(i);
                dataGridView1.Rows.Add(dat.NroComprobante, dat.NombreItem, dat.Cantidad, dat.PrecioUnitario, dat.Codigo, dat.Fecha, dat.Doc);
            }
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string comprobante = "81-00000-" + txtComprobante.Text;
            string dni = "", nombre = "", direccion = "";
            int condicion = 1;
            if(comboBox1.GetItemText(comboBox1.SelectedItem) != "Responsable Inscripto")
            {
                condicion = 4;
            }
            dni = txtDni.Text;
            nombre = txtNombre.Text;
            direccion = txtDireccion.Text;
            PrinterFun.ImprimirNotaCredito(comprobante, list, nombre, direccion, 3, dni, condicion, 3, txtDescripcion.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Facturacion fac = new Facturacion();
            this.Hide();
            fac.Show();
        }
    }
}
