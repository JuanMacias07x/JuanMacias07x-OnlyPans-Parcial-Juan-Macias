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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnCerrarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rtbAdmin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAbrirrtxAdmin_Click(object sender, EventArgs e)
        {
            {

                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Documento de texto|*.txt";
                abrir.Title = "Abrir RtB";
                abrir.FileName = "Sin título 1";
                var resultado = abrir.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    StreamReader leer = new StreamReader(abrir.FileName);

                    rtbAdmin.Text = leer.ReadToEnd();

                    leer.Close();
                }
            }
        }
    }
}
