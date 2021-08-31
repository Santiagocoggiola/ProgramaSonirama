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
        }
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
    }
}
