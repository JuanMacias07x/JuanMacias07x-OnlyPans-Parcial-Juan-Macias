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
            double cantidadpa = 0.0;
            double cantidadpn = 0.0;
            double cantidadpe = 0.0;
            string panes = "";


            cantidad = Convert.ToDouble(tBcantidad.Text);
            cantidadpa = Convert.ToDouble(tBcantidad.Text);
            cantidadpn = Convert.ToDouble(tBcantidad.Text);
            cantidadpe = Convert.ToDouble(tBcantidad.Text);

            if (chBpa.Checked == true)
            {
                cantidadpa = cantidad * 1000.0 ;
                panes = " Ha llevado $" + cantidadpa + " de pan aliñado " + "\r\n";

            }
            if (chBpn.Checked == true)
            {
                cantidadpn = cantidad * 500.0 ;
                panes = " Ha llevado " + cantidadpn + " de pan no aliñado " +  "\r\n";
            }
            if (chBpe.Checked == true)
            {
                cantidadpe = cantidad * 2000.0 ;
                panes = " Ha llevado " + cantidadpe + " de pan especial " +  "\r\n";
            }

            panes = "La persona: " + tBNombre.Text + " con identificación: " + TbId.Text + " compró " + "\r\n";
            tBVentasP.Text = panes;
   

           
        }

        
    }
}
