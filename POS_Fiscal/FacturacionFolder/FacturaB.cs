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

    public partial class FacturaB : Form
    {
        int count = 1;
        string cantidadPagos = "";
        float interes = 1.2f;
        List<Helpers.Producto> list = new List<Helpers.Producto>();
        Helpers.ProducList producList = new Helpers.ProducList();
        Helpers.Cliente cliente = new Helpers.Cliente();
        public FacturaB()
        {
            InitializeComponent();
            comboBoxTipo.SelectedItem = "Consumidor Final";
            producList.cargado = false;
            Load += FacturaB_Load;
        }
        private void FacturaB_Load(object sender, EventArgs e)
        {
            comboBoxDoc.SelectedItem = "SIN DOCUMENTO";
            comboBoxPago.SelectedItem = "Efectivo";
            LabelDoc.Text = comboBoxDoc.GetItemText(comboBoxDoc.SelectedItem);
            progressBar1.Visible = false;
        }
        
        //Reconecta la impresora fiscal
        private void button_reconectar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reconectar con la impresora?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrinterFun.ConectarConImpresora();
            }
        }
        
        //Ir al menu anterior
        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion m = new Facturacion();
            m.Show();
        }
        
        //Genera los campos para escribir los productos al apretar el boton añadir
        private void botonAñadir_Click(object sender, EventArgs e)
        {
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
            if (producList.listProd != null && producList.listProd.Count != 0)
            {
                producList.listProd.Remove(producList.listProd.Last());
                labelTotalNum.Text = producList.listProd.Sum(x => x.precioUnitario).ToString();
            }
        }

        //Elimina los campos que se añadieron, apretando el boton delete.


        //Manda a imprimir el ticket
        private void botonImprimir_Click(object sender, EventArgs e)
        {
            Factura.imprimirFactura("B", comboBoxPago, comboBoxDoc, comboBoxTipo, cliente,
                botonImprimir, list, interes, cantidadPagos, labelTotalNum, txtDni);
            producList.cargado = false;
            cliente.cargado = false;
            botonCliente.Enabled = true;
            producList.listProd.Clear();
            panel1.Controls.Clear();
            count = 0;
        }
        
        //Se Encarga de guardar el cliente para la impesion de la factura
        private void botonCliente_Click(object sender, EventArgs e)
        {
            cliente = Factura.cargarCliente("B", producList, cliente, LabelDoc, txtNombre,
                txtDni, txtDireccion, comboBoxDoc, comboBoxTipo, botonImprimir);
            botonCliente.Enabled = false;
        }
        //Boton cuotas
        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            cantidadPagos = ((TextBox)panel2.Controls["txt_tarjeta".ToString()]).Text;
        }

        //Busca y completa los datos de los productos ingesados
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            bool generar = true;
            for (int i = 1; i < count; ++i)
            {
                TextBox TxtCodigo = (TextBox)panel1.Controls.Find("txt_codigo" + i, true)[0];
                TextBox TxtDigito = (TextBox)panel1.Controls.Find("txt_digito" + i, true)[0];
                TextBox TxtCantidad = (TextBox)panel1.Controls.Find("txt_cantidad" + i, true)[0];
                if (TxtCantidad.Text == "" && TxtCodigo.Text == "" && TxtDigito.Text == "")
                {
                    generar = false;
                }
            }
            if (generar == true)
            {
                producList = Factura.generate(count, panel1, comboBoxPago, labelTotalNum, cliente.cargado, botonImprimir, list);
            }
            else
            {
                MessageBox.Show("Por favor verifique si coloco codigo/digito/cantidad en todos los campos");
            }
            
        }

        //Cambia el tipo de razon social en el combobox y luego cambia los documentos asociados a la razon social en el combobox doc
        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = this.comboBoxTipo.GetItemText(this.comboBoxTipo.SelectedItem);
            int cantidad = 0;
            if (combo == "IVA Sujeto Exento")
            {
                cantidad = comboBoxDoc.Items.Count;
                for (int i = 0; i < cantidad; ++i)
                {
                    string elem = comboBoxDoc.GetItemText(comboBoxDoc.Items[0]);
                    comboBoxDoc.Items.Remove(elem);
                }
                comboBoxDoc.Items.Add("CUIT");
            }
            else
            {
                if (combo == "Consumidor Final")
                {
                    cantidad = comboBoxDoc.Items.Count;
                    for (int i = 0; i < cantidad; ++i)
                    {
                        string elem = comboBoxDoc.GetItemText(comboBoxDoc.Items[0]);
                        comboBoxDoc.Items.Remove(elem);
                    }
                    comboBoxDoc.Items.Add("DNI");
                    comboBoxDoc.Items.Add("CUIT");
                    comboBoxDoc.Items.Add("CUIL");
                    comboBoxDoc.Items.Add("SIN DOCUMENTO");
                }
            }
        }

        //Cambia el documento por el seleccionado
        private void comboBoxDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = this.comboBoxDoc.GetItemText(this.comboBoxDoc.SelectedItem);
            LabelDoc.Text = combo;
        }

        //Cambia por el tipo de pago seleccionado.
        private void comboBoxPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = this.comboBoxPago.GetItemText(comboBoxPago.SelectedItem);
            panel2 = FormHelpers.PanelTipoPago(panel2, combo);
            if (combo == "Tarjeta")
            {
                Button button = (Button)panel1.Controls.Find("BtnCuotas", true)[0];
                button.Click += new System.EventHandler(this.BtnCuotas_Click);
            }
        }
    }
}

