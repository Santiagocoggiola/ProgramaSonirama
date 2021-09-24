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
namespace POS_Fiscal
{
    public partial class ConsultaFactProv : Form
    {
        public ConsultaFactProv()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            IngreInterno ing = new IngreInterno();
            ing.Show();
            this.Hide();
        }
        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            CargaIngresos.items item = new CargaIngresos.items();
            MySqlConnection con = Helpers.newCon();
            con.Open();
            string Query = "SELECT * FROM stock.ingreso_factura_prov WHERE NROFACTURA=" + TxtNumeroFactura.Text + " AND PROVEEDOR=" + TxtProveedor.Text;
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            while (rd.Read())
            {
                if (rd.GetInt16("CAMBIOPRECIO") == 1)
                {
                    item.cambioPrecio = true;
                }
                else
                {
                    item.cambioPrecio = false;
                }
                item.cantidad = rd.GetInt32("CANTIDAD");
                item.descuento = rd.GetFloat("DESCUENTO");
                item.descuento1 = rd.GetFloat("DESC1");
                item.descuento2 = rd.GetFloat("DES2");
                item.pack = rd.GetInt32("PACK");
                item.nombreItem = rd.GetString("NOMBREITEM");
                item.preciocosto = rd.GetFloat("PRECIOCOSTO");
                item.preciolista = rd.GetFloat("PRECIOLISTA");
                float total = 0;
                total = item.preciocosto + total;
                dataGridView1.Rows.Add(item.codigo, item.nombreItem, item.cantidad, item.preciolista, item.preciocosto, item.descuento, item.descuento1, item.descuento2, item.pack, item.cambioPrecio, total);
            }
            con.Close();
        }
    }
}
