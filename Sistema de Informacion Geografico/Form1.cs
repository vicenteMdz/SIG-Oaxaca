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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlTypes;
using System.Globalization;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Sistema_de_Informacion_Geografico
{
    public partial class Form1 : Form
    {
        public SqlConnection SIGO;
        SqlCommand cmd;
        SqlDataReader dir;
        public string connectionString;

        public void declaraConexion()
        {
            connectionString = ConfigurationManager.ConnectionStrings["conectionbd"].ConnectionString;
            SIGO = new SqlConnection(connectionString);
        }
        public void abrirConexion()
        {
            SIGO.Close();
            SIGO.Open();
        }
        public Form1()
        {
            InitializeComponent();
            try
            {
                declaraConexion();
                abrirConexion();
            }
            catch (Exception ext) { MessageBox.Show(ext.ToString()); }
        }
        
        private void btn_Iniciar_Sesion_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        private void Acceder()
        {
            try
            { 
                if(text_User.Text!="" && text_Passw.Text!="")
                {
                    abrirConexion();
                    string user = Encrypt.GetMD5(text_User.Text);
                    string password = Encrypt.GetMD5(text_Passw.Text);
                    User u = Conexion.findUser(user, password);
                    if (u!=null)
                    {
                        Sistema_de_Informacion_Geografico.Principal menu = new Sistema_de_Informacion_Geografico.Principal();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña son incorrectas");
                    }
                }
                else
                {
                    MessageBox.Show("Favor de introducir un usuario o contraseña correcta");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.createConecction();
                Conexion.openConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion a la base de datos", "Advertencia");
            }
        }

        public class Encrypt
        {
            public static string GetMD5(string str)
            {
                MD5 md5 = MD5CryptoServiceProvider.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = md5.ComputeHash(encoding.GetBytes(str));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }
        }
    }
}
