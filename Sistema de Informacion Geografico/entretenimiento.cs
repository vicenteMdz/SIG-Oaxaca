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
    public partial class entretenimiento : Form
    {
        int entero;
        public entretenimiento(int x)
        {
            InitializeComponent();
            entero = x;
        }

        private void entretenimiento_Load(object sender, EventArgs e)
        {
            if (entero == 1)
            {
                axWindowsMediaPlayer1.URL= @"\\psf\\Home\\Desktop\\SIG-Oaxaca\\Sistema de Informacion Geografico\\Resources\\SIGVIDEO1.mp4";
            }
            else if (entero == 2)
            {
                axWindowsMediaPlayer1.URL = @"\\psf\\Home\\Desktop\\SIG-Oaxaca\\Sistema de Informacion Geografico\\Resources\\SIGVIDEO2.mp4";
            }
            else if (entero == 3)
            {
                axWindowsMediaPlayer1.URL = @"\\psf\\Home\\Desktop\\SIG-Oaxaca\\Sistema de Informacion Geografico\\Resources\\SIGVIDEO3.mp4";
            }
            else if (entero == 4)
            {
                axWindowsMediaPlayer1.URL = @"\\psf\\Home\\Desktop\\SIG-Oaxaca\\Sistema de Informacion Geografico\\Resources\\SIGVIDEO4.mp4";
            }
        }
    }
}
