using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace analisis_financiero_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            /*
             * all interaction between a .NET app and the MySQL server is routed
             * throud a MySQLConnection object. Before the app can interact with the 
             * server, it must instantuate, configure, and open a MySQLConnection objetct
             * Even when using the MySQLHelper class
             * 
             * pag 63 capitulo 5
             */

            MySql.Data.MySqlClient.MySqlConnection conexion;
            String conexion_datos;

            conexion_datos = "server=127.0.0.1;";

            String usuario;
            usuario = txt_usuario.Text;

            String contraseña;
            contraseña = txt_contrasena.Text;

            try
            {
                conexion = new MySql.Data.MySqlClient.MySqlConnection();
                conexion.ConnectionString = conexion_datos;
                conexion.Open();
            }catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
