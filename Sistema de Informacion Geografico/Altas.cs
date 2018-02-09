using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using System.Globalization;
using System.Data.OleDb;
using System.IO;
using MapWinGIS;
using AxMapWinGIS;

namespace Sistema_de_Informacion_Geografico
{
    public partial class Altas : Form
    {
        MapWinGIS.Shapefile shapefile1;
        int intHandler1;
        private string path = Directory.GetCurrentDirectory();
        private Coordenadas C = null;

        List<LabelVauleBean> itemsCategorias;
        List<LabelVauleBean> itemsRegiones;
        List<LabelVauleBean> itemsDistritos;
        List<LabelVauleBean> itemsMunicipios;
        List<LabelVauleBean> itemsPoblados;
        private string errorMesage = "Corrige los siguientes errores: \n";
        private string coordenadas = "";

        public Altas()
        {
            InitializeComponent();

            itemsCategorias = Conexion.getLabelValueBeanCategoriaRiesgos();
            foreach (LabelVauleBean item in itemsCategorias)
            {
                Categoria.Items.Add(item.Label);
            }
            Categoria.SelectedIndex = 0;
            
            itemsRegiones = Conexion.getLabelValueBeanRegiones();
            foreach (LabelVauleBean item in itemsRegiones)
            {
                Region.Items.Add(item.Label);
            }
            Region.SelectedIndex = 0;

            Distri.Items.Clear();
            Distri.Items.Add("-- Seleccione --");
            Distri.SelectedIndex = 0;

            Municip.Items.Clear();
            Municip.Items.Add("-- Seleccione --");
            Municip.SelectedIndex = 0;

            Pobla.Items.Clear();
            Pobla.Items.Add("-- Seleccione --");
            Pobla.SelectedIndex = 0;

        }

        private void Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Region.SelectedIndex;

            Distri.Items.Clear();
            Distri.Items.Add("-- Seleccione --");
            Distri.SelectedIndex = 0;

            Municip.Items.Clear();
            Municip.Items.Add("-- Seleccione --");
            Municip.SelectedIndex = 0;

            Pobla.Items.Clear();
            Pobla.Items.Add("-- Seleccione --");
            Pobla.SelectedIndex = 0;

            if (index != 0)
            {
                Distri.Items.Clear();
                itemsDistritos = Conexion.getLabelValueBeanDistritosPorRegion(itemsRegiones[index].Id);
                foreach (LabelVauleBean item in itemsDistritos)
                {
                    Distri.Items.Add(item.Label);
                }
                Distri.SelectedIndex = 0;
            }
        }

        private void Altas_Load(object sender, EventArgs e)
        {
            loadMapaBase();


        }

