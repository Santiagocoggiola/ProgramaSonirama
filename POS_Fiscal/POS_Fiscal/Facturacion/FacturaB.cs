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


namespace POS_Fiscal
{

    public partial class FacturaB : Form
    {
        bool clienteGen = false;
        bool articulosCargados = false;
        int count = 1;
        string cantidadPagos = "";
        float interes = 1.2f;
        List<Helpers.Producto> list = new List<Helpers.Producto>();
        Helpers.Cliente cliente = new Helpers.Cliente();
        public FacturaB()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Consumidor Final";
            Load += FacturaB_Load;
        }
        private void FacturaB_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = "SIN DOCUMENTO";
            comboBox3.SelectedItem = "Efectivo";
            label2.Text = comboBox2.GetItemText(comboBox2.SelectedItem);
            progressBar1.Visible = false;
        }
        private void button_reconectar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reconectar con la impresora?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrinterFun.ConectarConImpresora();
            }
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion m = new Facturacion();
            m.Show();
        }

        private void botonAñadir_Click(object sender, EventArgs e)
        {
            //Create the dynamic TextBox.
            TextBox codigo = new TextBox();

            codigo.Location = new System.Drawing.Point(12, 25 * count);
            codigo.Size = new System.Drawing.Size(70, 20);
            codigo.Name = "txt_codigo" + (count);
            panel1.Controls.Add(codigo);

            Label nombre = new Label();
            nombre.Location = new System.Drawing.Point(96, 25 * count);
            nombre.Size = new System.Drawing.Size(260, 20);
            nombre.Name = "Lbl_nombre" + (count);
            panel1.Controls.Add(nombre);

            TextBox cantidad = new TextBox();
            cantidad.Location = new System.Drawing.Point(400, 25 * count);
            cantidad.Size = new System.Drawing.Size(40, 20);
            cantidad.Name = "txt_cantidad" + (count);
            panel1.Controls.Add(cantidad);

            Label totalUnitario = new Label();
            totalUnitario.Location = new System.Drawing.Point(525, 25 * count);
            totalUnitario.Size = new System.Drawing.Size(50, 20);
            totalUnitario.Name = "Lbl_totalUnitario" + (count);
            panel1.Controls.Add(totalUnitario);

            Label totalTotal = new Label();
            totalTotal.Location = new System.Drawing.Point(630, 25 * count);
            totalTotal.Size = new System.Drawing.Size(50, 20);
            totalTotal.Name = "lbl_totalTotal" + (count);
            panel1.Controls.Add(totalTotal);

            //Create the dynamic Button to remove the TextBox.
            Button button = new Button();
            button.Location = new System.Drawing.Point(690, 25 * count);
            button.Size = new System.Drawing.Size(60, 20);
            button.Name = "btnDelete_" + (count);
            button.Text = "Delete";
            button.Click += new System.EventHandler(this.btnDelete_Click);
            panel1.Controls.Add(button);

            count++;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Reference the Button which was clicked.
            count--;
            Button button = (sender as Button);

            //Determine the Index of the Button.
            int index = int.Parse(button.Name.Split('_')[1]);

            //Find the TextBox using Index and remove it.
            panel1.Controls.Remove(panel1.Controls.Find("txt_codigo" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("Lbl_nombre" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("txt_cantidad" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("Lbl_totalTotal" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("Lbl_totalUnitario" + index, true)[0]);
            //Remove the Button.
            panel1.Controls.Remove(button);

            //Rearranging the Location controls.
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]);
                if (controlIndex > index)
                {
                    TextBox txt = (TextBox)panel1.Controls.Find("txt_" + controlIndex, true)[0];
                    btn.Top = btn.Top - 25;
                    txt.Top = txt.Top - 25;

                    Label Lbl = (Label)panel1.Controls.Find("Lbl_" + controlIndex, true)[0];
                    btn.Top = btn.Top - 25;
                    txt.Top = txt.Top - 25;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            float total = 0;
            float precioParcial = 0;
            string Query;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
            MySqlDataReader rd;
            MySqlCommand cmd;
            Helpers.Producto producto = new Helpers.Producto();
            con.Open();
            for (int i = 1; i < count; ++i)
            {
                producto.codigo = int.Parse(((TextBox)panel1.Controls["txt_Codigo" + (i).ToString()]).Text);
                
                Query = "SELECT * FROM stock.stock WHERE CODIGO=" + producto.codigo.ToString();
                cmd = new MySqlCommand(Query, con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    producto.Nombre = rd.GetString("ARTICULO");
                    if(comboBox3.GetItemText(comboBox3.SelectedItem) == "Credito")
                    {
                        producto.precioUnitario = float.Parse(rd.GetString("PRETARG"));
                    }
                    else
                    {
                        producto.precioUnitario = float.Parse(rd.GetString("PREPUBCIVA"));
                    }
                    ((Label)panel1.Controls["Lbl_nombre" + (i).ToString()]).Text = producto.Nombre;
                    producto.cantidad = int.Parse(((TextBox)panel1.Controls["txt_cantidad" + (i).ToString()]).Text);  
                    ((Label)panel1.Controls["Lbl_totalUnitario" + (i).ToString()]).Text = producto.precioUnitario.ToString();
                    precioParcial = producto.cantidad * producto.precioUnitario;
                    
                }
                else
                { 
                    MessageBox.Show("Ingreso algun codigo Inexistente");
                }
                total = precioParcial + total;
                ((Label)panel1.Controls["Lbl_totalTotal" + (i).ToString()]).Text = precioParcial.ToString();
                list.Add(producto);
                rd.Close();
            }
            con.Close();
            labelTotalNum.Text = total.ToString();
            articulosCargados = true;
            if(articulosCargados && clienteGen)
            {
                botonImprimir.Enabled = true;
            }
        }
        private void botonImprimir_Click(object sender, EventArgs e)
        {
            PrinterFun.ConectarConImpresora();
            bool clienteCargado = false;
            PrinterFun.ConectarConImpresora();
            string combobox3 = comboBox3.GetItemText(comboBox3.SelectedItem);
            string combobox2 = comboBox2.GetItemText(comboBox2.SelectedItem);
            string combobox1 = comboBox1.GetItemText(comboBox1.SelectedItem);
            PrinterFun.CargarCliente(combobox1, combobox2, "Consumidor Final", cliente, 5, 0, ref clienteCargado, "SIN DOCUMENTO");
            PrinterFun.CargarCliente(combobox1, combobox2, "Consumidor Final", cliente, 5, 1, ref clienteCargado, "DNI");
            PrinterFun.CargarCliente(combobox1, combobox2, "Consumidor Final", cliente, 5, 2, ref clienteCargado, "CUIL");
            PrinterFun.CargarCliente(combobox1, combobox2, "Consumidor Final", cliente, 5, 3 , ref clienteCargado, "CUIT");
            PrinterFun.CargarCliente(combobox1, combobox2, "IVA Sujeto Exento", cliente, 6, 3, ref clienteCargado, "CUIT");
            if (clienteCargado != true)
            {
                MessageBox.Show("No ha cargado el cliente, primero cargue el cliente");
            }
            else
            {
                PrinterFun.CargaComprobante("FacturaB");
                PrinterFun.ImprimirItems(list, combobox3, interes, cantidadPagos, "FacturaB");
            }
            botonImprimir.Enabled = false;
        }
        private void botonCliente_Click(object sender, EventArgs e)
        {
            string helper;
            long result;
            cliente.nombre = txtNombre.Text;
            helper = txtDni.Text;
            bool number = long.TryParse(helper, out result);
            if (number != true && label2.Text != "SIN DOCUMENTO")
            {
                MessageBox.Show("En el Campo de dni, cuit y otros ingrese solo numeros por favor");

            }
            else
            {
                if ((helper.Length != 11 && (label2.Text == "CUIT" || label2.Text == "CUIL")) || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("El Cuit no tiene los 11 numeros o no ha elegido el tipo de documento");
                }
                else
                {
                    if ((helper.Length != 8 && label2.Text == "DNI") || comboBox2.SelectedItem == null)
                    {
                        MessageBox.Show("El Dni no tiene los 8 numeros o no ha elegido el tipo de documento");
                    }
                    else
                    {
                        if (label2.Text != "SIN DOCUMENTO")
                        {
                            cliente.documento = Convert.ToInt64(txtDni.Text);
                            cliente.nombre = txtNombre.Text;
                            cliente.direccion = txtDireccion.Text;
                            label2.Text = comboBox2.GetItemText(comboBox2.SelectedItem);
                            
                        }
                    }

                }
                clienteGen = true;
            }
            if (articulosCargados && clienteGen)
            {
                botonImprimir.Enabled = true;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            int cantidad = 0;
            if (combo == "IVA Sujeto Exento")
            {
                cantidad = comboBox2.Items.Count;
                for (int i = 0; i < cantidad; ++i)
                {
                    string elem = comboBox2.GetItemText(comboBox2.Items[0]);
                    comboBox2.Items.Remove(elem);
                }
                comboBox2.Items.Add("CUIT");
            }
            else
            {
                if (combo == "Consumidor Final")
                {
                    cantidad = comboBox2.Items.Count;
                    for (int i = 0; i < cantidad; ++i)
                    {
                        string elem = comboBox2.GetItemText(comboBox2.Items[0]);
                        comboBox2.Items.Remove(elem);
                    }
                    comboBox2.Items.Add("DNI");
                    comboBox2.Items.Add("CUIT");
                    comboBox2.Items.Add("CUIL");
                    comboBox2.Items.Add("SIN DOCUMENTO");
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            label2.Text = combo;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = this.comboBox3.GetItemText(comboBox3.SelectedItem);
            if (combo == "Efectivo")
            {
                if (panel2.Controls.Count != 0)
                {
                    panel2.Controls.Remove(panel2.Controls.Find("txt_tarjeta", true)[0]);
                    panel2.Controls.Remove(panel2.Controls.Find("BtnCuotas", true)[0]);
                }
            }
            else
            {
                if (combo == "Credito")
                {
                    TextBox tarjeta = new TextBox();
                    tarjeta.Location = new System.Drawing.Point(0, 0);
                    tarjeta.Size = new System.Drawing.Size(50, 20);
                    tarjeta.Name = "txt_tarjeta";
                    panel2.Controls.Add(tarjeta);

                    Button button = new Button();
                    button.Location = new System.Drawing.Point(0, 25);
                    button.Size = new System.Drawing.Size(60, 20);
                    button.Name = "BtnCuotas";
                    button.Text = "Agregar Cuotas";
                    button.Click += new System.EventHandler(this.btnCuotas_Click);
                    panel2.Controls.Add(button);
                }
            }
        }
        private void btnCuotas_Click(object sender, EventArgs e)
        {
            cantidadPagos = ((TextBox)panel2.Controls["txt_tarjeta".ToString()]).Text;
        }
    }
}
