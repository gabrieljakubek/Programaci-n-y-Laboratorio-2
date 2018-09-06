using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase_06
{
    public partial class Form1 : Form
    {
        #region Atributos
        private Ejercicio_Clase_05.Pluma _pluma;
        private Ejercicio_Clase_05.Tinta _tinta;
        #endregion

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTinta form = new frmTinta();
            form.Show();
        }

        private void plumaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
