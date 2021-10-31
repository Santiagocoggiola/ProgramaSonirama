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
    public partial class ProvModificaciones : Form
    {
        public ProvModificaciones()
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
            if(prov.nombre != "")
            {
                BtnModificar.Enabled = true;
            }
        }
        
           
         
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProvInterno prov = new ProvInterno();
            prov.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Helpers.Proveedor prov = new Helpers.Proveedor();
            prov.nombre = TxtNombreFix.Text;
            prov.encargado = TxtEncargado.Text;
            prov.ciudad = TxtCiudad.Text;
            prov.direccion = TxtDireccion.Text;
            prov.provincia = TxtProvincia.Text;
            prov.productos = TxtProd.Text;
            prov.telefono = TxtTelefono.Text;
            prov.carac = TxtCarac.Text;
            prov.cuit = TxtCuit.Text;
            prov.codPos = TxtCodPos.Text;
            prov.numProv = int.Parse(TxtBuscar.Text);
            Proveedor.provMod(prov);
            if(prov.nombre != "")
            {
                BtnModificar.Enabled = false;
            }
        }
    }
}