        public void loadMapaBase()
        {
            shapefile1 = new Shapefile();
            shapefile1.Open(String.Concat(path, "\\data-shp\\base\\Poligonos.shp"), null);

            shapefile1.StartEditingShapes(true, null);
            shapefile1.UseQTree = true;

            //intHandler1 = axMap1.AddLayer(shapefile1, true);

            shapefile1.UseQTree = true;
            shapefile1.Labels.Generate("[Name]", tkLabelPositioning.lpCentroid, false);

            intHandler1 = axMap1.AddLayer(shapefile1, true);
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
                        for (int i = 0; i < 1; i++)
                        {
                            s += sf.get_Field(i).Name + ": " + sf.get_CellValue(i, shapes[0]) + "\n";
                        }
                        labels.AddLabel(s, e.x + 80, e.y, 0.0, -1);

                        Shape shape = sf.get_Shape(shapes[0]);
                    }
                }
            }

            axMap1.Refresh();
        }

        private void Distri_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Distri.SelectedIndex;
            Municip.Items.Clear();
            Municip.Items.Add("-- Seleccione --");
            Municip.SelectedIndex = 0;

            Pobla.Items.Clear();
            Pobla.Items.Add("-- Seleccione --");
            Pobla.SelectedIndex = 0;

            if (index != 0)
            {
                Municip.Items.Clear();
                itemsMunicipios = Conexion.getLabelValueBeanMunicipiosPorDistritos(itemsDistritos[index].Id);
                foreach (LabelVauleBean item in itemsMunicipios)
                {
                    Municip.Items.Add(item.Label);
                }
                Municip.SelectedIndex = 0;
            }
        }

        private void Municip_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Municip.SelectedIndex;
            Pobla.Items.Clear();
            Pobla.Items.Add("-- Seleccione --");
            Pobla.SelectedIndex = 0;

            if (index != 0)
            {
                Pobla.Items.Clear();
                itemsPoblados = Conexion.getLabelValueBeanPobladosPorMunicipios(itemsMunicipios[index].Id);
                foreach (LabelVauleBean item in itemsPoblados)
                {
                    Pobla.Items.Add(item.Label);
                }
                Pobla.SelectedIndex = 0;
            }
        }

        private void Pobla_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Pobla.SelectedIndex;
            if (index != 0)
            {
                int poblado = itemsPoblados[index].Id;
                //coordenadas = Conexion.getCoordinates(poblado);
                axMap1.RemoveAllLayers();
                loadMapaBase();
                C = Conexion.Coordenada(poblado);
                if (C == null)
                {
                    MessageBox.Show("Imposible encontrar coordenadas para esta población.");
                }
                else
                {
                    MarkPoints(C.Latitud1, C.Longitud1);
                }
            }
        }
        
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                Acontecimiento acontecimiento = new Acontecimiento();
                acontecimiento.IdAcontecimiento = 0;
                acontecimiento.IdCategoriaAcontecimiento = itemsCategorias[Categoria.SelectedIndex].Id;
                acontecimiento.IdDistrito = itemsDistritos[Distri.SelectedIndex].Id;
                acontecimiento.IdEstado = 1;
                acontecimiento.IdMunicipio = itemsMunicipios[Municip.SelectedIndex].Id;
                acontecimiento.IdPoblacion = itemsPoblados[Pobla.SelectedIndex].Id;
                acontecimiento.IdRegion = itemsRegiones[Region.SelectedIndex].Id;
                acontecimiento.FechaHoraAcontecimiento = Fecha.Value;
                acontecimiento.Descripcion = descripcion.Text;
                acontecimiento.Cp = Codigo.Text;
                coordenadas = System.Convert.ToString(C.Latitud1)+ ":" +System.Convert.ToString(C.Longitud1);
                acontecimiento.CoordenadaSuceso = coordenadas;
                if (Conexion.insertAcontecimiento(acontecimiento))
                {
                    MessageBox.Show("Los datos fueron insertados correctamente.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(Conexion.ErrorMessageInserted);
                }
            }
            else
            {
                MessageBox.Show(errorMesage);
            }
        }

        public void Limpiar()
        {
            Categoria.Text = "";
            Region.Text = "";
            Distri.Text = "";
            Municip.Text = "";
            Pobla.Text = "";
            Codigo.Text = "";
            Fecha.Text = "";
            descripcion.Text = "";
        }

        public Boolean validateFields()
        {
            int band = 0;
            if (Categoria.SelectedIndex == 0)
            {
                errorMesage += "\nSelecciona una categoría de riesgo.";
                band++;
            }
            if (Region.SelectedIndex == 0)
            {
                errorMesage += "\nSelecciona una región.";
                band++;
            }
            if (Distri.SelectedIndex == 0)
            {
                errorMesage += "\nSelecciona un Distrito.";
                band++;
            }
            if (Municip.SelectedIndex == 0)
            {
                errorMesage += "\nSelecciona un municipio.";
                band++;
            }
            if (Pobla.SelectedIndex == 0)
            {
                errorMesage += "\nSelecciona una población.";
                band++;
            }
            if (Codigo.Text.Trim().Equals("") || Codigo.Text == null)
            {
                errorMesage += "\nIngresa el código postal del poblado.";
                band++;
            }
            if (C == null && Pobla.SelectedIndex != 0)
            {
                errorMesage += "\nLa poblacion seleccionada no tiene coordenadas, seleccione otra.";
                band++;
            }
            if (band == 0)
            {
                return true;
            }            
            else
            {
                return false;
            }
        }
        public void MarkPoints(double latitud, double longitud)
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
            options.Picture = this.OpenMarker();
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
        private MapWinGIS.Image OpenMarker()
        {
            string filename = path + "\\data-shp\\markers\\";
           
                    filename = String.Concat(filename, "marker_sismos.png");

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
    }
}
