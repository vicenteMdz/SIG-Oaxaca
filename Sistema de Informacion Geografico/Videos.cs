using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Informacion_Geografico
{
    public partial class Videos : Form
    {
        public Videos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entretenimiento ventana = new entretenimiento(1);
            ventana.Show();
        }

        private void Videos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            entretenimiento ventana = new entretenimiento(2);
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            entretenimiento ventana = new entretenimiento(3);
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            entretenimiento ventana = new entretenimiento(4);
            ventana.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
