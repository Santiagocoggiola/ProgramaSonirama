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

namespace Sonirama.Proveedores
{
    public partial class ProvAltas : Form
    {
        public ProvAltas()
        {
            InitializeComponent();
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            Helpers.Proveedor prov = new Helpers.Proveedor();
            prov.nombre = TxtNombre.Text;
            prov.encargado = TxtEncargado.Text;
            prov.ciudad = TxtCiudad.Text;
            prov.direccion = TxtDireccion.Text;
            prov.provincia = TxtProvincia.Text;
            prov.productos = TxtProd.Text;
            prov.telefono = TxtTelefono.Text;
            prov.carac = TxtCarac.Text;
            prov.cuit = TxtCuit.Text;
            prov.codPos = TxtCodPos.Text;
            Proveedor.provAlta(prov);
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProvInterno prov = new ProvInterno();
            prov.Show();
        }
    }
}
