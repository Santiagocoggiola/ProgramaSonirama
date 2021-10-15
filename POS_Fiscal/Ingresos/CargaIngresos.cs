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
namespace POS_Fiscal
{
    public partial class CargaIngresos : Form
    {
        public struct items
        {
            public int codigo;
            public string nombreItem;
            public int cantidad;
            public float dolar;
            public float preciolista;
            public float preciocosto;
            public float descuento;
            public float descuento1;
            public float descuento2;
            public int pack;
            public bool cambioPrecio;
            public int fila;
            public int prov;
            public string codProv;
            public string fecha;
            public string NroFactura;
        }
        public struct factura
        {
            public string numeroProv;
            public string numeroFactura;
        }
        MySqlConnection con = Helpers.newCon();
        float total = 0f;
        int totalitem = 0;
        factura fac = new factura();
        items item = new items();
        List<items> list = new List<items>(); 
        public CargaIngresos()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            IngreInterno ing = new IngreInterno();
            ing.Show();
            this.Hide();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            string desc = TxtDescuento.Text.Replace(".", ",");
            string desc1 = TxtDescuento1.Text.Replace(".", ",");
            string desc2 = TxtDescuento2.Text.Replace(".", ",");
            string preclis = TxtPrecioLista.Text.Replace(".", ",");
            string dolar = TxtDolar.Text.Replace(".", ",");
            if (TxtDescuento.Text == "")
            {
                item.descuento = 0;
            }
            if(TxtDescuento1.Text == "")
            {
                item.descuento1 = 0;
            }
            if(TxtDescuento2.Text == "")
            {
                item.descuento2 = 0;
            }
            if(TxtPack.Text == "")
            {
                item.pack = 1;
            }
            item.codigo = int.Parse(TxtCodigo.Text);
            item.cantidad = int.Parse(TxtCantidad.Text);
            item.descuento = float.Parse(desc);
            item.descuento1 = float.Parse(desc1);
            item.descuento2 = float.Parse(desc2);
            item.preciolista = float.Parse(preclis);
            string Query = "SELECT * FROM stock.stock WHERE CODIGO=" + item.codigo;
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            if (rd.Read())
            {
                item.nombreItem = rd.GetString("ARTICULO");

            }
            con.Close();
            item.pack = int.Parse(TxtPack.Text);
            item.cambioPrecio = CheckPrecio.Checked;
            item.dolar = float.Parse(dolar);
            string fecha = TxtFecha.Text;
            item.preciocosto = item.preciolista;
            item.preciocosto = (item.preciocosto * (1 - (item.descuento / 100)));
            item.preciocosto = (item.preciocosto * (1 - (item.descuento1 / 100)));
            item.preciocosto = (item.preciocosto * (1 - (item.descuento2 / 100)));
            total = total + (item.preciocosto * item.cantidad);
            item.fila = dataGridView1.Rows.Count-1;
            list.Add(item);
            dataGridView1.Rows.Add(item.codigo, item.nombreItem, item.cantidad, item.preciolista, item.preciocosto, item.descuento, item.descuento1, item.descuento2, item.pack, item.cambioPrecio, total);
            totalitem = totalitem + 1;
            LblCantidadElem.Text = totalitem.ToString();
        }

