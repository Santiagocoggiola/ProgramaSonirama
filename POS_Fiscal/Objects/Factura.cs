using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Sonirama.Objects
{
    class Factura
    {
        //Busca en la base de datos los datos de los articulos, luego calcula el precio y devuelve el precio parcial.
        public static Helpers.ProducList generate(int count, Panel panel1, ComboBox comboBox3, 
            Label labelTotalNum, bool clienteGen, Button botonImprimir, List<Helpers.Producto> list)
        {
            Helpers.Producto producto = new Helpers.Producto();
            Helpers.ProducList prodList = new Helpers.ProducList();
            prodList.listProd = new List<Helpers.Producto>();
            prodList.cargado = false;
            float total = 0;
            float precioParcial = 0;
            string Query;
            MySqlDataReader rd;
            MySqlConnection con = Helpers.newCon();
            con.Open();
            for (int i = 1; i < count; ++i)
            {
                TextBox txt_digito = (TextBox)panel1.Controls["txt_digito" + (i).ToString()];
                TextBox txt_codigo = (TextBox)panel1.Controls["txt_codigo" + (i).ToString()];
                if (txt_codigo.Text != "" && txt_digito.Text != "")
                {
                    producto.codigo = int.Parse(((TextBox)panel1.Controls["txt_codigo" + (i).ToString()]).Text);
                    producto.digito = int.Parse(((TextBox)panel1.Controls["txt_digito" + (i).ToString()]).Text);

                    Query = "SELECT * FROM stock.stock WHERE CODIGO=" + producto.codigo.ToString() + " AND DV=" + producto.digito.ToString();

                    rd = Helpers.readQuery(Query, con);
                    if (rd.Read())
                    {
                        int cantidad = rd.GetInt32("CANTID");
                        if (cantidad > 0)
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
                            prodList.cargado = true;
                            prodList.listProd = list;
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
                else
                {
                    MessageBox.Show("Falto ingresar codigo o digito");
                }
                
            }
            con.Close();
            labelTotalNum.Text = total.ToString();
            prodList.cargado = true;
            if (prodList.cargado && clienteGen)
            {
                botonImprimir.Enabled = true;
            }
            return prodList;
        }
        
        //Maneja si se imprime A o B, si factura == A, se hace todo el procedimiento de la A, si es B, el de la B.
        public static void imprimirFactura(string factura, ComboBox comboBoxPago,
            ComboBox comboBoxDoc, ComboBox comboBoxTipo,
            Helpers.Cliente cliente, Button botonImprimir, List<Helpers.Producto> list,
            float interes, string cantidadPagos, Label labelTotalNum, TextBox txtCuit)
        {
            PrinterFun.ConectarConImpresora();
            bool clienteCargado = false;
            string comboboxPago = comboBoxPago.GetItemText(comboBoxPago.SelectedItem);
            string comboboxDoc = comboBoxDoc.GetItemText(comboBoxDoc.SelectedItem);
            string comboboxTipo = comboBoxTipo.GetItemText(comboBoxTipo.SelectedItem);
            // Imprimo Factura B
            if (factura == "B")
            {
                //Para sin documento, si no fue llenado ninguno de los datos, se procede a imprimir sin documento.
                if (cliente.direccion == null)
                {
                    cliente.direccion = "A";
                }
                if (cliente.nombre == null)
                {
                    cliente.nombre = "A";
                }
                if (cliente.documento == 0)
                {
                    cliente.documento = 1;
                }
                //Alguna de las siguientes llamada ocurrira y generara el cliente.
                PrinterFun.CargarCliente(comboboxTipo, comboboxDoc, "Consumidor Final", cliente, 5, 1, ref clienteCargado, "SIN DOCUMENTO");
                PrinterFun.CargarCliente(comboboxTipo, comboboxDoc, "Consumidor Final", cliente, 5, 1, ref clienteCargado, "DNI");
                PrinterFun.CargarCliente(comboboxTipo, comboboxDoc, "Consumidor Final", cliente, 5, 2, ref clienteCargado, "CUIL");
                PrinterFun.CargarCliente(comboboxTipo, comboboxDoc, "Consumidor Final", cliente, 5, 3, ref clienteCargado, "CUIT");
                PrinterFun.CargarCliente(comboboxTipo, comboboxDoc, "IVA Sujeto Exento", cliente, 6, 3, ref clienteCargado, "CUIT");
                //Si no fue cargado el cliente, se genera una interrupcion del procedimiento de impresion.
                if (clienteCargado != true)
                {
                    MessageBox.Show("No ha cargado el cliente, primero cargue el cliente");
                }
                else
                {
                    //Llegado a este punto, se carga el comprobante y se manda a imprimir los items.
                    //Printer.EstablecerEncabezado(20, "Muy Importante:\nMaterial electrico sin cambios ni devoluciones\nNo se aceptan cambios pasados los 7 dias\nTelefono: 3513759913");
                    PrinterFun.CargaComprobante("FacturaB", "082");
                    PrinterFun.ImprimirItems(list, comboboxPago, interes, cantidadPagos, "FacturaB", cliente);
                }
                botonImprimir.Enabled = false;
            }
            else
            {

                //Printer.EstablecerEncabezado(20, "Muy Importante:\nMaterial electrico sin cambios ni devoluciones\nNo se aceptan cambios pasados los 7 dias\nTelefono: 3513759913")
                string cuit;
                float monto;
                if (cliente.direccion == "" || cliente.documento == 0 || cliente.nombre == "")
                {
                    MessageBox.Show("No ha Guardado el Cliente o se ha olvidado de escribir alguno de los campos, primero guarde el cliente");
                }
                else
                {
                    PrinterFun.CargarCliente(comboboxDoc, "CUIT", "IVA Responsable Inscripto", cliente, 1, 3, ref clienteCargado, "CUIT");
                    PrinterFun.CargarCliente(comboboxDoc, "CUIT", "Responsable Monotributo", cliente, 4, 3, ref clienteCargado, "CUIT");
                    if (clienteCargado != true)
                    {
                        MessageBox.Show("No ha cargado el cliente, primero cargue el cliente");
                    }
                    else
                    {
                        PrinterFun.CargaComprobante("FacturaA", "081");
                        cuit = txtCuit.Text;
                        monto = float.Parse(labelTotalNum.Text);
                        PrinterFun.ImprimirItems(list, comboboxPago, interes, cantidadPagos, "FacturaA", cliente);
                    }
                }
            }

        }
       
        //Realiza la carga de cliente, si en la A existe lo trae, si no existe, lo guarda en la base de datos.
        public static Helpers.Cliente cargarCliente(string factura, Helpers.ProducList producList, Helpers.Cliente cliente, 
            Label labelDoc, TextBox txtNombre, TextBox txtDni,TextBox txtDireccion, 
            ComboBox comboBoxDoc,ComboBox comboBoxTipo , Button botonImprimir){
            string helper;
            long result;
            if(factura == "B")
            {
                cliente.nombre = txtNombre.Text;
                helper = txtDni.Text;
                bool number = long.TryParse(helper, out result);
                if (number != true && labelDoc.Text != "SIN DOCUMENTO")
                {
                    MessageBox.Show("En el Campo de dni, cuit y otros ingrese solo numeros por favor");

                }
                else
                {
                    if ((helper.Length != 11 && (labelDoc.Text == "CUIT" || labelDoc.Text == "CUIL")) || comboBoxDoc.SelectedItem == null)
                    {
                        MessageBox.Show("El Cuit no tiene los 11 numeros o no ha elegido el tipo de documento");
                    }
                    else
                    {
                        if ((helper.Length != 8 && labelDoc.Text == "DNI") || comboBoxDoc.SelectedItem == null)
                        {
                            MessageBox.Show("El Dni no tiene los 8 numeros o no ha elegido el tipo de documento");
                        }
                        else
                        {
                            if (labelDoc.Text != "SIN DOCUMENTO")
                            {
                                cliente.documento = Convert.ToInt64(txtDni.Text);
                                cliente.nombre = txtNombre.Text;
                                cliente.direccion = txtDireccion.Text;
                                labelDoc.Text = comboBoxDoc.GetItemText(comboBoxDoc.SelectedItem);

                            }
                        }

                    }
                    cliente.cargado = true;
                }
                if (producList.cargado && cliente.cargado)
                {
                    botonImprimir.Enabled = true;
                }
            }
            else
            {
                cliente.nombre = txtNombre.Text;
                helper = txtDni.Text;
                bool number = long.TryParse(helper, out result);
                if (number != true)
                {
                    MessageBox.Show("En el cuit ingrese solo numeros por favor");

                }
                else
                {
                    if ((helper.Length != 11 && labelDoc.Text == "CUIT") || comboBoxDoc.SelectedItem == null)
                    {
                        MessageBox.Show("El Cuit no tiene los 11 numeros o no ha elegido la responsabilidad");
                    }
                    else
                    {
                        cliente.documento = Convert.ToInt64(txtDni.Text);
                        cliente.nombre = txtNombre.Text;
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
                            if (comboBoxTipo.GetItemText(comboBoxTipo.SelectedItem) == "IVA Responsable Inscripto")
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
                    cliente.cargado = true;
                }
                if (producList.cargado && cliente.cargado)
                {
                    botonImprimir.Enabled = true;
                }
            }
            
            return cliente;
        }
    }
}
