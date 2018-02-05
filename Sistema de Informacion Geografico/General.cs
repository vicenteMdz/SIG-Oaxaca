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
using MapWinGIS;
using AxMapWinGIS;

namespace Sistema_de_Informacion_Geografico
{
    public partial class General : Form
    {
        private string path = Directory.GetCurrentDirectory();
        int intHandler1, m_layerHandle;
        MapWinGIS.Shapefile shapefile1 = new MapWinGIS.Shapefile();

        public General()
        {
            InitializeComponent();
        }

        private void toolCursor_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void toolZoomExtent_Click(object sender, EventArgs e)
        {
            axMap1.ZoomToMaxExtents();
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void toolZoomInt_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void toolMove_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //set first item select cmbFilter
            cmbFilter.SelectedIndex = 0;
            
            shapefile1.Open(@String.Concat(path, "\\data-shp\\base\\Poligonos.shp"), null);

            intHandler1 = axMap1.AddLayer(shapefile1, true);

            MarkPoints(axMap1);

            //Cargar todos los acontecimientos



        }

        public void MarkPoints(AxMap axMap1)
        {
            shapefile1 = axMap1.get_Shapefile(intHandler1);     // in case a copy of shapefile was created by GlobalSettings.ReprojectLayersOnAdding
            shapefile1 = new Shapefile();
            if (!shapefile1.CreateNewWithShapeID("", ShpfileType.SHP_POINT))
            {
                MessageBox.Show("Failed to create shapefile: " + shapefile1.ErrorMsg[shapefile1.LastErrorCode]);
                return;
            }
            intHandler1 = axMap1.AddLayer(shapefile1, true);
            ShapeDrawingOptions options = shapefile1.DefaultDrawingOptions;
            options.PointType = tkPointSymbolType.ptSymbolPicture;
            options.Picture = this.OpenMarker();
            Shapefile sf = axMap1.get_Shapefile(intHandler1);
            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POINT);
            MapWinGIS.Point pnt = new MapWinGIS.Point();
            pnt.x = -96.5943562;
            pnt.y = 16.3317796;
            Console.WriteLine("X:::: " + pnt.x);
            Console.WriteLine("X:::: " + pnt.y);
            int index = shp.numPoints;
            shp.InsertPoint(pnt, ref index);
            index = sf.NumShapes;
            if (!sf.EditInsertShape(shp, ref index))
            {
                MessageBox.Show("Failed to insert shape: " + sf.ErrorMsg[sf.LastErrorCode]);
                return;
            }
            axMap1.Redraw();
            /*shapefile1.CollisionMode = tkCollisionMode.AllowCollisions;
            axMap1.SendMouseDown = true;
            axMap1.CursorMode = tkCursorMode.cmNone;
            axMap1.MouseDownEvent += AxMap1MouseDownEvent;   // change MapEvents to axMap1*/
        }
        // <summary>
        // Opens a marker from the file
        // </summary>
        private MapWinGIS.Image OpenMarker()
        {
            if (!File.Exists(path + "\\data-shp\\base\\marker.png"))
            {
                MessageBox.Show("Can't find the file: " + path);
            }
            else
            {
                MapWinGIS.Image img = new MapWinGIS.Image();
                if (!img.Open(path + "\\data-shp\\base\\marker.png", ImageType.USE_FILE_EXTENSION, true, null))
                {
                    MessageBox.Show(img.ErrorMsg[img.LastErrorCode]);
                    img.Close();
                }
                else
                    return img;
            }
            return null;
        }
        // <summary>
        // Handles mouse down event and adds the marker
        // </summary>
        public void AxMap1MouseDownEvent(object sender, _DMapEvents_MouseDownEvent e)
        {
            if (e.button == 1)          // left button
            {
                Shapefile sf = axMap1.get_Shapefile(intHandler1);
                Shape shp = new Shape();
                shp.Create(ShpfileType.SHP_POINT);
                MapWinGIS.Point pnt = new MapWinGIS.Point();
                double x = 0.0;
                double y = 0.0;
                axMap1.PixelToProj(e.x, e.y, ref x, ref y);
                pnt.x = x;
                pnt.y = y;
                Console.WriteLine("X:::: " + pnt.x);
                Console.WriteLine("X:::: " + pnt.y);
                int index = shp.numPoints;
                shp.InsertPoint(pnt, ref index);
                index = sf.NumShapes;
                if (!sf.EditInsertShape(shp, ref index))
                {
                    MessageBox.Show("Failed to insert shape: " + sf.ErrorMsg[sf.LastErrorCode]);
                    return;
                }
                axMap1.Redraw();
            }
        }


        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axMap1_MouseMoveEvent(object sender, _DMapEvents_MouseMoveEvent e)
        {
            double X = 0;
            double Y = 0;
            axMap1.PixelToProj(e.x, e.y, ref X, ref Y);
            //(3) Print the result to the status toolbar.
            string pointLocation = String.Format("Cursor location ({0},{1}) ", X, Y);
            toolStripStatusLabel1.Text = pointLocation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string condition = txtSearch.Text.ToUpper();
            int filter = cmbFilter.SelectedIndex;
            List<Acontecimiento> acontecimientos = Conexion.busquedaLibre(condition, filter);
            if (acontecimientos.Count() == 0)
            {
                MessageBox.Show("No se encontraron coincidencias", "Aviso");
            }
            else
            {

            }
        }

    }
}
