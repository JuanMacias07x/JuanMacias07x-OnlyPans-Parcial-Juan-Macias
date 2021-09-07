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
    public partial class OnlyPans : Form
    {
        public OnlyPans()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bntIngresar_Click(object sender, EventArgs e)
        {
            if (this.tBUser.Text == "empleado" && this.tBPssw.Text == "1234")
            {
                Empleados llamar = new Empleados();
                llamar.ShowDialog();
            }
            
            if (this.tBUser.Text == "admin" && this.tBPssw.Text == "admin")
            {
                Admin entrar = new Admin();
                entrar.ShowDialog();
            }
            {
                
            }
        }
    }
}
