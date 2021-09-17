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
            public int CUIT;
        }
        static string fecha = "";
        static string mesAño = "";
        static string año = "";
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
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }
        private static void Imprimir(object sender, PrintPageEventArgs e)
        {
            ImprimirVentasAux(sender, e, "stock.ventasbtotales", "FACTURA B");
            ImprimirVentasAux(sender, e, "stock.ventasatotales", "FACTURA A");
        }
        private static void ImprimirVentasAux(object sender, PrintPageEventArgs e, string tabla, string factura)
        {
            List<ventas> list = new List<ventas>();
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
                ventas.CUIT = rd.GetInt32("DOC");
                list.Add(ventas);
            }
            if (list.Count > 0)
            {
                Font font = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Point);
                float total = 0;
                int posy = 0;
                int posx = 0;
                e.Graphics.DrawString(factura + " FECHA " + list[0].fecha, font, Brushes.Black, new RectangleF(posx, posy, 200, 50));
                font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point);
                posy += 30;
                for (int i = 0; i < list.Count; ++i)
                {
                    string imprimir = "";
                    imprimir = "COMP " + list[i].nroComprobante + " TOTAL " + list[i].precioTotal;                      
                    total = total + list[i].precioTotal;
                    
                    e.Graphics.DrawString(imprimir, font, Brushes.Black, new RectangleF(posx, posy, 200, 50));
                    posx += 140;
                    if(posx >= 700)
                    {
                        posx = 0;
                        posy += 30; 
                    }
                }
                font = new Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Point);
                string sttotal = "TOTAL: " + total.ToString();
                e.Graphics.DrawString(sttotal, font, Brushes.Black, new RectangleF(0, posy + 30, 200, 50));

                con.Close();
            }
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
            return list;
        }
        public static void sumarPorComprobante(string tabla, string tabla2)
        {
            List<ventas> list = new List<ventas>();
            ventas ventas = new ventas();
            MySqlConnection con = Helpers.newCon();
            string Query = "SELECT * FROM " + tabla;
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);

            if (rd.Read())
            {
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
    }
}
