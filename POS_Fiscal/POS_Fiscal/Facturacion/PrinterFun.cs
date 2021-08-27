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
    class PrinterFun
    {
       
        public static void ConectarConImpresora()
        {
            int error;
            //ActiveLog
            error = Printer.ComenzarLog(true);
            MessageBox.Show(PrinterErr.EpsonErrores(error));
            //Configuro Velocidad
            Printer.ConfigurarVelocidad(9600);
            //Configuro Puerto
            Printer.ConfigurarPuerto("0");
            //ConectoImpresora
            error = Printer.Conectar();
            MessageBox.Show("Connect: " + error.ToString());
        }
        public static void CierreX()
        {
            ConectarConImpresora();
            Printer.ImprimirCierreX();
            Printer.Desconectar();
        }
        public static void CierreZ()
        {
            ConectarConImpresora();
            Printer.ImprimirCierreZ();
            Printer.Desconectar();
        }
        public static void CargaComprobante(string factura)
        {
            int comprobante;
            string actualizado;
            string Query = "SELECT * FROM stock.factura WHERE NOMBRE=" + "'" + factura + "'";
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
            MySqlDataReader rd;
            MySqlCommand cmd;
            con.Open();            
            cmd = new MySqlCommand(Query, con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                comprobante = int.Parse(rd.GetString("NROCOMPROBANTE"));
                ++comprobante;
                actualizado = FacturaNro(comprobante.ToString());
                Printer.CargarComprobanteAsociado(rd.GetString("CODIGO") + "-" + rd.GetString("CAJA") + "-" + actualizado);
                con.Close();
                con.Open();
                Query = "UPDATE stock.factura SET NROCOMPROBANTE=" + comprobante.ToString() + " WHERE NOMBRE=" + "'" + factura + "'";
                cmd = new MySqlCommand(Query, con);
                cmd.ExecuteNonQuery();
            }
            rd.Close();
            con.Close();
        }
        public static void CargarCliente(string combo, string combo2, string responsabilidad, Helpers.Cliente cliente, int idresponsabilidad, int documento, ref bool clienteCargado, string tipodoc)
        {
            int error;
            if (combo == responsabilidad && combo2 == tipodoc)
            {
                if (cliente.direccion == null)
                {
                    cliente.direccion = "";
                }
                if (cliente.nombre == null)
                {
                    cliente.nombre = "";
                }
                error = Printer.CargarDatosCliente(cliente.nombre, "", cliente.direccion, "", "", documento, cliente.documento.ToString(), idresponsabilidad);
                clienteCargado = true;
                MessageBox.Show(PrinterErr.EpsonErrores(error));
            }
        }
        public static void ImprimirItems(List<Helpers.Producto> list, string combobox3, float interes, string cantidadPagos, string factura)
        {
            int error;
            int cuotas;
            double monto = 0f;
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
            MySqlCommand cmd;
            con.Open();

            if (list.Count != 0)
            {
                Printer.AbrirComprobante(2);
                if (cantidadPagos != "")
                {
                    cuotas = Convert.ToInt32(cantidadPagos);
                }
                else
                {
                    cuotas = 1;
                }
                for (int i = 0; i < list.Count; ++i)
                {
                    
                    int cantidad = 0;                           
                    cantidad = cantidad - list[i].cantidad;
                    string Query = "UPDATE stock.stock SET CANTID=CANTID-" + list[i].cantidad + " WHERE CODIGO=" + list[i].codigo;
                    cmd = new MySqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    double precio = list[i].precioUnitario;
                    if (combobox3 == "Credito")
                    {
                        precio = precio * interes;
                    }
                    monto = monto + precio;
                    int cantidadVenta = list[i].cantidad;
                    precio = (precio / 1.21f);
                    string preciostring = precio.ToString();
                    string[] valores;
                    valores = preciostring.Split(',');
                    preciostring = valores[0] + "." + valores[1];

                    error = Printer.ImprimirItem(200, list[i].Nombre.ToString(), cantidadVenta.ToString(), preciostring, 5, 0, "", 1, list[i].codigo.ToString(), "", 14);
                    double preciofinal = precio * 1.21f;                      
                    MessageBox.Show(PrinterErr.EpsonErrores(error));
                }
                
                error = Printer.ImprimirSubTotal();
                MessageBox.Show(PrinterErr.EpsonErrores(error));
                if (combobox3 == "Efectivo")
                {
                    error = Printer.CargarPago(200, 8, 1, monto.ToString(), "", "Pago en Efectivo", "", "");
                }
                else
                {
                    if (combobox3 == "Credito")
                    {
                        error = Printer.CargarPago(200, 20, Convert.ToInt32(cantidadPagos), monto.ToString(), "", "Tarjeta de Credito", "", "");
                    }
                }
                con.Close();
            }
            error = Printer.CerrarComprobante();
            MessageBox.Show(PrinterErr.EpsonErrores(error));
            error = Printer.DetenerLog();
            MessageBox.Show(PrinterErr.EpsonErrores(error));
            error = Printer.Desconectar();
            MessageBox.Show(PrinterErr.EpsonErrores(error));
        }
        public static string FacturaNro(string cadena)
        {
            if (cadena.Length == 1)
            {
                cadena = "0000000" + cadena;
            }
            else
            {
                if (cadena.Length == 2)
                {
                    cadena = "000000" + cadena;
                }
                else
                {
                    if (cadena.Length == 3)
                    {
                        cadena = "00000" + cadena;
                    }
                    else
                    {
                        if (cadena.Length == 4)
                        {
                            cadena = "0000" + cadena;
                        }
                        else
                        {
                            if (cadena.Length == 5)
                            {
                                cadena = "000" + cadena;
                            }
                            else
                            {
                                if (cadena.Length == 6)
                                {
                                    cadena = "00" + cadena;
                                }
                                else
                                {
                                    cadena = "0" + cadena;
                                }
                            }
                        }
                    }
                }
            }
            return cadena;
        }

    }
}
