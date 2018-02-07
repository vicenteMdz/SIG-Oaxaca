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

namespace Sistema_de_Informacion_Geografico
{
    public partial class Altas : Form
    {
        SqlCommand cmd, cmd1, c;
        SqlDataReader dr, dr1, d;
        String dato, ID,idp;

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
                string poblado = itemsPoblados[index].Label;
                coordenadas = Conexion.getCoordinates(poblado);
            }
        }
        
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                Random qq = new Random();
                int m = qq.Next(1000);
                int z = Convert.ToInt32(ID) + m;
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
            if (band == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
