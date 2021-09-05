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
    public partial class CargaIngresos : Form
    {
        public struct items
        {
            public int codigo;
            public string nombreItem;
            public int cantidad;
            public float precio;
            public float descuento;
            public float descuento1;
            public float descuento2;
            public float pack;
            public bool cambioPrecio;
        }
        public struct factura
        {
            public string numeroProv;
            public string numeroFactura;
        }
        MySqlConnection con = Helpers.newCon();
        factura fac = new factura();
        items item = new items();
        public CargaIngresos()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            IngreInterno ing = new IngreInterno();
            ing.Show();
            this.Hide();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            fac.numeroFactura = TxtNumeroFactura.Text;
            fac.numeroProv = TxtProveedor.Text;
            item.codigo = int.Parse(TxtCodigo.Text);
            item.cantidad = int.Parse(TxtCantidad.Text);
            item.descuento = int.Parse(TxtDescuento.Text);

            string Query = "INSERT INTO stock.ingreso_factura_prov (PROVEEDOR, FECHA, NROFACTURA, NOMBREITEM, CANTIDAD, PRECIO, DESCUENTO, DESCUENTO(1), DESCUENTO(2), PACK, CAMBIOPRECIO) VALUES ( '" +     "; 
            con.Open();
            Helpers.NonQuery(Query, con);
            con.Close();

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