        private void BtnBorrarTexto_Click(object sender, EventArgs e)
        {
            TxtCodigo.Text = "";
            TxtPrecioLista.Text = "";
            TxtCantidad.Text = "";
        }
        private void BtnCargarFac_Click(object sender, EventArgs e)
        {

            if(TxtNumeroFactura.Text != "" && TxtProveedor.Text != "" 
                && TxtFecha.Text != "" && TxtDolar.Text != "")
            {
                string Query = "";
                string fecha = TxtFecha.Text;
                fac.numeroFactura = TxtNumeroFactura.Text;
                fac.numeroProv = TxtProveedor.Text;
                float impsiva = 0;
                float impciva = 0;
                float ivaaux = 0;
                string nroFact = "";
                string fechaaux = "";
                string cuitNro = "";
                string nroproveedor = "";
                string nombreproveedor = "";
                nroFact = TxtNumeroFactura.Text;
                fechaaux = TxtFecha.Text;
                nroproveedor = TxtProveedor.Text;
                string Query2 = "SELECT * FROM stock.prov WHERE NUMPRO=" + nroproveedor;
                con.Open();
                MySqlDataReader rd2 = Helpers.readQuery(Query2, con);
                if (rd2.Read())
                {
                    cuitNro = rd2.GetString("CUIT");
                    nombreproveedor = rd2.GetString("NOMBRE");
                    for (int i = 0; i < list.Count; ++i)
                    {
                        impsiva = (list[i].preciocosto * list[i].cantidad) + impsiva ;
                    }
                    impciva = impsiva * 1.21f;
                    ivaaux = impciva - impsiva;
                    

                    rd2.Close();
                    Query2 = "INSERT INTO stock.ingreso_facturas (PROVEEDOR, CUITNRO, FECHA, NROFACT, IMPSIVA, IVA, IMPCIVA) " +
                            "VALUES ('" + nombreproveedor + "', " + "'" + cuitNro + "', '" + fechaaux + "', '" + nroFact + "', " + impsiva + ", '" + ivaaux + "', '" + impciva + "')";
                    Helpers.NonQuery(Query2, con);
                    con.Close();
                    for (int i = 0; i < list.Count; ++i)
                    {
                        con.Open();
                        item = list.ElementAt(i);
                        string desc = item.descuento.ToString().Replace(",", ".");
                        string desc1 = item.descuento1.ToString().Replace(",", ".");
                        string desc2 = item.descuento2.ToString().Replace(",", ".");
                        string precioLista = item.preciolista.ToString().Replace(",", ".");
                        string precioCosto = item.preciocosto.ToString().Replace(",", ".");
                        string dolar = item.dolar.ToString().Replace(",", ".");
                        int boolCambio = item.cambioPrecio ? 1 : 0;
                        Query = "INSERT INTO stock.ingreso_factura_prov (PROVEEDOR, FECHA, NROFACTURA, NOMBREITEM, CANTIDAD, PRECIOLISTA, PRECIOCOSTO,  DOLAR, DESCUENTO, DESC1, DES2, PACK, CAMBIOPRECIO, CODIGO) " +
                            "VALUES (" + fac.numeroProv + ", " + "'" + fecha + "', '" + fac.numeroFactura + "', '" + item.nombreItem + "', " + item.cantidad + ", '" + precioLista + "', '" + precioCosto + "', '" + dolar + "', '" + desc + "', '"
                            + desc1 + "', '" + desc2 + "', " + item.pack + ", " + boolCambio + ", " + item.codigo + ")";
                        Helpers.NonQuery(Query, con);
                        con.Close();
                        if (item.cambioPrecio)
                        {
                            float precioPublico = 0;
                            float precioTaller = 0;
                            float precioTarjeta = 0;
                            float margenPublico = 1;
                            float margenTaller = 1;
                            float interes = 0;
                            int cantidad = 0;
                            float iva = 1.21f;

                            Query = "SELECT * FROM stock.tarjeta WHERE IDTARJETA=1";
                            con.Open();
                            MySqlDataReader rd = Helpers.readQuery(Query, con);
                            if (rd.Read())
                            {
                                interes = rd.GetFloat("INTERES");
                            }
                            con.Close();
                            con.Open();
                            Query = "SELECT * FROM stock.stock WHERE CODIGO=" + item.codigo;
                            rd = Helpers.readQuery(Query, con);
                            if (rd.Read())
                            {
                                margenPublico = float.Parse(rd.GetString("MARGEN"));
                                margenTaller = float.Parse(rd.GetString("MARGTAL"));
                                cantidad = rd.GetInt32("CANTID");
                            }
                            precioPublico = (item.preciocosto * (1 + (margenPublico / 100)) * iva) / item.pack;
                            precioTaller = (item.preciocosto * (1 + (margenPublico / 100))) / item.pack;
                            precioTarjeta = precioPublico * interes;
                            con.Close();
                            con.Open();
                            item.cantidad = item.cantidad * item.pack;
                            cantidad = cantidad + item.cantidad;
                            string precioPub = precioPublico.ToString().Replace(",", ".");
                            string precioList = item.preciolista.ToString().Replace(",", ".");
                            string precioTa = precioTaller.ToString().Replace(",", ".");
                            string precioTarj = precioTarjeta.ToString().Replace(",", ".");
                            Query = "UPDATE stock.stock SET PREPUBCIVA=" + "'" + precioPub + "'" + ", DOLAR=" + "'" + precioList + "'" + ", DOLIS=" + "'" + precioCosto + "'" + ", PRETA=" + "'" + precioTa + "'" + ", CANTID=" + cantidad + ", COSDOL='" + dolar + "', PRETARG='" + precioTarj + "' , ULPRO='" + fac.numeroProv + "' WHERE CODIGO=" + item.codigo;
                            Helpers.NonQuery(Query, con);
                            con.Close();
                        }
                    }
                    MessageBox.Show("Factura Cargada en el sistema, verifique que los precios hayan sido modificados");
                }
                else
                {
                    MessageBox.Show("No ha cargado numero de factura o proveedor");
                }
            }
            else
            {
               MessageBox.Show("NUMERO PROVEEDOR NO ENCONTRADO VERIFIQUE");
            } 
        }

        private void BtnBorrarLinea_Click(object sender, EventArgs e)
        {
            items item = new items();
            item.codigo = int.Parse(TxtCodigo.Text);
            int length = list.Count;
            for(int i = 0; i < list.Count; ++i)
            {
                if(list[i].codigo == item.codigo)
                { 
                    dataGridView1.Rows.RemoveAt(list[i].fila);
                    list.RemoveAt(i);
                }
            }
            if(list.Count < length)
            {
                List<items> listaux = new List<items>();
                for (int i = 0; i < list.Count; ++i)
                {
                    item = list.ElementAt(i);
                    item.fila = item.fila - 1;
                    listaux.Add(item);
                }
                list = listaux;
            }
            

        }
    }
}
