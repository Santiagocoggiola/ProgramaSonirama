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
namespace Sonirama
{
    public partial class CambioPrecio : Form
    {
        MySqlConnection con = Helpers.newCon();
        MySqlDataReader mdr;
        string codigo;
        string digito;
        public CambioPrecio()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Modificaciones mod = new Modificaciones();
            this.Hide();
            mod.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int result;
            codigo = TxtCodigo.Text;
            digito = TxtDigito.Text;
            if (int.TryParse(codigo, out result) != true)
            {
                MessageBox.Show("Ingrese solo numeros");
                codigo = "";
                TxtCodigo.Text = "";
            }
            else
            {
                con.Open();
                string selectQuery = "SELECT * FROM stock.stock WHERE CODIGO=" + int.Parse(codigo) + " AND DV=" + int.Parse(digito);
                mdr = Helpers.readQuery(selectQuery, con);
                if (mdr.Read())
                {
                    Lblrub.Visible = true;
                    Lblpro.Visible = true;
                    LblPubAnt.Visible = true;
                    LblTallAnt.Visible = true;
                    Lblart.Visible = true;
                    LblPrecioPubNuevo.Visible = true;
                    LblPrecioTaNuevo.Visible = true;
                    LblArticulo.Visible = true;
                    LblProveedor.Visible = true;
                    LblPublico.Visible = true;
                    LblRubro.Visible = true;
                    LblTaller.Visible = true;
                    TxtPublico.Visible = true;
                    TxtTaller.Visible = true;
                    BtnCambiar.Visible = true;
                    LblArticulo.Text = mdr.GetString("ARTICULO");
                    LblProveedor.Text = mdr.GetString("PROVEEDOR");
                    LblPublico.Text = mdr.GetString("PREPUBCIVA");
                    LblTaller.Text = mdr.GetString("PRETA");
                    LblRubro.Text = mdr.GetString("RUBRO");
                }
                else
                {
                    MessageBox.Show("Codigo No encontrado");
                }
                con.Close();
            }
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            string publico = TxtPublico.Text;
            string taller = TxtTaller.Text;
            string tarjeta;
            float interes = 0;
            string Query = "SELECT * FROM stock.tarjeta WHERE IDTARJETA=1";
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            if (rd.Read())
            {
                interes = rd.GetFloat("INTERES");
            }
            con.Close();
            tarjeta = (interes * (float.Parse(publico))).ToString();
            publico = publico.Replace(",", ".");
            taller = taller.Replace(",", ".");
            con.Open();
            Query = "UPDATE stock.stock SET PREPUBCIVA=" + publico + ", PRETA=" + taller + ", PRETARG=" + taller + " WHERE CODIGO=" + int.Parse(codigo);
            Helpers.NonQuery(Query, con);
            con.Close();
        }
    }
}
