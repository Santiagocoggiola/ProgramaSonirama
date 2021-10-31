using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using MySql.Data.MySqlClient;
using Sonirama.Objects;


namespace Sonirama
{
    public partial class FacturaA : Form
    {
        int count = 1;
        string cantidadPagos = "";
        float interes = 1.2f;
        Helpers.Cliente cliente = new Helpers.Cliente();
        List<Helpers.Producto> list = new List<Helpers.Producto>();
        Helpers.ProducList prodList = new Helpers.ProducList();
        public FacturaA()
        {
            InitializeComponent();
            prodList.cargado = false;
            comboBoxDoc.SelectedItem = "CUIT";
            comboBoxPago.SelectedItem = "Efectivo";
            Load += FacturaA_Load;
        }

        //Inicializa algunas variables
        private void FacturaA_Load(object sender, EventArgs e)
        {
            PrinterFun.ConectarConImpresora();
            progressBar1.Visible = false;
        }
        
        //Reconecta con la impresora
        private void Button_reconectar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reconectar con la impresora?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrinterFun.ConectarConImpresora();
            }
        }


        
        //Sale del programa
        private void BotonSalirA_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion m = new Facturacion();
            m.Show();
        }

  
        //Añade los campos para los productos
        private void BotonAñadirA_Click_1(object sender, EventArgs e)
        {
            //Create the dynamic TextBox.
            panel1 = FormHelpers.PanelFactura(panel1,count);
            //Create the dynamic Button to remove the TextBox.
            Button button = (Button)panel1.Controls.Find("btnDelete_" + (count), true)[0];
            button.Click += new System.EventHandler(this.BtnDelete_Click);
            count++;
        }


        //Elimina los campos agregados para los productos
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Reference the Button which was clicked.
            count--;
            FormHelpers.DeleteFromPanel(panel1, sender, count);
            if (prodList.listProd != null && prodList.listProd.Count != 0)
            {
                prodList.listProd.Remove(prodList.listProd.Last());
                labelTotalNumA.Text = prodList.listProd.Sum(x => x.precioUnitario).ToString();
            }
        }

        //Realiza la carga del cliente agregado
        private void BotonCliente_Click(object sender, EventArgs e)
        {
            cliente = Factura.cargarCliente("A", prodList, cliente, label1 , txtRazonSocial,
                txtCuit, txtDireccion, comboBoxDoc, comboBoxTipo, botonImprimirA);
            botonCliente.Enabled = false;
        }

        //Se encarga de la impresion del ticket
        private void BotonImprimirA_Click(object sender, EventArgs e)
        {
            Factura.imprimirFactura("A", comboBoxPago, comboBoxDoc, comboBoxTipo,
                cliente, botonImprimirA, list, interes, cantidadPagos, labelTotalNumA, txtCuit);
            prodList.cargado = false;
            cliente.cargado = false;
            botonCliente.Enabled = true;
            prodList.listProd.Clear();
            panel1.Controls.Clear();
            count = 0;
        }

        //Cambia el tipo de razon social en el combobox y luego cambia los documentos asociados a la razon social en el combobox doc
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = this.comboBoxPago.GetItemText(comboBoxPago.SelectedItem);
            panel2 = FormHelpers.PanelTipoPago(panel2, combo);
            if(combo == "Tarjeta")
            {
                Button button = (Button)panel1.Controls.Find("BtnCuotas", true)[0];
                button.Click += new System.EventHandler(this.BtnCuotas_Click);
            }
        }

        //Cuotas
        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            cantidadPagos = ((TextBox)panel2.Controls["txt_tarjeta".ToString()]).Text;
        }

        //Busca en la base de datos el nombre de la empresa
        private void BtnBuscarNombre_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM stock.clientes WHERE NOMBRE=" + "'" + txtBusquedaNombre.Text + "'";
            MySqlConnection con = Helpers.newCon();
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            if (rd.Read())
            {
                txtRazonSocial.Text = rd.GetString("NOMBRE");
                txtDireccion.Text = rd.GetString("DIRECCION");
                txtCuit.Text = rd.GetString("DOC");
                comboBoxTipo.SelectedItem = rd.GetString("RESPONSABILIDAD");
            }
            else
            {
                MessageBox.Show("CLIENTE NO ENCONTRADO");
            }
            con.Close();
        }

        //Busca en la base de datos el cuit de la empresa
        private void BtnBuscarCuit_Click(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM stock.clientes WHERE DOC=" + txtBusquedaCuit.Text;
            MySqlConnection con = Helpers.newCon();
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            if (rd.Read())
            {
                txtRazonSocial.Text = rd.GetString("NOMBRE");
                txtDireccion.Text = rd.GetString("DIRECCION");
                txtCuit.Text = rd.GetString("DOC");
                comboBoxTipo.SelectedItem = rd.GetString("RESPONSABILIDAD");
            }
            else
            {
                MessageBox.Show("CLIENTE NO ENCONTRADO");
            }
            con.Close();
        }

        //Rellena los datos de los productos
        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            bool generar = true;
           for(int i = 0; i < count; ++i)
           {
                TextBox TxtCodigo = (TextBox)panel1.Controls.Find("txt_codigo" + i, true)[0];
                TextBox TxtDigito = (TextBox)panel1.Controls.Find("txt_digito" + i, true)[0];
                TextBox TxtCantidad = (TextBox)panel1.Controls.Find("txt_cantidad" + i, true)[0];
                if(TxtCantidad.Text == "" && TxtCodigo.Text == "" && TxtDigito.Text == "")
                {
                    generar = false;
                } 
           }
           if(generar == true)
            {
                prodList = Factura.generate(count, panel1, comboBoxPago, labelTotalNumA, cliente.cargado, botonImprimirA, list);
            }
            else
            {
                MessageBox.Show("Por favor verifique si coloco codigo/digito/cantidad en todos los campos");
            }
            
        }
    }
}

