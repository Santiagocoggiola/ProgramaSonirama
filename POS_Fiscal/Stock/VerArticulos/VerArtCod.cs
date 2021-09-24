using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace POS_Fiscal
{
    public partial class VerArtCod : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
        MySqlCommand command;
        MySqlDataReader mdr;
        public VerArtCod()
        {
            InitializeComponent();
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = "";
            int result;
            codigo = txtCodigo.Text;
            if (int.TryParse(codigo, out result) != true)
            {
                MessageBox.Show("Ingrese solo numeros");
                codigo = "";
                txtCodigo.Text = "";
            }
            else
            {
                con.Open();
                string selectQuery = "SELECT * FROM stock.stock WHERE CODIGO=" + int.Parse(txtCodigo.Text);
                command = new MySqlCommand(selectQuery, con);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    lblAgrup.Text = mdr.GetString("GRANTI");
                    lblArt.Text = mdr.GetString("ARTICULO");
                    lblCantidad.Text = mdr.GetInt32("CANTID").ToString();
                    lblCod.Text = mdr.GetInt32("CODIGO").ToString() + "/" + mdr.GetString("DV");
                    lblCodProv.Text = mdr.GetString("CODIPROVEE");
                    lblCodProv2.Text = mdr.GetString("CODIPROVE2");
                    lblCosto.Text = mdr.GetString("DOLAR").ToString();
                    lblLista.Text = mdr.GetString("DOLIS").ToString();
                    lblProv.Text = mdr.GetString("PROVEEDOR").ToString();
                    lblPrecioPublico.Text = mdr.GetString("PREPUBCIVA").ToString();
                    lblPrecioTarjeta.Text = mdr.GetString("PRETARG").ToString();
                    lblPrecioTaller.Text = mdr.GetString("PRETA").ToString();
                    lblMGP.Text = mdr.GetString("MARGEN").ToString();
                    lblMGT.Text = mdr.GetString("MARGTAL").ToString();
                    lblAyuda.Text = mdr.GetString("USOS").ToString();
                    lblDenomProv.Text = mdr.GetString("ARTICULO2").ToString();
                    lblProvOpc.Text = mdr.GetString("PROVEEDOR2").ToString();
                    lblRubro.Text = mdr.GetString("RUBRO");
                    lblLinea.Text = mdr.GetString("LINEA");
                    LblProvHabitual.Text = mdr.GetString("PROVEEDOR");
                    LblUltimaCompra.Text = mdr.GetString("ULPRO");
                    LblSegundoProvee.Text = mdr.GetString("PROVEEDOR2");
                }
                else
                {
                    MessageBox.Show("No se encontraron datos");
                }
                con.Close();
            }


        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            VerArticulos ver = new VerArticulos();
            this.Hide();
            ver.Show();
        }
    }
}
