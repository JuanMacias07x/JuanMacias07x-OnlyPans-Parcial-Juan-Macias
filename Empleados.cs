using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OnlyPans
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnCerrarEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentasEmpleados vender = new VentasEmpleados(rtxbVentasP.Text);

            vender.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            double cantidad = 0.0;
            string panes = "";

            panes = tBNombre.Text + "con identificación:" + TbId.Text + "compró" + "\r\n" ;

            cantidad = Convert.ToDouble(tBcantidad.Text);

            if (rbpa.Checked == true)
            {
                cantidad = cantidad * 1000.0 ;
                panes = "Ha comprado" + cantidad + "de pan" + "\r\n";

            }
            if (rbpn.Checked == true)
            {
                cantidad = cantidad * 500.0 ;
                panes = "Ha comprado" + cantidad + "de pan" + "\r\n";
            }
            if (rbpe.Checked == true)
            {
                cantidad = cantidad * 2000.0 ;
                panes = "Ha comprado" + cantidad + "de pan" + "\r\n";
            }

            panes = tBNombre.Text + ", con identificación: " + TbId.Text + ". Compró $ " + cantidad + " de pan " 
                + " .El día " + Dtpfecha.Text + "\r\n";
            rtxbVentasP.Text = panes;

            { 
               
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Documento de texto|*.txt";
                guardar.Title = "Guardar RtB";
                guardar.FileName = "Sin título 1";
                var resultado = guardar.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    StreamWriter escribir = new StreamWriter(guardar.FileName);
                    foreach (object line in rtxbVentasP.Lines)
                    {
                        escribir.WriteLine(line);
                    }
                    escribir.Close();
                }
            }
           
        }

        public void rtxbVentasP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
