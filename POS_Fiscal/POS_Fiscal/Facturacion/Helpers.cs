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
    }
}
