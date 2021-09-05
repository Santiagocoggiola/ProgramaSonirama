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
    public partial class PMargen : Form
    {
        Helpers.Producto producto = new Helpers.Producto();
        string query;
        MySqlConnection con = Helpers.newCon();

        MySqlDataReader rd;
        public PMargen()
        {
            InitializeComponent();
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            producto.codigo = int.Parse(TxtCodigo.Text);
            
            query = "SELECT * FROM stock.stock WHERE CODIGO=" + producto.codigo;
            con.Open();
            rd = Helpers.readQuery(query, con);
            if (rd.Read())
            {
                LblArticulo.Text = rd.GetString("ARTICULO");
                LblRubro.Text = rd.GetString("RUBRO");
                LblProveedor.Text = rd.GetString("PROVEEDOR");
                LblDescProv.Text = rd.GetString("DESCPRV");
                LblCant.Text = rd.GetString("CANTID");
                LblMPublico.Text = rd.GetString("MARGEN");
                LblMTaller.Text = rd.GetString("MARGTAL");
                LblCostoNeto.Text = rd.GetString("DOLAR");
                LblPecioListaAn.Text = rd.GetString("DOLIS");
                LblPublico.Text = rd.GetString("PREPUBCIVA");
                LblTaller.Text = rd.GetString("PRETA");
            }
            rd.Close();
            con.Close();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Modificaciones mod = new Modificaciones();
            this.Hide();
            mod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float margenpublico = float.Parse(txtMP.Text);
            float margentaller = float.Parse(txtMT.Text);
            float descuento = float.Parse(txtDescuento.Text);
            string preciolistanew = TxtPrecioLista.Text.Replace(".", ",");
            float preciolista = float.Parse(preciolistanew);
            preciolistanew = TxtPrecioLista.Text.Replace(",", ".");
            float preciocosto = 0;
            float publico = 0;
            float taller = 0;
            con.Open();
            query = "UPDATE stock.stock SET DOLAR=" + preciolistanew + ", MARGEN=" + margenpublico + ", MARGTAL=" + margentaller + ", DESCPRV=" + descuento + " WHERE CODIGO=" + producto.codigo;
            Helpers.NonQuery(query, con);
            con.Close();
            margenpublico = (margenpublico / 100) + 1;
            margentaller = (margentaller / 100) + 1;
            if(descuento != 0)
            {
                descuento = descuento / 100;
                preciocosto = preciolista * (1 - descuento);
                
            }
            else
            {
                preciocosto = preciolista;
                descuento = 1;
            }

            publico = preciocosto * margenpublico;
            taller = preciocosto * margentaller;
            string tallernew = taller.ToString();
            tallernew = tallernew.Replace(",", ".");
            string publiconew = publico.ToString();
            publiconew = publiconew.Replace(",", ".");
            string preciocostonew = preciocosto.ToString();
            preciocostonew = preciocostonew.Replace(",", ".");
            query = "UPDATE stock.stock SET DOLIS=" + preciocostonew + ", PREPUBCIVA=" + publiconew  + ", PRETA=" + tallernew + " WHERE CODIGO=" + producto.codigo;
            con.Open();
            Helpers.NonQuery(query, con);
            con.Close();
        }
    }
}
