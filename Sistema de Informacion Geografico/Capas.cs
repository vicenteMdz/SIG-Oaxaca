using System;
using System.IO;
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
    public partial class Capas : Form
    {
        int intHandler0;
        int intHandler1;
        int intHandler2;
        int intHandler3;
        int intHandler4;
        int intHandler5;
        int intHandler6;
        int intHandler7;
        int intHandler8;
        int intHandler9;
        MapWinGIS.Shapefile shapefile0 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile1 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile2 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile3 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile4 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile5 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile6 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile7 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile8 = new MapWinGIS.Shapefile();
        MapWinGIS.Shapefile shapefile9 = new MapWinGIS.Shapefile();

        private string path = Directory.GetCurrentDirectory();
           
        public Capas()
        {
            InitializeComponent();
            
        }
      
        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {
             
        }

        private void Capas_Load(object sender, EventArgs e)
        {
            
            shapefile0.Open(@String.Concat(path, "\\data-shp\\base\\Poligonos.shp"), null);

            intHandler0 = axMap1.AddLayer(shapefile0, true);
            this.WindowState = FormWindowState.Maximized;

        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                shapefile1.Open(@String.Concat(path, "\\data-shp\\OAX\\agric-oaxg.shp"), null);
                
                intHandler1 = axMap1.AddLayer(shapefile1, true);

               
            }

            else {
                shapefile1.Open(null, null);

                intHandler1 = axMap1.AddLayer(shapefile1, true);
            }
            

                

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)

        {
            if (checkBox2.Checked == true)
            {
                shapefile2.Open(@String.Concat(path, "\\data-shp\\OAX\\cagua-oaxg.shp"), null);
                intHandler2 = axMap1.AddLayer(shapefile2, true);


            }

            else
            {
                shapefile2.Open(null, null);
                intHandler2 = axMap1.AddLayer(shapefile2, true);
            }
            
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {if (checkBox3.Checked ==true)
            {
            shapefile3.Open(@String.Concat(path, "\\data-shp\\OAX\\camf-oaxg.shp"), null);
            intHandler3 = axMap1.AddLayer(shapefile3, true);
           
            }
        else
        {
            shapefile3.Open(null, null);
            intHandler3 = axMap1.AddLayer(shapefile3, true);
        }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {if (checkBox4.Checked ==true)
            {
            shapefile4.Open(@String.Concat(path, "\\data-shp\\OAX\\camr-oaxg.shp"), null);

            intHandler4 = axMap1.AddLayer(shapefile4, true);
               
            }
        else
        {
            shapefile4.Open(null, null);

            intHandler4 = axMap1.AddLayer(shapefile4, true);
        }

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {if (checkBox5.Checked ==true)
            {
            shapefile5.Open(@String.Concat(path, "\\data-shp\\OAX\\cap-oaxg.shp"), null);

            intHandler5 = axMap1.AddLayer(shapefile5, true);

            }
        else
        {
            shapefile5.Open(null, null);

            intHandler5 = axMap1.AddLayer(shapefile5, true);
        }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {if (checkBox6.Checked ==true)
            {
            shapefile6.Open(@String.Concat(path, "\\data-shp\\OAX\\curvas-oaxg.shp"), null);

            intHandler6 = axMap1.AddLayer(shapefile6, true);
         
               
            }
        else
        {
            shapefile6.Open(null, null);

            intHandler6 = axMap1.AddLayer(shapefile6, true);
        }

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {if (checkBox7.Checked ==true)
            {
            shapefile7.Open(@String.Concat(path, "\\data-shp\\OAX\\loc-oaxg.shp"), null);

            intHandler7 = axMap1.AddLayer(shapefile7, true);

            }
        else
        {
            shapefile7.Open(null, null);

            intHandler7 = axMap1.AddLayer(shapefile7, true);
        }

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {if (checkBox8.Checked ==true)
            {
            shapefile8.Open(@String.Concat(path, "\\data-shp\\OAX\\rios-oaxg1.shp"), null);

            intHandler8 = axMap1.AddLayer(shapefile8, true);

            }
        else
        {
            shapefile8.Open(null, null);

            intHandler8 = axMap1.AddLayer(shapefile8, true);
        }

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {if (checkBox9.Checked ==true)
            {
            shapefile9.Open(@String.Concat(path, "\\data-shp\\OAX\\vegnat-oaxg.shp"), null);

            intHandler9 = axMap1.AddLayer(shapefile9, true);
            }
        else
        {
            shapefile9.Open(null, null);

            intHandler9 = axMap1.AddLayer(shapefile9, true);
        }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolCursor_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void toolMove_Click_1(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void toolZoomInt_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void toolZoomOut_Click_1(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void toolZoomExtent_Click(object sender, EventArgs e)
        {
            axMap1.ZoomToMaxExtents();
        }

        private void Capas_Leave(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void axMap1_MouseMoveEvent(object sender, AxMapWinGIS._DMapEvents_MouseMoveEvent e)
        {

        }
    }
}
