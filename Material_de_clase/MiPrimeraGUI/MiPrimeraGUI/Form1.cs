using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraGUI
{
    public partial class Form1 : Form
    {
        private const string User = "Alexis";
        private const string Pass = "hola123.,";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hola mundo desde Windows Forms";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = TB1.Text;
            string pass = TB2.Text;

            if (user.Equals(User) && pass.Equals(Pass))
                MessageBox.Show("Acceso correcto.");
            else
                MessageBox.Show("Usuario o contraseña incorrectos.");
        }
    }
}
