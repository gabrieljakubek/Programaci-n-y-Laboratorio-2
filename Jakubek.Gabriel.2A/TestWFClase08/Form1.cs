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
        PaletaColeccion paleta1;
        public Form1()
        {
            paleta1 = 5;
            InitializeComponent();
            this.groupBox1.Text = "Paleta de colores";
            this.textBox1.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
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
            int i = -1;
            string seleccion = "";
            //Tempera auxTemp = new Tempera(5, ConsoleColor.Blue, "Alba");
            frmTempera tempera;
            seleccion = textBox1.SelectedText;

            foreach (string linea in textBox1.Lines)
            {
                if (seleccion == linea)
                {
                    //MessageBox.Show(seleccion + " posision " + i);
                    break;
                }
                i++;
            }
            //auxTemp = paleta1[i];
            tempera = new frmTempera(paleta1[i]);
            DialogResult resultado = tempera.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.paleta1 -= tempera.MiTempera;
                this.textBox1.Text = (string)this.paleta1;
            }
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }

    }
}
