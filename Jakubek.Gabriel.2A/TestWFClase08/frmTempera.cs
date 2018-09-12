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
    public partial class frmTempera : Form
    {
        private Tempera _miTempera;
        public Tempera MiTempera
        {
            get { return this._miTempera; }
        }
        public frmTempera()
        {
            InitializeComponent();
            this.button1.Text = "Aceptar";
            this.button2.Text = "Cancelar";

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox3.Items.Add(color);
            }
            this.comboBox3.SelectedItem = ConsoleColor.DarkCyan;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._miTempera = new Tempera(sbyte.Parse(this.textBoxCantidad.Text), (ConsoleColor)comboBox3.SelectedItem, this.textBoxMarca.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.DialogResult =  DialogResult.Cancel;
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {

        }
    }
}
