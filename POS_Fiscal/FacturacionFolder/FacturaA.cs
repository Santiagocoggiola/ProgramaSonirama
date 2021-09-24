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
    public partial class FacturaA : Form
    {
        bool clienteGen = false;
        bool articulosCargados = false;
        int count = 1;
        string cantidadPagos = "";
        float interes = 1.2f;
        Helpers.Cliente cliente = new Helpers.Cliente();
        List<Helpers.Producto> list = new List<Helpers.Producto>();
        public FacturaA()
        {
            InitializeComponent();
            comboBox2.SelectedItem = "CUIT";
            comboBox3.SelectedItem = "Efectivo";
            Load += FacturaA_Load;
        }

        private void FacturaA_Load(object sender, EventArgs e)
        {
            PrinterFun.ConectarConImpresora();
            progressBar1.Visible = false;
        }
        private void Button_reconectar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reconectar con la impresora?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrinterFun.ConectarConImpresora();
            }
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Reference the Button which was clicked.
            count--;
            Button button = (sender as Button);
            if (count > 1)
            {
                Button buttonDelete = (Button)panel1.Controls.Find("btnDelete_" + (count - 1), true)[0];
                buttonDelete.Enabled = true;
            }
            //Determine the Index of the Button.
            int index = int.Parse(button.Name.Split('_')[1]);

            //Find the TextBox using Index and remove it.
            panel1.Controls.Remove(panel1.Controls.Find("txt_codigo" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("Lbl_nombre" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("txt_cantidad" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("Lbl_totalUnitario" + index, true)[0]);
            panel1.Controls.Remove(panel1.Controls.Find("lbl_totalTotal" + index, true)[0]);
            //Remove the Button.
            panel1.Controls.Remove(button);

            //Rearranging the Location controls.
            foreach (Button btn in panel1.Controls.OfType<Button>())
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]);
                if (controlIndex > index)
                {
                    TextBox txt = (TextBox)panel1.Controls.Find("txt_" + controlIndex, true)[0];
                    btn.Top -= 25;
                    txt.Top -= 25;
                }
            }
        }
        private void BotonSalirA_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion m = new Facturacion();
            m.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            float total = 0;
            float precioParcial = 0;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
            MySqlDataReader rd;
            MySqlCommand cmd;
            string Query;
            con.Open();
            Helpers.Producto producto = new Helpers.Producto();
            for (int i = 1; i < count; ++i)
            {
                producto.codigo = int.Parse(((TextBox)panel1.Controls["txt_Codigo" + (i).ToString()]).Text);
                Query = "SELECT * FROM stock.stock WHERE CODIGO=" + producto.codigo.ToString();
                cmd = new MySqlCommand(Query, con);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    int cantidad = rd.GetInt32("CANTID");
                    if(cantidad > 0)
                    {
                        producto.Nombre = rd.GetString("ARTICULO");
                        ((Label)panel1.Controls["Lbl_nombre" + (i).ToString()]).Text = producto.Nombre;
                        producto.cantidad = int.Parse(((TextBox)panel1.Controls["txt_cantidad" + (i).ToString()]).Text);
                        if (comboBox3.GetItemText(comboBox3.SelectedItem) == "Credito")
                        {
                            producto.precioUnitario = float.Parse(rd.GetString("PRETARG"));
                        }
                        else
                        {
                            producto.precioUnitario = float.Parse(rd.GetString("PREPUBCIVA"));
                        }
                        ((Label)panel1.Controls["Lbl_totalUnitario" + (i).ToString()]).Text = producto.precioUnitario.ToString();
                        precioParcial = producto.cantidad * producto.precioUnitario;
                    }
                    else
                    {
                        MessageBox.Show("La cantidad de " + rd.GetString("ARTICULO") + " es 0");
                    }
                        
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
            labelTotalNumA.Text = total.ToString();
             articulosCargados = true;
             if (articulosCargados && clienteGen)
             {
                 botonImprimirA.Enabled = true;
             }
        }
    

        private void BotonAñadirA_Click_1(object sender, EventArgs e)
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
            button.Click += new System.EventHandler(this.BtnDelete_Click);
            panel1.Controls.Add(button);
            if (count > 1)
            {
                Button buttonDelete = (Button)panel1.Controls.Find("btnDelete_" + (count - 1), true)[0];
                buttonDelete.Enabled = false;
            }
            count++;
        }

        private void BotonCliente_Click(object sender, EventArgs e)
        {
            CargarCliente();     
        }
        private void CargarCliente()
        {
            string helper;
            long result;
            cliente.nombre = txtRazonSocial.Text;
            helper = txtCuit.Text;
            bool number = long.TryParse(helper, out result);
            if (number != true)
            {
                MessageBox.Show("En el cuit ingrese solo numeros por favor");

            }
            else
            {
                if ((helper.Length != 11 && label2.Text == "CUIT") || comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("El Cuit no tiene los 11 numeros o no ha elegido la responsabilidad");
                }
                else
                {
                    cliente.documento = Convert.ToInt64(txtCuit.Text);
                    cliente.nombre = txtRazonSocial.Text;
                    cliente.direccion = txtDireccion.Text;
                    string Query = "SELECT * FROM stock.clientes WHERE DOC=" + cliente.documento;
                    MySqlConnection con = Helpers.newCon();
                    con.Open();
                    MySqlDataReader rd = Helpers.readQuery(Query, con);
                    if (!rd.Read())
                    {
                        rd.Close();
                        con.Close();
                        con.Open();
                        string responsabilidad = "Responsable Monotributo";
                        if(comboBox1.GetItemText(comboBox1.SelectedItem) == "IVA Responsable Inscripto")
                        {
                            responsabilidad = "IVA Responsable Inscripto";
                        }
                        Query = "INSERT INTO stock.clientes " + " (NOMBRE, DIRECCION, DOC, RESPONSABILIDAD) " +
                            "VALUES ('" + cliente.nombre + "' ,'" + cliente.direccion + "' , '" + cliente.documento + "' , '" + responsabilidad + "')";
                        Helpers.NonQuery(Query, con);
                        con.Close();
                    }
                    else
                    {
                        rd.Close();
                        con.Close();
                    }
                    
                }
                clienteGen = true;
            }
            if (articulosCargados && clienteGen)
            {
                botonImprimirA.Enabled = true;
            }

        }
        private void BotonImprimirA_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
            MySqlCommand cmd;
            MySqlDataReader rd;            
            PrinterFun.ConectarConImpresora();
            //Printer.EstablecerEncabezado(20, "Muy Importante:\nMaterial electrico sin cambios ni devoluciones\nNo se aceptan cambios pasados los 7 dias\nTelefono: 3513759913")
            string numeroComprobante;
            DateTime date;
            string cuit;
            float monto;
            string combobox3 = comboBox3.GetItemText(comboBox3.SelectedItem);
            string combobox1 = comboBox1.GetItemText(comboBox1.SelectedItem);
            bool clienteCargado = false;
            if(cliente.direccion == "" || cliente.documento == 0 || cliente.nombre == "")
            {
                MessageBox.Show("No ha Guardado el Cliente o se ha olvidado de escribir alguno de los campos, primero guarde el cliente");
            }
            else
            {
                PrinterFun.CargarCliente(combobox1, "CUIT", "IVA Responsable Inscripto", cliente, 1, 3, ref clienteCargado, "CUIT");
                PrinterFun.CargarCliente(combobox1, "CUIT", "Responsable Monotributo", cliente, 4, 3, ref clienteCargado, "CUIT");
                if (clienteCargado != true)
                {
                    MessageBox.Show("No ha cargado el cliente, primero cargue el cliente");
                }
                else
                {
                    PrinterFun.CargaComprobante("FacturaA", "081");
                    cmd = new MySqlCommand("SELECT * FROM stock.factura WHERE IDFACTURAS=2", con);
                    con.Open();
                    rd = cmd.ExecuteReader();
                    if (rd.Read()) {
                        numeroComprobante = rd.GetString("NroComprobante");
                        numeroComprobante = PrinterFun.FacturaNro(numeroComprobante);
                    }
                    cuit = txtCuit.Text;
                    monto = float.Parse(labelTotalNumA.Text);
                    date = DateTime.Now;
                    rd.Close();
                    PrinterFun.ImprimirItems(list, combobox3, interes, cantidadPagos, "FacturaA", cliente);
                    Printer.CerrarComprobante();
                }
            }
            Printer.Desconectar();

        }
        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
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
                    button.Click += new System.EventHandler(this.BtnCuotas_Click);
                    panel2.Controls.Add(button);
                }
            }
        }

        private void BtnCuotas_Click(object sender, EventArgs e)
        {
            cantidadPagos = ((TextBox)panel2.Controls["txt_tarjeta".ToString()]).Text;
        }

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
                comboBox1.SelectedItem = rd.GetString("RESPONSABILIDAD");
            }
            else
            {
                MessageBox.Show("CLIENTE NO ENCONTRADO");
            }
            con.Close();
        }

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
                comboBox1.SelectedItem = rd.GetString("RESPONSABILIDAD");
            }
            else
            {
                MessageBox.Show("CLIENTE NO ENCONTRADO");
            }
            con.Close();
        }
    }
}

