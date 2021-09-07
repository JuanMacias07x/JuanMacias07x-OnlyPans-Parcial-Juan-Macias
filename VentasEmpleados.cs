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
    public partial class VentasEmpleados : Form
    {
        public VentasEmpleados()
        {
            InitializeComponent();
        }

        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
