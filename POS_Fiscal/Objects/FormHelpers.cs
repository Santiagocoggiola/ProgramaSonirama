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

namespace Sonirama.Objects
{
    class FormHelpers
    {
        //Instancia el Panel de campos para llenar la factura
        public static Panel PanelFactura(Panel panelFact, int count)
        {
            //Create the dynamic TextBox.
            TextBox codigo = new TextBox();

            codigo.Location = new System.Drawing.Point(8, 25 * count);
            codigo.Size = new System.Drawing.Size(50, 20);
            codigo.Name = "txt_codigo" + (count);
            panelFact.Controls.Add(codigo);

            TextBox digito = new TextBox();
            digito.Location = new System.Drawing.Point(75, 25 * count);
            digito.Size = new System.Drawing.Size(20, 20);
            digito.Name = "txt_digito" + (count);
            panelFact.Controls.Add(digito);

            Label nombre = new Label();
            nombre.Location = new System.Drawing.Point(134, 25 * count);
            nombre.Size = new System.Drawing.Size(260, 20);
            nombre.Name = "Lbl_nombre" + (count);
            panelFact.Controls.Add(nombre);

            TextBox cantidad = new TextBox();
            cantidad.Location = new System.Drawing.Point(528, 25 * count);
            cantidad.Size = new System.Drawing.Size(40, 20);
            cantidad.Name = "txt_cantidad" + (count);
            panelFact.Controls.Add(cantidad);

            Label totalUnitario = new Label();
            totalUnitario.Location = new System.Drawing.Point(649, 25 * count);
            totalUnitario.Size = new System.Drawing.Size(50, 20);
            totalUnitario.Name = "Lbl_totalUnitario" + (count);
            panelFact.Controls.Add(totalUnitario);

            Label totalTotal = new Label();
            totalTotal.Location = new System.Drawing.Point(742, 25 * count);
            totalTotal.Size = new System.Drawing.Size(50, 20);
            totalTotal.Name = "lbl_totalTotal" + (count);
            panelFact.Controls.Add(totalTotal);

            //Create the dynamic Button to remove the TextBox.
            Button button = new Button();
            button.Location = new System.Drawing.Point(800, 25 * count);
            button.Size = new System.Drawing.Size(60, 30);
            button.Font = new Font(button.Font, FontStyle.Bold);
            button.Name = "btnDelete_" + (count);
            button.Text = "Quitar";
            button.BackColor = Color.Salmon;
            button.Font = new Font(button.Font, FontStyle.Bold);
            panelFact.Controls.Add(button);
            if (count > 1)
            {
                Button buttonDelete = (Button)panelFact.Controls.Find("btnDelete_" + (count), true)[0];
                buttonDelete.Enabled = false;
            }

            return panelFact;
        }
        public static void DeleteFromPanel(Panel panelFact, object sender, int count)
        {
            Button button = (sender as Button);
            if (count > 1)
            {
                Button buttonDelete = (Button)panelFact.Controls.Find("btnDelete_" + (count - 1), true)[0];
                buttonDelete.Enabled = true;
            }
            //Determine the Index of the Button.
            int index = int.Parse(button.Name.Split('_')[1]);

            //Find the TextBox using Index and remove it.
            panelFact.Controls.Remove(panelFact.Controls.Find("txt_digito" + index, true)[0]);
            panelFact.Controls.Remove(panelFact.Controls.Find("txt_codigo" + index, true)[0]);
            panelFact.Controls.Remove(panelFact.Controls.Find("Lbl_nombre" + index, true)[0]);
            panelFact.Controls.Remove(panelFact.Controls.Find("txt_cantidad" + index, true)[0]);
            panelFact.Controls.Remove(panelFact.Controls.Find("Lbl_totalUnitario" + index, true)[0]);
            panelFact.Controls.Remove(panelFact.Controls.Find("lbl_totalTotal" + index, true)[0]);
            //Remove the Button.
            panelFact.Controls.Remove(button);

            //Rearranging the Location controls.
            foreach (Button btn in panelFact.Controls.OfType<Button>())
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]);
                if (controlIndex > index)
                {
                    TextBox txt = (TextBox)panelFact.Controls.Find("txt_" + controlIndex, true)[0];
                    btn.Top -= 25;
                    txt.Top -= 25;
                }
            }

        }
        public static Panel PanelTipoPago(Panel panelPago, string combo)
        {
            
            if (combo == "Efectivo")
            {
                if (panelPago.Controls.Count != 0)
                {
                    panelPago.Controls.Remove(panelPago.Controls.Find("txt_tarjeta", true)[0]);
                    panelPago.Controls.Remove(panelPago.Controls.Find("BtnCuotas", true)[0]);
                }
            }
            else
            {
                if (combo == "Credito")
                {
                    TextBox tarjeta = new TextBox();
                    tarjeta.Location = new System.Drawing.Point(0, 0);
                    tarjeta.Size = new System.Drawing.Size(50, 20);
                    tarjeta.Name = "txt_tarjeta";
                    panelPago.Controls.Add(tarjeta);

                    Button button = new Button();
                    button.Location = new System.Drawing.Point(0, 25);
                    button.Size = new System.Drawing.Size(60, 20);
                    button.Name = "BtnCuotas";
                    button.BackColor = Color.PowderBlue;
                    button.Text = "Agregar Cuotas";
                    panelPago.Controls.Add(button);
                }
            }
            return panelPago;
        }
    }
}
