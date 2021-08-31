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
        public struct datos{
            public string NroComprobante;
            public string NombreItem;
            public string Cantidad;
            public float PrecioUnitario;
            public string Codigo;
            public string Fecha;
            public int Doc;
        }
        
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
        public static void CargaComprobante(string factura, string cod)
        {
            int comprobante;
            string actualizado;
            string Query = "SELECT * FROM stock.factura WHERE NOMBRE=" + "'" + factura + "'";
            MySqlConnection con = Helpers.newCon();
            MySqlDataReader rd;
            con.Open();
            rd = Helpers.readQuery(Query, con);
            if (rd.Read())
            {
                comprobante = int.Parse(rd.GetString("NROCOMPROBANTE"));
                ++comprobante;
                actualizado = FacturaNro(comprobante.ToString());
                StringBuilder ultimocomprobante = new StringBuilder();
                Printer.ConsultarNumeroComprobanteUltimo(rd.GetString("CODIGO"), ultimocomprobante, 10);
                string lastcomprobante = ultimocomprobante.ToString();
                string codigo = rd.GetString("CODIGO") + "-" + rd.GetString("CAJA") + "-" + actualizado;
                Printer.CargarComprobanteAsociado(rd.GetString("CODIGO") + "-" + rd.GetString("CAJA") + "-" + actualizado);
                con.Close();
                rd.Close();
                con.Open();
                Query = "UPDATE stock.factura SET NROCOMPROBANTE=" + comprobante.ToString() + " WHERE NOMBRE=" + "'" + factura + "'";
                Helpers.NonQuery(Query, con);
            }
            
            con.Close();

        }
        public static int GuardarComprobante(string factura)
        {
            MySqlConnection con = Helpers.newCon();
            string Query = "";
            string tabla = "";
            StringBuilder sb = new StringBuilder();
            string fecha = "";
            fecha = DateTime.Now.Date.ToString();
            
            int comp = 0;
            con.Open();
            if (factura == "FacturaB")
            {   
                tabla = "stock.ventasb";
            }
            else
            {
                tabla = "stock.ventasa";
            }
            Printer.ConsultarNumeroComprobanteActual(sb, 10);
            comp = Convert.ToInt32(sb.ToString());
            Query = "INSERT INTO " + tabla + " (NROCOMPROBANTE, NOMBREITEM, CANTIDAD, PRECIOUNITARIO, FECHA, CODIGO, DOC) VALUES ('" + comp + "', 'ejemplo', '1', '1', '" + fecha.ToString() + "', '1', '1')";
            Helpers.NonQuery(Query, con);
            con.Close();
            return comp;
        }
        public static int idsearch(string stock)
        {
            MySqlConnection con = Helpers.newCon();
            StringBuilder comprobanteActual = new StringBuilder();
            Printer.ConsultarNumeroComprobanteActual(comprobanteActual, 10);
            int comp = Convert.ToInt32(comprobanteActual.ToString());
            int id = 0;
            string Query = "SELECT * FROM " + stock + " WHERE NROCOMPROBANTE=" + comp;
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            if (rd.Read())
            {
                id = Convert.ToInt32(rd.GetString("idVentas"));
            }
            con.Close();
            return id;
        }

        public static void CargarCliente(string combo, string combo2, string responsabilidad, Helpers.Cliente cliente, int idresponsabilidad, int documento, ref bool clienteCargado, string tipodoc)
        {
            if (combo == responsabilidad && combo2 == tipodoc)
            {               
                Printer.CargarDatosCliente(cliente.nombre, "", cliente.direccion, "", "", documento, cliente.documento.ToString(), idresponsabilidad);
                clienteCargado = true;
            }
        }
        public static void ImprimirItems(List<Helpers.Producto> list, string combobox3, float interes, string cantidadPagos, string factura, Helpers.Cliente cliente)
        {
            int error, cuotas, id = 0;
            double monto = 0f;
            MySqlConnection con = Helpers.newCon();
            bool first = false;
            if (list.Count != 0)
            {
                if (cantidadPagos != "")
                {
                    cuotas = Convert.ToInt32(cantidadPagos);
                }
                else
                {
                    cuotas = 1;
                }
                int comprobante = 0;
                string tabla = "";
                if (factura == "FacturaB")
                {
                    tabla = "stock.ventasb";
                }
                else
                {
                    tabla = "stock.ventasa";
                }
                
                for (int i = 0; i < list.Count; ++i)
                {
                    comprobante = GuardarComprobante(factura);
                    if (!first)
                    {
                        id = idsearch(tabla);
                        first = true;
                    }
                    con.Open();
                    int cantidad = 0;                           
                    cantidad = cantidad - list[i].cantidad;
                    string Query = "UPDATE stock.stock SET CANTID=CANTID-" + list[i].cantidad + " WHERE CODIGO=" + list[i].codigo;
                    Helpers.NonQuery(Query, con);
                    con.Close();
                    Query = "UPDATE " + tabla + " SET NOMBREITEM=" + "'" + list[i].Nombre + "'" + ", CANTIDAD=" + "'" + list[i].cantidad + "'" + ", PRECIOUNITARIO=" + "'" + list[i].precioUnitario + "'" + ", CODIGO=" + "'" + list[i].codigo + "'" + ", DOC=" + "'" + cliente.documento + "'" +  " WHERE idVentas=" + id;
                    con.Open();
                    Helpers.NonQuery(Query, con);
                    con.Close();
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
                    ++id;
                    error = Printer.ImprimirItem(200, list[i].Nombre.ToString(), cantidadVenta.ToString(), preciostring, 5, 0, "", 1, list[i].codigo.ToString(), "", 14);
                    double preciofinal = precio * 1.21f;                      
                    
                }
                con.Close();
                error = Printer.ImprimirSubTotal();
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
                
            }
            Printer.CerrarComprobante();
            Printer.DetenerLog();
            Printer.Desconectar();
        }
        
        public static List<datos> Buscar(string comprobante, string stock)
        {
            List<datos> list = new List<datos>();
            datos dat = new datos();
            int i = 0;
            MySqlConnection con = Helpers.newCon();
            con.Open();
            string Query = "SELECT * FROM " + stock + " WHERE NROCOMPROBANTE=" + comprobante;
            MySqlDataReader rd = Helpers.readQuery(Query,con);
            while (rd.Read())
            {
                ++i;
                dat.PrecioUnitario = rd.GetFloat("PRECIOUNITARIO");
                dat.NroComprobante = comprobante;
                dat.NombreItem = rd.GetString("NOMBREITEM");
                dat.Fecha = rd.GetString("FECHA");
                dat.Codigo = rd.GetString("CODIGO");
                dat.Doc = rd.GetInt32("DOC");
                dat.Cantidad = rd.GetString("CANTIDAD");
                list.Add(dat);
            }
            if(i == 0)
            {
                MessageBox.Show("No se encontro el comprobante");
            }
            return list;
        }
        public static void ImprimirNotaCredito(string factura, List<datos> list, string nombre,string direccion, int doc, string dni, int condicion, int nroCompr,string descripcion)
        {
            ConectarConImpresora();
            string comp = factura.Split('-')[2];

            Printer.CargarComprobanteAsociado(factura);
            Printer.CargarDatosCliente(nombre, "", direccion, "", "", doc, dni, condicion);
            Printer.AbrirComprobante(nroCompr);
            for(int i = 0; i < list.Count; ++i)
            {
                string preciostring = "";
                string[] valores;
                float monto = 0;
                datos dat = list.ElementAt(i);
                float precio = dat.PrecioUnitario;
                precio = (precio / 1.21f);
                valores = precio.ToString().Split(',');
                preciostring = valores[0] + "." + valores[1];
                Printer.ImprimirItem(200, dat.NombreItem, dat.Cantidad, preciostring, 5, 0, "", 1, dat.Codigo, "", 14);
                Printer.ImprimirSubTotal();
                monto = monto + (precio * 1.21f);
                Printer.CargarPago(201, 8, 1, monto.ToString(), "", "Pago en Efectivo", "", "");
            }
            Printer.ImprimirSubTotal();
            Printer.CerrarComprobante();
            Printer.Desconectar();
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
