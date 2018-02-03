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
    public partial class Raster : Form
    {
        //(1) Create an integer variable to store the raster grid layer handler
        public int intHandler;
        //(2) Create an instance for the grid raster 
        public MapWinGIS.Grid myGrid = new MapWinGIS.Grid();
        //(3) Create a new grid header object
        public MapWinGIS.GridHeader myHeader = new MapWinGIS.GridHeader();
        //(4) Create an image instance to store and display the raster
        public MapWinGIS.Image myImage = new MapWinGIS.Image();

        private string path = Directory.GetCurrentDirectory();

        public Raster()
        {
            InitializeComponent();
        }

        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Raster_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //(1) Open the grid
            myGrid.Open(@String.Concat(path, "\\data-shp\\raster\\dem.tif"),
                    MapWinGIS.GridDataType.DoubleDataType,
                    false, MapWinGIS.GridFileType.GeoTiff,
                    null);
            //(2) Get the header of the raster
            myHeader = myGrid.Header;

            //Symobolize the raster grid
            //(3) Create a raster grid color scheme
            MapWinGIS.GridColorScheme myScheme =
                    new MapWinGIS.GridColorScheme();
            //(4)Assign the no data color to lack
            myScheme.NoDataColor =
                    System.Convert.ToUInt32(
                    System.Drawing.ColorTranslator.ToOle( //
                    System.Drawing.Color.FromArgb(0, 0, 0)));
            //(5) Set the attributes of the color scheme
            myScheme.UsePredefined(
                    (double)myGrid.Minimum,
                    (double)myGrid.Maximum,
                    MapWinGIS.PredefinedColorScheme.DeadSea);

            //Convert the grid to an image
            //(6) Create a Utili instance
            MapWinGIS.Utils myUtil = new MapWinGIS.Utils();
            //(7) and use it to convert the grid to the image
            myImage = myUtil.GridToImage(myGrid, myScheme, null);

            //(8) Finally add the layer to the map
            intHandler = axMap1.AddLayer(myImage, true);

        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            int width = myHeader.NumberCols;
            int height = myHeader.NumberRows;

            String sizeInPixels = string.Format("Grid size - in pixels - is ({0},{1})\n", width, height);

            double deltaX = myHeader.dX;
            double deltaY = myHeader.dY;

            String pixelDimensions = String.Format("Pixel dimensions are ({0},{1})\n", deltaX, deltaY);

            double xLlocation = myHeader.XllCenter;
            double yLlocation = myHeader.YllCenter;

            String lowerLeftCorner = String.Format("Lower left corner coordinates ({0},{1})\n", xLlocation, yLlocation);

            String infoMessage = sizeInPixels + pixelDimensions + lowerLeftCorner;
            MessageBox.Show(infoMessage, "Raster Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      

       
        private void toolCursor_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void toolMove_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void toolZoomInt_Click_1(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
        }

        private void toolZoomOut_Click_1(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
        }

        private void toolZoomExtent_Click_1(object sender, EventArgs e)
        {
            axMap1.ZoomToMaxExtents();
        }
        private void axMap1_MouseMoveEvent_1(object sender, AxMapWinGIS._DMapEvents_MouseMoveEvent e)
        {

            double X = 0;
            double Y = 0;
            axMap1.PixelToProj(e.x, e.y, ref X, ref Y);
            //(2) Get the value of pixel at specified point
            double pixelVal = (double)myGrid.get_Value(e.x, e.y);
            //(3) Print the result to the status toolbar.
            string pointLocation = String.Format("Cursor location ({0},{1}) " +
                                   "and the pixel value is {2}", X, Y, pixelVal);
            toolStripStatusLabel1.Text = pointLocation;
        }

        private void toolCursor_Click_1(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmNone;
        }

        private void Raster_Leave(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

       

       
    }
}
