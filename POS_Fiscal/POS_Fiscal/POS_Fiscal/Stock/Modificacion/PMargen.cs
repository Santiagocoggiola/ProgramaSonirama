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
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
        MySqlCommand cmd;
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
            cmd = new MySqlCommand(query, con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                LblArticulo.Text = rd.GetString("ARTICULO");
                LblRubro.Text = rd.GetString("RUBRO");
                LblProveedor.Text = rd.GetString("PROVEEDOR");
                LblDescProv.Text = rd.GetString("CODIPROVEE");
                LblCant.Text = rd.GetString("CANTID");
                LblMPublico.Text = rd.GetString("MARGEN");
                LblMTaller.Text = rd.GetString("MARGTAL");
                LblCostoNeto.Text = rd.GetString("DOLAR");
                LblPecioListaAn.Text = rd.GetString("DOLIS");
                LblPublico.Text = rd.GetString("PREPUBCIVA");
            }
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
            float margenpublico;
            float margentaller;
            con.Open();
           // query = "UPDATE FROM stock.stock SET D"
            //cmd = new MySqlCommand()
        }
    }
}
