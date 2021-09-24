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
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace POS_Fiscal
{
    public static class Helpers
    {
        public struct Cliente
        {
            public long documento;
            public string nombre;
            public string direccion;
        }
        public struct Producto
        {
            public int codigo;
            public int cantidad;
            public float precioUnitario;
            public string Nombre;
            public int prov;
            public string codProv;
            public int digito;
            public float costo;
        }
        public struct ventas
        {
            public string nroComprobante;
            public float precioTotal;
            public string fecha;
            public string CUIT;
        }
        public struct mensual
        {
            public string desde;
            public string hasta;
            public float ingreso;
            public string fecha;
        }
        static string fecha = "";
        static string mesAño = "";
        static string año = "";
        static int posAct = 0;
        static int y = 0;
        static bool imprimiendoA = false;
        static bool imprimiendoB = true;
        public static void NonQuery(string Query, MySqlConnection con){
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.ExecuteNonQuery();
        }
        public static MySqlConnection newCon()
        {
            MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=daniel8264");
            return connect;
        }
        public static MySqlDataReader readQuery(string Query, MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }
        public static void imprimirComprobante(PrintDocument printDocument1)
        {

            bool imprimirA = imprimirBool("stock.ventasadiarias", fecha);
            bool imprimirB = imprimirBool("stock.ventasbdiarias", fecha);
            if (imprimirA || imprimirB )
            {
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += ImprimirDiario;
                printDocument1.Print();
            }
        }
        public static void imprimirMes(PrintDocument printDocument1)
        {
            bool imprimirA = imprimirBool("stock.ventasamensual", mesAño);
            bool imprimirB = imprimirBool("stock.ventasbmensual", mesAño);
            if (imprimirA || imprimirB)
            {
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += ImprimirMensual;
                printDocument1.Print();
            }
        }
        private static void ImprimirMensual(object sender, PrintPageEventArgs e)
        {
            List<mensual> listA = new List<mensual>();
            List<mensual> listB = new List<mensual>();
            int x;
            x = 0;
            listA = loadListMensual(listA, "stock.ventasamensual");
            listB = loadListMensual(listB, "stock.ventasbmensual");
            ImprimirMensualAux(sender, e, x, y + 30, listA, listB);
        }
        private static List<mensual> loadListMensual(List<mensual> list, string tabla)
        {
            mensual men = new mensual();
            mesAño = mesAño.Replace("-", "/");
            MySqlConnection con = Helpers.newCon();
            string Query = "SELECT * FROM " + tabla + " WHERE FECHA LIKE " + "'%" + mesAño + "%'";
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            while (rd.Read())
            {
                men.desde = rd.GetString("DESDE");
                men.ingreso = rd.GetFloat("INGRESOS");
                men.fecha = rd.GetString("FECHA");
                men.hasta = rd.GetString("HASTA");
                list.Add(men);
            }
            return list;
        }
        private static void ImprimirMensualAux(object sender, PrintPageEventArgs e, int x, int y, List<mensual> listA, List<mensual> listB)
        {
            float totalA = 0;
            float totalB = 0;
            string sttotal;
            float total = 0;
            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            e.Graphics.DrawString("FECHA " + listB[0].fecha, font, Brushes.Black, new RectangleF(x, y, 250, 50));
            y += 20;
            if (listB.Count > 0 && !imprimiendoA)
            {
                font = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString("LISTADO DE VENTAS FACTURAS TIPO B", font, Brushes.Black, new RectangleF(x, y, 150, 50));
                y += 20;
                font = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                y += 40;
                for (int i = posAct; i < listB.Count; ++i)
                {
                    if (y >= 1100)
                    {
                        imprimiendoA = false;
                        imprimiendoB = true;
                        e.HasMorePages = true;
                        y = 0;
                        posAct = i;
                        return;
                    }
                    string imprimir = "";
                    imprimir = "-----------------------------------------------------------------" +
                        "-----------------------------------" +
                        "-------------------------------" +
                        "------------------------------" +
                        "-" +
                        "----" +
                        "----------------------------------------------------";
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(0, y, 700, 20));
                    totalB = totalB + listB[i].ingreso;
                    y += 25;
                    string fecha = listB[i].fecha.Split('/')[0] + "/" +listB[i].fecha.Split('/')[1];
                    imprimir = "FECHA: " + fecha;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    y += 25;
                    imprimir = "SUBTOTAL DIARIO:          " + listB[i].ingreso;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    x += 210;
                    imprimir = "SUBTOTAL ACUMULADO:       " + totalB;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    y += 25;
                    x = 0;
                    imprimir = "DESDE FRA. Nro:        " + listB[i].desde;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    x += 210;
                    imprimir = "HASTA FRA. Nro:        " + listB[i].hasta;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 50));
                    x = 0;
                    y += 25;
                }
                //y += 25;
                //font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
               // e.Graphics.DrawString("SUBTOTAL B: " + totalB.ToString(), font, Brushes.Black, new RectangleF(10, y + 20, 200, 50));
            }
            imprimiendoA = true;
            imprimiendoB = false;
            posAct = 0;
            x = 0;
            if(y >= 1100)
            {
                e.HasMorePages = true;
                y = 0;
                return;
            }
            else 
            {
                y += 30;
            }
            
            if (listA.Count > 0 && !imprimiendoB)
            {
                font = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString("LISTADO DE VENTAS FACTURAS TIPO A", font, Brushes.Black, new RectangleF(x, y, 150, 50));
                y += 20;
                font = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                y += 40;
                for (int i = posAct; i < listA.Count; ++i)
                {
                    if (y >= 1100)
                    {
                        imprimiendoA = true;
                        imprimiendoB = false;
                        e.HasMorePages = true;
                        y = 0;
                        posAct = i;
                        return;
                    }
                    string imprimir = "";
                    imprimir = "-----------------------------------------------------------------" +
                        "-----------------------------------" +
                        "-------------------------------" +
                        "------------------------------" +
                        "-" +
                        "----" +
                        "----------------------------------------------------";
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(0, y, 700, 20));
                    totalB = totalB + listB[i].ingreso;
                    y += 25;
                    string fecha = listB[i].fecha.Split('/')[0] + "/" + listB[i].fecha.Split('/')[1];
                    imprimir = "FECHA: " + fecha;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    y += 25;
                    imprimir = "SUBTOTAL DIARIO:          " + listB[i].ingreso;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    x += 210;
                    imprimir = "SUBTOTAL ACUMULADO:       " + totalB;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    y += 25;
                    x = 0;
                    imprimir = "DESDE FRA. Nro:        " + listB[i].desde;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 20));
                    x += 210;
                    imprimir = "HASTA FRA. Nro:        " + listB[i].hasta;
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 200, 50));
                    x = 0;
                    y += 25;
                }
                //y += 25;
                //font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                // e.Graphics.DrawString("SUBTOTAL B: " + totalB.ToString(), font, Brushes.Black, new RectangleF(10, y + 20, 200, 50));
            }
            posAct = 0;
            y = 0;
            imprimiendoA = false;
            imprimiendoB = true;
            listA.Clear();
            listB.Clear();
        }
        private static void ImprimirDiario(object sender, PrintPageEventArgs e)
        {
            List<ventas> listA = new List<ventas>();
            List<ventas> listB = new List<ventas>();
            int x;
            x = 0;
            y = 0;
            listA = loadListDiario(listA, "stock.ventasadiarias");
            listB = loadListDiario(listB, "stock.ventasbdiarias");
            ImprimirVentasAux(sender, e , x, y + 30, listA, listB);
        }

        private static List<ventas> loadListDiario(List<ventas> list, string tabla)
        {
            ventas ventas = new ventas();
            fecha = fecha.Replace("-", "/");
            MySqlConnection con = Helpers.newCon();
            string Query = "SELECT * FROM " + tabla + " WHERE FECHA LIKE " + "'%" + fecha + "%'";
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            while (rd.Read())
            {
                ventas.nroComprobante = rd.GetString("NROCOMPROBANTE");
                ventas.precioTotal = rd.GetFloat("MONTOTOTAL");
                ventas.fecha = rd.GetString("FECHA");
                ventas.CUIT = rd.GetString("DOC");
                list.Add(ventas);
            }
            return list;
        }
        private static bool imprimirBool(string tabla, string value)
        {
            bool imprimir = false;
            value = value.Replace("-", "/");
            MySqlConnection con = Helpers.newCon();
            string Query = "SELECT * FROM " + tabla + " WHERE FECHA LIKE " + "'%" + value + "%'";
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            while (rd.Read())
            {
                imprimir = true;
            }
            con.Close();
            return imprimir;
        }
        private static void ImprimirVentasAux(object sender, PrintPageEventArgs e,  int x, int y, List<ventas> listA, List<ventas> listB)
        {
            float totalA = 0;
            float totalB = 0;
            string sttotal;
            float total = 0;
            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            e.Graphics.DrawString("FECHA " + listB[0].fecha, font, Brushes.Black, new RectangleF(x, y, 250, 50));
            y += 20;
            if (listB.Count > 0 && !imprimiendoA)
            {
                font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString("Factura B", font, Brushes.Black, new RectangleF(x, y, 100, 50));
                y += 20;
                font = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                y += 40;
                for (int i = posAct; i < listB.Count; ++i)
                {
                    if(y >= 1100)
                    {
                        imprimiendoA = false;
                        imprimiendoB = true;
                        e.HasMorePages = true;
                        y = 0;
                        posAct = i;
                        return;
                    }
                    string imprimir = "";
                    imprimir = "COMP " + listB[i].nroComprobante + " TOTAL " + listB[i].precioTotal;                      
                    totalB = totalB + listB[i].precioTotal;
                    
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 100, 50));
                    x += 110;
                    if(x >= 700)
                    {
                        x = 0;
                        y += 40; 
                    }
                }
                y += 30;
                font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString("SUBTOTAL B: " + totalB.ToString() , font, Brushes.Black, new RectangleF(10, y+20, 200, 50));
            }
            imprimiendoA = true;
            imprimiendoB = false;
            posAct = 0;
            x = 0;
            if (y >= 1100)
            {
                e.HasMorePages = true;
                y = 0;
                return;
            }
            else
            {
                y += 30;
            }
            if (listA.Count > 0 && !imprimiendoB)
            {
                y += 20;
                
                font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                e.Graphics.DrawString("Factura A", font, Brushes.Black, new RectangleF(x, y, 200, 50));
                font = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);
                y += 40;
                for (int i = posAct; i < listA.Count; ++i)
                {
                    if(y >= 1100)
                    {
                        imprimiendoB = false;
                        imprimiendoA = true;
                        y = 0;
                        e.HasMorePages = true;
                        posAct = i;
                    }
                    string imprimir = "";
                    imprimir = "COMP " + listA[i].nroComprobante + " TOTAL " + listA[i].precioTotal;
                    totalA = totalA + listA[i].precioTotal;

                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(x, y, 100, 50));
                    x += 110;
                    if (x >= 700)
                    {
                        x = 0;
                        y += 40;
                    }
                }
                font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                sttotal = "SUBTOTAL A: " + totalA.ToString();
                e.Graphics.DrawString(sttotal, font, Brushes.Black, new RectangleF(10 , y + 40, 200, 50)); 
            }
            y += 30;
            total = totalA + totalB;
            sttotal = "TOTAL: " + total.ToString();
            e.Graphics.DrawString(sttotal, font, Brushes.Black, new RectangleF(0, y + 30, 200, 50));
            imprimiendoA = false;
            imprimiendoB = true;
            posAct = 0;
            y = 0;
            listA.Clear();
            listB.Clear();
        }

        public static List<Producto> BusquedaStock(List<Producto> list, string searchBy)
        {
            MySqlConnection con = newCon();
            string Query = "SELECT * FROM stock.stock WHERE " + searchBy;
            con.Open();
            MySqlDataReader rd = readQuery(Query, con);
            Producto p = new Producto();
            while (rd.Read())
            {
                p.cantidad = rd.GetInt32("CANTID");
                p.codigo = rd.GetInt32("CODIGO");
                p.digito = rd.GetInt16("DV");
                p.Nombre = rd.GetString("ARTICULO");
                p.costo = rd.GetFloat("DOLIS");
                p.codProv = rd.GetString("CODIPROVEE");
                p.prov = rd.GetInt32("PROVEEDOR");
                p.precioUnitario = rd.GetFloat("PREPUBCIVA");
                list.Add(p);
            }
            con.Close();
            return list;
        }
        public static List<CargaIngresos.items> BusquedaFactura(List<CargaIngresos.items> list, string searchBy)
        {
            if(searchBy != "")
            {
                MySqlConnection con = newCon();
                string Query = "SELECT * FROM stock.ingreso_factura_prov WHERE " + searchBy;
                con.Open();
                MySqlDataReader rd = readQuery(Query, con);
                CargaIngresos.items i = new CargaIngresos.items();
                while (rd.Read())
                {
                    i.cantidad = rd.GetInt32("CANTIDAD");
                    i.codigo = rd.GetInt32("CODIGO");
                    bool cambioPrecio = false;
                    if (rd.GetInt32("CAMBIOPRECIO") == 1)
                    {
                        cambioPrecio = true;
                    }
                    i.cambioPrecio = cambioPrecio;
                    i.descuento = rd.GetFloat("DESCUENTO");
                    i.descuento1 = rd.GetFloat("DESC1");
                    i.descuento2 = rd.GetFloat("DES2");
                    i.dolar = rd.GetFloat("DOLAR");
                    i.preciocosto = rd.GetFloat("PRECIOCOSTO");
                    i.preciolista = rd.GetFloat("PRECIOLISTA");
                    i.nombreItem = rd.GetString("NOMBREITEM");
                    i.pack = rd.GetInt32("PACK");
                    i.prov = rd.GetInt32("PROVEEDOR");
                    i.fecha = rd.GetString("FECHA");
                    i.NroFactura = rd.GetString("NROFACTURA");
                    list.Add(i);
                }
                con.Close();
            }
            
            return list;
        }
        public static void sumarPorComprobante(string tabla, string tabla2, string fechaaux)
        {
            fecha = fechaaux;
            List<ventas> list = new List<ventas>();
            ventas ventas = new ventas();
            MySqlConnection con = Helpers.newCon();
            string Query = "SELECT * FROM " + tabla;
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            bool listload = false;
            if (rd.Read())
            {
                ventas.nroComprobante = rd.GetString("NROCOMPROBANTE");
                ventas.CUIT = rd.GetString("DOC");
                ventas.fecha = rd.GetString("FECHA");
                ventas.precioTotal = rd.GetFloat("PRECIOUNITARIO");
                listload = true;
            }
            while (rd.Read())
            {
                ventas aux = new ventas();
                aux.nroComprobante = rd.GetString("NROCOMPROBANTE");
                aux.CUIT = rd.GetString("DOC");
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
            if (listload)
            {
                list.Add(ventas);
            }
            
            rd.Close();
            con.Close();
            con.Open();
            List<ventas> listaux = new List<ventas>();
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].nroComprobante != "")
                {
                    Query = "SELECT * FROM " + tabla2 + " WHERE NROCOMPROBANTE=" + list[i].nroComprobante;
                    rd = Helpers.readQuery(Query, con);
                    if (!rd.Read())
                    {
                        listaux.Add(list.ElementAt(i));
                    }
                    rd.Close();
                }
            }
            con.Close();
            list = listaux;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].nroComprobante != "")
                {
                    con.Open();
                    Query = "INSERT INTO " + tabla2 + " (FECHA, NROCOMPROBANTE, MONTOTOTAL, DOC) VALUES ('" + list[i].fecha + "' ,'" + list[i].nroComprobante + "' , '" + list[i].precioTotal + "' , '" + list[i].CUIT + "')";
                    Helpers.NonQuery(Query, con);
                    con.Close();
                }
            }
            list.Clear();
        }
        public static void sumarMensual(string tabla, string tabla2, string mesaux)
        {
            mesAño = mesaux;
            int mes = int.Parse(mesaux.Split('/')[0]);
            int año = int.Parse(mesaux.Split('/')[1]);
            int dia = 1;

            while (dia < DateTime.DaysInMonth(año, mes))
            {
                string diaS = dia.ToString();
                if (diaS.Length == 1)
                {
                    diaS = "0" + diaS + "/";
                }
                else
                {
                    diaS = diaS + "/";
                }
                string Query = "SELECT * FROM " + tabla2 + " WHERE FECHA LIKE " + "'%" + diaS + mesaux + "%'";
                MySqlConnection con = newCon();
                con.Open();
                MySqlDataReader rd = readQuery(Query, con);
                if(!rd.Read())
                {
                    rd.Close();
                    con.Close();
                    Query = "SELECT * FROM " + tabla + " WHERE FECHA LIKE " + "'%" + diaS + mesaux + "%'";
                    mensual men = new mensual();
                    con.Open();
                    rd = readQuery(Query, con);
                    float total = 0;
                    if (rd.Read())
                    {
                        men.desde = rd.GetString("NROCOMPROBANTE");
                        men.fecha = rd.GetString("FECHA");
                        total = total + rd.GetFloat("MONTOTOTAL");
                        men.ingreso = total;
                        men.hasta = men.desde;
                    }
                    while (rd.Read())
                    {
                        men.ingreso = total + rd.GetFloat("MONTOTOTAL");
                        men.fecha = rd.GetString("FECHA");
                        men.ingreso = total;
                        men.hasta = rd.GetString("NROCOMPROBANTE");
                    }
                    rd.Close();
                    con.Close();
                    con.Open();
                    if (men.fecha != null)
                    {
                        Query = "SELECT * FROM " + tabla2 + " WHERE FECHA=" + men.fecha;
                        rd = Helpers.readQuery(Query, con);
                        if (rd.Read())
                        {
                            rd.Close();
                            con.Close();
                        }
                        else
                        {
                            rd.Close();
                            con.Close();
                            con.Open();
                            Query = "INSERT INTO " + tabla2 + " (DESDE, HASTA, INGRESOS, FECHA) VALUES ('" + men.desde + "' ,'" + men.hasta + "' , '" + men.ingreso + "' , '" + men.fecha + "')";
                            Helpers.NonQuery(Query, con);
                            con.Close();
                        }
                    }
                }
                else
                {
                    rd.Close();
                    con.Close();
                }
                
                ++dia;
            }
            
        }
    }
}
