using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase07;

namespace TestWFClase08
{
    public partial class Form1 : Form
    {
        Paleta paleta1;
        public Form1()
        {
            paleta1 = 5;
            InitializeComponent();
            this.groupBox1.Text = "Paleta de colores";
            this.textBox1.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera tempera = new frmTempera();
            DialogResult resultado = tempera.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.paleta1 += tempera.MiTempera;
                this.textBox1.Text = (string)this.paleta1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }
    }
}
