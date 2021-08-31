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
    public partial class Cantidades : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
        MySqlCommand command;
        MySqlDataReader mdr;
        string codigo;
        string digito;
        public Cantidades()
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
                command = new MySqlCommand(selectQuery, con);

                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    LblRub.Visible = true;
                    LblProv.Visible = true;
                    LblArt.Visible = true;
                    LblCantAnt.Visible = true;
                    LblCantNu.Visible = true;
                    LblProveedor.Visible = true;
                    LblCantidad.Visible = true;
                    LblArticulo.Visible = true;
                    LblRubro.Visible = true;
                    TxtCantNueva.Visible = true;
                    BtnCambiar.Visible = true;
                    LblArticulo.Text = mdr.GetString("ARTICULO");
                    LblProveedor.Text = mdr.GetString("PROVEEDOR");
                    LblCantidad.Text = mdr.GetString("CANTID");
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
            con.Open();
            string Query = "UPDATE stock.stock SET CANTID=" + int.Parse(TxtCantNueva.Text) + " WHERE CODIGO=" + int.Parse(TxtCodigo.Text);
            command = new MySqlCommand(Query, con);
            command.ExecuteNonQuery();
            con.Close();  
        }
    }
}
