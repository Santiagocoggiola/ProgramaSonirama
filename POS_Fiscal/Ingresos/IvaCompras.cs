using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;
namespace Sonirama
{
    public partial class IvaCompras : Form
    {
        public IvaCompras()
        {
            InitializeComponent();
        }
        public struct IvaCompra
        {
            public string proveedor;
            public string cuitNro;
            public string fecha;
            public string nroFact;
            public float impsiva;
            public float iva;
            public float impciva;
        }
        static IvaCompra comp = new IvaCompra();
        static List<IvaCompra> list = new List<IvaCompra>();
        static int y = 0;
        static int x = 0;
        static int posAct = 0;
        static float totalciva = 0;
        static float totalsiva = 0;
        static float iva21 = 0;
        public static void imprimirIva(PrintDocument printDocument1)
        {
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += ImprimirIvaCompras;
                printDocument1.Print();
        }
        private static void ImprimirIvaCompras(object sender, PrintPageEventArgs e)
        {
            ImprimirMensualAux(sender, e, x, y);
        }

        private static void ImprimirMensualAux(object sender, PrintPageEventArgs e, int x, int y)
        {
            string imprimir = "";
            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            e.Graphics.DrawString("IVA COMPRAS:", font, Brushes.Black, new RectangleF(x, y, 250, 50));
            y += 20;
            {
                font = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString("PROVEEDOR                         CUIT NRO                     FECHA              NRO FAC     IMP.S/IVA      IVA   " +
                    "      IMP.C/IVA", font, Brushes.Black, new RectangleF(x, y, 600, 50));
                font = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                y += 20;
                for (int i = posAct; i < list.Count; ++i)
                {
                    if (y >= 1100)
                    {
                        e.HasMorePages = true;
                        y = 0;
                        posAct = i;
                        return;
                    }
                    imprimir = "";
                    imprimir = "-----------------------------------------------------------------" +
                        "-----------------------------------" +
                        "-------------------------------" +
                        "------------------------------" +
                        "-" +
                        "----" +
                        "----------------------------------------------------";
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(0, y, 700, 20));
                    totalsiva = totalsiva + list[i].impsiva;
                    totalciva = totalciva + list[i].impciva;
                    iva21 = iva21 + list[i].iva;
                    y += 25;
                    string fecha = list[i].fecha.Split('/')[0] + "/" + list[i].fecha.Split('/')[1];
                    imprimir = list[i].proveedor + "                    " + list[i].cuitNro  + "                 " + fecha 
                        + "               " + list[i].nroFact  + "              " 
                        + list[i].impsiva + "         " + list[i].iva + "         " + list[i].impciva;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 600, 20));
                    y += 25;
                }
                font = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                imprimir = "TOT.S/IVA: -->  " + totalsiva + "       IVA: -->  " + iva21 + "      TOT.C/IVA: -->  " + totalciva;
                e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 600, 20));
                //y += 25;
                //font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                // e.Graphics.DrawString("SUBTOTAL B: " + totalB.ToString(), font, Brushes.Black, new RectangleF(10, y + 20, 200, 50));
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Imprimir Iva Compras?", Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(TxtFecha.Text != "")
                {
                    MySqlConnection con = Helpers.newCon();
                    string fecha = TxtFecha.Text;
                    string Query = "SELECT * FROM stock.ingreso_facturas WHERE FECHA LIKE '%" + fecha + "%'";
                    con.Open();
                    MySqlDataReader rd = Helpers.readQuery(Query, con);
                    while (rd.Read())
                    {
                        comp.cuitNro = rd.GetString("CUITNRO");
                        comp.fecha = rd.GetString("FECHA");
                        comp.impciva = rd.GetFloat("IMPCIVA");
                        comp.impsiva = rd.GetFloat("IMPSIVA");
                        comp.iva = rd.GetFloat("IVA");
                        comp.proveedor = rd.GetString("PROVEEDOR");
                        comp.nroFact = rd.GetString("NROFACT");
                        list.Add(comp);
                    }
                    imprimirIva(printDocument1);
                }
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            IngreInterno ing = new IngreInterno();
            ing.Show();
        }
    }
}
