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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            Sistema_de_Informacion_Geografico.General home = new Sistema_de_Informacion_Geografico.General();
            home.MdiParent = this;
            home.WindowState = FormWindowState.Maximized;
            home.Show();
        }

        private void rasterInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_de_Informacion_Geografico.Raster raster= new Sistema_de_Informacion_Geografico.Raster();
            raster.MdiParent = this;
            raster.Show();
            
           
           
        }

        private void mostrarCapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_de_Informacion_Geografico.Capas capas = new Sistema_de_Informacion_Geografico.Capas();
            capas.MdiParent = this;

            capas.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void registrarFenomenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_de_Informacion_Geografico.Altas regFenomenos = new Sistema_de_Informacion_Geografico.Altas();
            regFenomenos.MdiParent = this;

            regFenomenos.Show();
        }

        private void entretenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sistema_de_Informacion_Geografico.entretenimiento entretenimiento = new Sistema_de_Informacion_Geografico.entretenimiento();
            //entretenimiento.MdiParent = this;

            //entretenimiento.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_de_Informacion_Geografico.ayuda ayuda = new Sistema_de_Informacion_Geografico.ayuda();
            ayuda.MdiParent = this;

            ayuda.Show();
        }

        private void busquedaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema_de_Informacion_Geografico.General raster = new Sistema_de_Informacion_Geografico.General();
            raster.MdiParent = this;
            raster.WindowState = FormWindowState.Maximized;
            raster.Show();
        }

        private void aprendeConVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Videos ventana = new Videos();
            ventana.Show();
        }
    }
}
