using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace POS_Fiscal
{
    public partial class Facturacion : Form
    {
        public struct ventas
        {
            public string nroComprobante;
            public float precioTotal;
            public string fecha;
            public int CUIT;
        }
        public Facturacion()
        {
            InitializeComponent();
        }

        private void botonFacturaB_Click(object sender, EventArgs e)
        {
            Hide();
            FacturaB fb = new FacturaB();
            fb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FacturaA fa = new FacturaA();
            fa.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            Hide();
            mp.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Imprimir El Cierre Z?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrinterFun.CierreZ();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Imprimir El Cierre X?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PrinterFun.CierreZ();
            }
        }
        private void crear_directorios()
        {
            int error = 0;
            PrinterFun.ConectarConImpresora();
            string pathMaster = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + " \\AFIP";
            if (!Directory.Exists(pathMaster))
            {
                
                DirectoryInfo di = Directory.CreateDirectory(pathMaster);
                string year = DateTime.Now.Year.ToString();
                string pathYear = pathMaster + "\\" + year;
                if (!Directory.Exists(pathYear))
                {
                    DirectoryInfo yi = Directory.CreateDirectory(pathYear);
                    string month = DateTime.Now.Month.ToString();
                    string pathMonth = pathYear + "\\" + month;
                    if (!Directory.Exists(pathMonth))
                    {
                        DirectoryInfo mi = Directory.CreateDirectory(pathMonth);
                        //error = Printer.DescargarPeriodoPendiente(pathMonth);
                        error = Printer.DescargarPeriodoPendiente(pathMonth);
                    }
                    else
                    {
                        error = Printer.DescargarPeriodoPendiente(pathMonth);
                    }
                    MessageBox.Show(error.ToString());
                }
            }
            else
            {
                string year = DateTime.Now.Year.ToString();
                string pathYear = pathMaster + "\\" + year;
                if (!Directory.Exists(pathYear))
                {
                    DirectoryInfo yi = Directory.CreateDirectory(pathYear);
                    string month = DateTime.Now.Month.ToString();
                    string pathMonth = pathYear + "\\" + month;
                    if (!Directory.Exists(pathMonth))
                    {
                        DirectoryInfo mi = Directory.CreateDirectory(pathMonth);
                        error = Printer.DescargarPeriodoPendiente(pathMonth);
                    }
                    else
                    {
                        error = Printer.DescargarPeriodoPendiente(pathMonth);
                    }
                }
                else
                {
                    string month = DateTime.Now.Month.ToString();
                    string pathMonth = pathYear + "\\" + month;
                    if (!Directory.Exists(pathMonth))
                    {
                        DirectoryInfo mi = Directory.CreateDirectory(pathMonth);
                        
                        error = Printer.DescargarPeriodoPendiente(pathMonth);
                    }
                    else
                    {
                        error = Printer.DescargarPeriodoPendiente(pathMonth);
                    }
                }
            }
            MessageBox.Show(error.ToString());
            Printer.Desconectar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            crear_directorios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotaCreditoB nota = new NotaCreditoB();
            this.Hide();
            nota.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotaCreditoA na = new NotaCreditoA();
            this.Hide();
            na.Show();
        }
        public void imprimirComprobante(string tabla2)
        {
            List<ventas> list = new List<ventas>();
            ventas ventas = new ventas();
            string date = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " 0:00:00";
            MySqlConnection con = Helpers.newCon();
            string Query = "SELECT * FROM " + tabla2 + " WHERE FECHA=" + date;
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            while (rd.Read())
            {
                ventas.nroComprobante = rd.GetString("NROCOMPROBANTE");
                ventas.precioTotal = rd.GetFloat("MONTOTOTAL");
                ventas.fecha = rd.GetString("FECHA");
                ventas.CUIT = rd.GetInt32("DOC");
                list.Add(ventas);
            }
            PrintDocument print = new PrintDocument();
           // print.PrinterSettings


        }   
        public void sumarPorComprobante(string tabla, string tabla2)
        {
            List<ventas> list = new List<ventas>();
            ventas ventas = new ventas();
            MySqlConnection con = Helpers.newCon();
            string Query = "SELECT * FROM " + tabla;
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            
            if (rd.Read()){
                ventas.nroComprobante = rd.GetString("NROCOMPROBANTE");
                ventas.CUIT = rd.GetInt32("DOC");
                ventas.fecha = rd.GetString("FECHA");
                ventas.precioTotal = rd.GetFloat("PRECIOUNITARIO");
            }
            while (rd.Read())
            {
                ventas aux = new ventas();
                aux.nroComprobante = rd.GetString("NROCOMPROBANTE");
                aux.CUIT = rd.GetInt32("DOC");
                aux.fecha = rd.GetString("FECHA");
                aux.precioTotal = rd.GetFloat("PRECIOUNITARIO");
                if (ventas.nroComprobante != aux.nroComprobante)
                {
                    list.Add(ventas);
                    ventas = aux;
                }
                else
                {
                    ventas.precioTotal = ventas.precioTotal + aux.precioTotal;
                }
            }
            list.Add(ventas);
            rd.Close();
            con.Close();
            con.Open();
            
            
            for (int i = 0; i < list.Count; ++i)
            {
                Query = "SELECT * FROM " + tabla2 + " WHERE NROCOMPROBANTE=" + list[i].nroComprobante;
                rd = Helpers.readQuery(Query, con);
                if (rd.Read())
                {
                    list.RemoveAt(i);
                }
                rd.Close();
            }
            con.Close();
            for (int i = 0; i < list.Count; ++i)
            {
                con.Open();
                Query = "INSERT INTO " + tabla2 + " (NROCOMPROBANTE, MONTOTOTAL,FECHA, DOC) VALUES ('" + list[i].nroComprobante + "' , '" + list[i].precioTotal + "' , '" + list[i].fecha + "' , '" + list[i].CUIT + "')";
                Helpers.NonQuery(Query, con);
                con.Close();
            }
            
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Imprimir Las Ventas Diarias?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sumarPorComprobante("stock.ventasb", "stock.ventasbtotales");
                sumarPorComprobante("stock.ventasa", "stock.ventasatotales");
            } 
        }
    }
}
