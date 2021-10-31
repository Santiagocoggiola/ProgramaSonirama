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
namespace Sonirama
{
    class Proveedor
    {
        public static void provAlta(Helpers.Proveedor prov)
        {
            if(prov.nombre != "" && prov.cuit != "")
            {
                string Query = "INSERT INTO stock.prov (NOMBRE, ENCARGADO, DIRECCION, CIUDAD, PROVINCIA, CODIPOS, TELEDISC, TELEFONO, PRODUCTOS, CUIT) VALUES " +
                    "('" + prov.nombre + "', '"  + prov.encargado + "', '" + prov.direccion + "', '" + prov.ciudad + "', '" + prov.provincia + "', '" + prov.codPos + "', '" + prov.carac + "', '" + 
                    prov.telefono + "', '" + prov.productos + "', '" + prov.cuit + "')";
                MySqlConnection con = Helpers.newCon();
                con.Open();
                Helpers.NonQuery(Query, con);
                MessageBox.Show("Proveedor Cargado");
            }
            else
            {
                MessageBox.Show("Error: No ha ingresado el nombre o el cuit");
            }
        }
        public static void provMod(Helpers.Proveedor prov)
        {
            if (prov.carac != "" && prov.ciudad != "" && prov.codPos != "" && prov.cuit != "" && prov.direccion != "" && prov.encargado != "" 
                && prov.nombre != "" && prov.productos != "" && prov.provincia != "" && prov.telefono != "")
            {
                string Query = "UPDATE stock.prov SET NOMBRE='" + prov.nombre + "', ENCARGADO='"+ prov.encargado + "', DIRECCION='" + prov.direccion + "', CIUDAD='" + prov.ciudad + "', PROVINCIA='"
                    + prov.provincia + "', CODIPOS='" + prov.codPos + "', TELEDISC='" + prov.carac + "', TELEFONO='" + prov.telefono + "', PRODUCTOS= '"
                    + prov.productos + "', CUIT='" + prov.cuit + "' WHERE NUMPRO=" + "'" + prov.numProv + "'";
                MySqlConnection con = Helpers.newCon();
                con.Open();
                Helpers.NonQuery(Query, con);
                con.Close();
                MessageBox.Show("Proveedor Actualizado");
            }
            else
            {
                MessageBox.Show("Por favor rellene todos los campos.");
            }
                
            
        }
        public static void provBorrar(int numeroProv)
        {
            string Query = "DELETE FROM stock.prov WHERE NUMPRO=" + numeroProv;
            MySqlConnection con = Helpers.newCon();
            con.Open();
            Helpers.NonQuery(Query, con);
            con.Close();
            MessageBox.Show("Proveedor Eliminado");
        }
        public static Helpers.Proveedor provConsulta(int numeroProv)
        {
            Helpers.Proveedor prov = new Helpers.Proveedor();
            if(numeroProv != 0)
            {
                string Query = "SELECT * FROM stock.prov WHERE NUMPRO=" + numeroProv;
                MySqlConnection con = Helpers.newCon();
                con.Open();
                MySqlDataReader rd = Helpers.readQuery(Query, con);
                if (rd.Read())
                {
                    prov.carac = rd.GetString("TELEDISC");
                    prov.ciudad = rd.GetString("CIUDAD");
                    prov.codPos = rd.GetString("CODIPOS");
                    prov.cuit = rd.GetString("CUIT");
                    prov.direccion = rd.GetString("DIRECCION");
                    prov.encargado = rd.GetString("ENCARGADO");
                    prov.nombre = rd.GetString("NOMBRE");
                    prov.productos = rd.GetString("PRODUCTOS");
                    prov.provincia = rd.GetString("PROVINCIA");
                    prov.telefono = rd.GetString("TELEFONO");
                    prov.numProv = numeroProv;
                }
                else
                {
                    MessageBox.Show("Numero Proveedor No encontrado");
                }
                rd.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("Error no ingreso el numero de proveedor");
            }
            return prov;
        }
        public static List<Helpers.Proveedor> provListado()
        {
            List<Helpers.Proveedor> listProv = new List<Helpers.Proveedor>();
            Helpers.Proveedor prov = new Helpers.Proveedor();
            string Query = "SELECT * FROM stock.prov";
            MySqlConnection con = Helpers.newCon();
            con.Open();
            MySqlDataReader rd = Helpers.readQuery(Query, con);
            while (rd.Read())
            {
                prov.carac = rd.GetString("TELEDISC");
                prov.ciudad = rd.GetString("CIUDAD");
                prov.codPos = rd.GetString("CODIPOS");
                prov.cuit = rd.GetString("CUIT");
                prov.direccion = rd.GetString("DIRECCION");
                prov.encargado = rd.GetString("ENCARGADO");
                prov.nombre = rd.GetString("NOMBRE");
                prov.productos = rd.GetString("PRODUCTOS");
                prov.provincia = rd.GetString("PROVINCIA");
                prov.telefono = rd.GetString("TELEFONO");
                prov.numProv = rd.GetInt32("NUMPRO");
                listProv.Add(prov);
            }
            rd.Close(); 
            con.Close();
            
            return listProv;
        }

    }
}
