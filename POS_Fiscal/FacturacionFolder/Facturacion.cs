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

namespace Sonirama
{
    public partial class Facturacion : Form
    {
        
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

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventas ven = new Ventas();
            ven.Show();
        }
    }
}