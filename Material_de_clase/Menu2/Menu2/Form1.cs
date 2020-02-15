using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Menu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Black;
            label1.Font = new Font("Time New Roman", 20);
        }

        private void ClearColor()
        {
            negroToolStripMenuItem.Checked = false;
            verdeToolStripMenuItem.Checked = false;
            azulToolStripMenuItem.Checked = false;
        }

        private void ClearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void cambiarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = Interaction.InputBox("Ingresa una cadena: ",
                "Cambiar texto");
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fue hecho por Alexis B. López M.");
        }

        private void salirAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Black;
            negroToolStripMenuItem.Checked = true;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Blue;
            azulToolStripMenuItem.Checked = true;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Green;
            verdeToolStripMenuItem.Checked = true;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            label1.Font = new Font("Times new Roman", 20);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            label1.Font = new Font("Arial", 20);
            arialToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            label1.Font = new Font("Comic Sans MS", 20);
            comicSansToolStripMenuItem.Checked = true;
        }
    }
}
