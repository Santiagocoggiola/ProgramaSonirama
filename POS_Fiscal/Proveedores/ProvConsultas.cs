using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonirama.Proveedores
{
    public partial class ProvConsultas : Form
    {
        public ProvConsultas()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int numProv = int.Parse(TxtBuscar.Text);
            Helpers.Proveedor prov = new Helpers.Proveedor();
            prov = Proveedor.provConsulta(numProv);
            LblNombre.Text = prov.nombre;
            LblEncargado.Text = prov.encargado;
            LblCarac.Text = prov.carac;
            LblCiudad.Text = prov.ciudad;
            LblCodPos.Text = prov.codPos;
            LblCuit.Text = prov.cuit;
            LblDireccion.Text = prov.direccion;
            LblProducto.Text = prov.productos;
            LblProvincia.Text = prov.provincia;
            LblTelefono.Text = prov.telefono;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProvInterno prov = new ProvInterno();
            prov.Show();
        }
    }
}
