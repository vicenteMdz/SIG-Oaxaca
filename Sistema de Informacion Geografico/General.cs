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

            loadMapBase();
            //Cargar todos los acontecimientos
            List<Acontecimiento> acontecimientos = Conexion.getAllAcontecimientos();
            if (acontecimientos.Count() == 0)
            {
                MessageBox.Show("No hay registros de fenómenos ocurridos");
            }
            else
            {
                foreach(Acontecimiento ac in acontecimientos)
                {
                    string[] coordenadas = ac.CoordenadaSuceso.Split(',');
                    double longitud = double.Parse(coordenadas[1].Replace(".", ","));
                    double latitud = double.Parse(coordenadas[0].Replace(".", ","));
                    MarkPoints(latitud, longitud, ac.IdCategoriaAcontecimiento);
                }
            }

            //load tooltip event
            ToolTip(axMap1);

            axMap1.ZoomToMaxExtents();
        }

        public void loadMapBase()
        {
            shapefile1.Open(String.Concat(path, "\\data-shp\\base\\Poligonos.shp"), null);
            shapefile1.StartEditingShapes(true, null);
            shapefile1.UseQTree = true;
            intHandler1 = axMap1.AddLayer(shapefile1, true);
        }

        public void MarkPoints(double latitud, double longitud, int tipoFenomeno)
        {
            shapefile1 = axMap1.get_Shapefile(intHandler1);     // in case a copy of shapefile was created by GlobalSettings.ReprojectLayersOnAdding
            shapefile1 = new Shapefile();
            if (!shapefile1.CreateNewWithShapeID("", ShpfileType.SHP_POINT))
            {
                MessageBox.Show("Failed to create shapefile: " + shapefile1.ErrorMsg[shapefile1.LastErrorCode]);
                return;
            }
            intHandler1 = axMap1.AddLayer(shapefile1, true);
            axMap1.set_LayerName(intHandler1, "6353");
            ShapeDrawingOptions options = shapefile1.DefaultDrawingOptions;
            options.PointType = tkPointSymbolType.ptSymbolPicture;
            options.Picture = this.OpenMarker(tipoFenomeno);
            Shapefile sf = axMap1.get_Shapefile(intHandler1);
            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POINT);
            MapWinGIS.Point pnt = new MapWinGIS.Point();
            pnt.x = longitud;
            pnt.y = latitud;
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
        // <summary>
        // Opens a marker from the file
        // </summary>
        private MapWinGIS.Image OpenMarker(int tipoFenomeno)
        {
            string filename = path + "\\data-shp\\markers\\";
            switch (tipoFenomeno)
            {
                case 1:
                    filename = String.Concat(filename, "marker_sismos.png");
                    break;
                case 2:
                    filename = String.Concat(filename, "marker_emisionesvolcanicas.png");
                    break;
                case 3:
                    filename = String.Concat(filename, "marker_tsunamis.png");
                    break;
                case 4:
                    filename = String.Concat(filename, "marker_inestabilidaddeladeras.png");
                    break;
                case 5:
                    filename = String.Concat(filename, "marker_hundimientos.png");
                    break;
                case 6:
                    filename = String.Concat(filename, "marker_erupciones.png");
                    break;
                case 7:
                    filename = String.Concat(filename, "marker_agrietamientos.png");
                    break;
                case 8:
                    filename = String.Concat(filename, "marker_huracanes.png");
                    break;
                case 9:
                    filename = String.Concat(filename, "marker_inundaciones.png");
                    break;
                case 10:
                    filename = String.Concat(filename, "marker_tormentasdegranizo.png");
                    break;
                case 11:
                    filename = String.Concat(filename, "marker_heladasynevadas.png");
                    break;
                case 12:
                    filename = String.Concat(filename, "marker_mareasdetormentas.png");
                    break;
                case 13:
                    filename = String.Concat(filename, "marker_vientos.png");
                    break;
                case 14:
                    filename = String.Concat(filename, "marker_sequias.png");
                    break;
                case 15:
                    filename = String.Concat(filename, "marker_erosion.png");
                    break;
                case 16:
                    filename = String.Concat(filename, "marker_precipitacion.png");
                    break;
                case 17:
                    filename = String.Concat(filename, "marker_derrames.png");
                    break;
                case 18:
                    filename = String.Concat(filename, "marker_exposiones.png");
                    break;
                case 19:
                    filename = String.Concat(filename, "marker_radiaciones.png");
                    break;
                case 20:
                    filename = String.Concat(filename, "marker_fugastoxicas.png");
                    break;
                case 21:
                    filename = String.Concat(filename, "marker_incendios.png");
                    break;
                case 22:
                    filename = String.Concat(filename, "marker_residuospeligrosos.png");
                    break;
                case 23:
                    filename = String.Concat(filename, "marker_epidemiasoplagas.png");
                    break;
                case 24:
                    filename = String.Concat(filename, "marker_contaminaciondeaire.png");
                    break;
                case 25:
                    filename = String.Concat(filename, "marker_contaminaciondesuelo.png");
                    break;
                case 26:
                    filename = String.Concat(filename, "marker_contaminaciondeagua.png");
                    break;
                case 27:
                    filename = String.Concat(filename, "marker_contaminaciondealimentos.png");
                    break;
            }

            MapWinGIS.Image img = new MapWinGIS.Image();
            if (!img.Open(filename, ImageType.USE_FILE_EXTENSION, true, null))
            {
                MessageBox.Show(img.ErrorMsg[img.LastErrorCode]);
                img.Close();
            }
            else
                return img;
            return null;
        }

        // <summary>
        // Opens a shapefile, registers event handler
        // </summary>
        public void ToolTip(AxMap axMap1)
        {
                axMap1.SendMouseMove = true;
                axMap1.ShowRedrawTime = true;
                axMap1.MapUnits = tkUnitsOfMeasure.umMeters;
                axMap1.CurrentScale = 50000;
                axMap1.CursorMode = tkCursorMode.cmNone;
                axMap1.MouseMoveEvent += new AxMapWinGIS._DMapEvents_MouseMoveEventHandler(axMap2_MouseMoveEvent);  // change MapEvents to axMap1

                int m_drawingHandle = axMap1.NewDrawing(tkDrawReferenceList.dlScreenReferencedList);
                Labels labels = axMap1.get_DrawingLabels(m_drawingHandle);
                labels.FrameVisible = true;
                labels.FrameType = tkLabelFrameType.lfRectangle;
                axMap1.ZoomToMaxExtents();
        }

        // <summary>
        // Handles mouse move event. Determines which shape is under cursor. Calls drawing routine.
        // </summary>
        void axMap2_MouseMoveEvent(object sender, _DMapEvents_MouseMoveEvent e)
        {
            Labels labels = axMap1.get_DrawingLabels(0);
            labels.Clear();

            // it's assumed here that the layer we want to edit is the first 1 (with 0 index)
            int layerHandle = axMap1.get_LayerHandle(0);
            Shapefile sf = axMap1.get_Shapefile(layerHandle);
            if (sf != null)
            {
                double projX = 0.0;
                double projY = 0.0;
                axMap1.PixelToProj(e.x, e.y, ref projX, ref projY);

                object result = null;
                Extents ext = new Extents();
                ext.SetBounds(projX, projY, 0.0, projX, projY, 0.0);
                
                if (sf.SelectShapes(ext, 0.0, SelectMode.INTERSECTION, ref result))
                {
                    int[] shapes = result as int[];
                    if (shapes.Length == 1)
                    {
                        string s = "";
                        //for (int i = 0; i < sf.NumFields; i++)
                        //{
                            s += "Municipio: " + sf.get_CellValue(0, shapes[0]) + "\n";
                        //}
                        labels.AddLabel(s, e.x + 80, e.y, 0.0, -1);

                        Shape shape = sf.get_Shape(shapes[0]);
                    }
                }
            }

            axMap1.Refresh();
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
            cargarBusqueda(acontecimientos);
            //Conexion.buscaCoordenadas();
        }

        private void netBarItem1_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(1);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem2_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(2);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem3_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(3);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem4_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(4);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem5_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(5);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem6_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(6);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem7_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(7);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem8_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(8);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem9_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(9);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem10_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(10);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem11_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(11);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem12_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(12);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem13_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(13);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem14_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(14);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem15_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(15);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem16_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(16);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem17_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(17);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem18_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(18);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem19_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(19);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem20_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(21);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem21_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(20);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem22_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(22);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem23_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(23);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem24_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(24);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem25_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(25);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem26_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(26);
            cargarBusqueda(acontecimientos);
        }

        private void netBarItem27_ItemClick(object sender, EventArgs e)
        {
            List<Acontecimiento> acontecimientos = Conexion.findAcontecimientoPorCategoriaRiesgo(27);
            cargarBusqueda(acontecimientos);
        }

        private void netBarControl1_ActiveGroupChanged(object sender, EventArgs e)
        {
            string tipoRiesgo = netBarControl1.ActiveGroup.Name;
            switch (tipoRiesgo)
            {
                case "RG":
                    cargarBusqueda(Conexion.findAcontecimientoPorTipoRiesgo(1));
                    break;
                case "RH":
                    cargarBusqueda(Conexion.findAcontecimientoPorTipoRiesgo(2));
                    break;
                case "RQT":
                    cargarBusqueda(Conexion.findAcontecimientoPorTipoRiesgo(3));
                    break;
                case "RSE":
                    cargarBusqueda(Conexion.findAcontecimientoPorTipoRiesgo(4));
                    break;
            }
        }

        public void cargarBusqueda(List<Acontecimiento> acontecimientos)
        {
            if (acontecimientos.Count() == 0)
            {
                axMap1.RemoveAllLayers();
                loadMapBase();
                MessageBox.Show("No se encontraron coincidencias", "Aviso");
            }
            else
            {
                axMap1.RemoveAllLayers();
                loadMapBase();
                foreach (Acontecimiento ac in acontecimientos)
                {
                    string[] coordenadas = ac.CoordenadaSuceso.Split(',');
                    double longitud = double.Parse(coordenadas[1].Replace(".", ","));
                    double latitud = double.Parse(coordenadas[0].Replace(".", ","));
                    MarkPoints(latitud, longitud, ac.IdCategoriaAcontecimiento);
                }
            }
        }

    }
}
