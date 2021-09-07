using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
                    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cantidad = 0.0;
            string panes = "";

            panes = tBNombre.Text + "con identificación:" + TbId.Text + "compró" + "\r\n" ;

            cantidad = Convert.ToDouble(tBcantidad.Text);

            if (chBpa.Checked == true)
            {
                cantidad = cantidad * 1000.0 ;
                panes = "Ha comprado" + cantidad + "de pan" + "\r\n";

            }
            if (chBpn.Checked == true)
            {
                cantidad = cantidad * 500.0 ;
                panes = "Ha comprado" + cantidad + "de pan" + "\r\n";
            }
            if (chBpe.Checked == true)
            {
                cantidad = cantidad * 2000.0 ;
                panes = "Ha comprado" + cantidad + "de pan" + "\r\n";
            }

            panes = tBNombre.Text + " , con identificación: " + TbId.Text + " . Compró $ " + cantidad + " de pan " 
                + " .El día " + Dtpfecha.Text + "\r\n";
            tBVentasP.Text = panes;
   

           
        }

        
    }
}
