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
    public partial class frmTinta : Form
    {
        public frmTinta()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);

            }

            this.cboColor.SelectedItem = ConsoleColor.DarkRed;
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (ETipoTinta tipo in Enum.GetValues(typeof(ETipoTinta)))
            {
                this.cboTipo.Items.Add(tipo);
            }

            this.cboTipo.SelectedItem = ETipoTinta.Comun;
            this.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
