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
            
            shapefile1.Open(@String.Concat(path, "\\data-shp\\base\\Poligonos.shp"), null);

            intHandler1 = axMap1.AddLayer(shapefile1, true);

            MarkPoints(axMap1);
        }

        public void CreatePointShapefile(AxMap axMap1)
        {
            //axMap1.Projection = tkMapProjection.PROJECTION_NONE;
            var sf = new Shapefile();
            // MWShapeId field will be added to attribute table
            bool result = sf.CreateNewWithShapeID("", ShpfileType.SHP_POINT);
            // bounding box for the new shapefile
            double xMin = 0.0;
            double yMin = 0.0;
            double xMax = 1000.0;
            double yMax = 1000.0;
            // the location of points will be random
            Random rnd = new Random(DateTime.Now.Millisecond);
            // creating points and inserting them in the shape
            for (int i = 0; i < 1000; i++)
            {
                var pnt = new MapWinGIS.Point();
                pnt.x = xMin + (xMax - xMin) * rnd.NextDouble();
                pnt.y = yMin + (yMax - yMin) * rnd.NextDouble();
                Shape shp = new Shape();
                shp.Create(ShpfileType.SHP_POINT);
                int index = 0;
                shp.InsertPoint(pnt, ref index);
                sf.EditInsertShape(shp, ref i);
            }
            sf.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsStar);
            // adds shapefile to the map
            axMap1.AddLayer(sf, true);
            // save if needed
            //sf.SaveAs(@"c:\points.shp", null);
        }

        public void MarkPoints(AxMap axMap1)
        {
            //axMap1.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
            string filename = @path+"\\data-shp\\base\\Datos.shp";
            if (!File.Exists(filename))
            {
                MessageBox.Show("Couldn't file the file: " + filename);
                return;
            }
            var sf = new Shapefile();
            sf.Open(filename, null);
            m_layerHandle = axMap1.AddLayer(sf, true);
            sf = axMap1.get_Shapefile(m_layerHandle);     // in case a copy of shapefile was created by GlobalSettings.ReprojectLayersOnAdding
            sf = new Shapefile();
            if (!sf.CreateNewWithShapeID("", ShpfileType.SHP_POINT))
            {
                MessageBox.Show("Failed to create shapefile: " + sf.ErrorMsg[sf.LastErrorCode]);
                return;
            }
            m_layerHandle = axMap1.AddLayer(sf, true);
            ShapeDrawingOptions options = sf.DefaultDrawingOptions;
            options.PointType = tkPointSymbolType.ptSymbolPicture;
            options.Picture = this.OpenMarker();

            sf.CollisionMode = tkCollisionMode.AllowCollisions;
            axMap1.SendMouseDown = true;
            axMap1.CursorMode = tkCursorMode.cmNone;
            axMap1.MouseDownEvent += AxMap1MouseDownEvent;   // change MapEvents to axMap1
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
                Shapefile sf = axMap1.get_Shapefile(m_layerHandle);
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

    }
}
