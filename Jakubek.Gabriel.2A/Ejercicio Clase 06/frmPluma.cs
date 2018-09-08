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
    public partial class frmPluma : Form
    {
        public frmPluma()
        {
            InitializeComponent();

            foreach (EMArca marca in Enum.GetValues(typeof(EMArca)))
            {
                this.cboMarca.Items.Add(marca);
            }
            this.cboMarca.SelectedItem = EMArca.FaberCastell;
            this.cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;




        }

        private void cboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
