using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analisis_financiero_csharp
{
    public partial class crear_usuario : Form
    {
        public crear_usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //este es el boton de aceptar
            MySql.Data.MySqlClient.MySqlConnection conexion;

            String apaterno = txt_apaterno.Text;
            String amaterno = txt_amaterno.Text;
            String nombre = txt_nombre.Text;
            String contraseña = txt_repetir_contrasena.Text;

            String conexion_datos;

            conexion_datos = "server=127.0.0.1; database=Usuario;";
            String insertar_datos = "INSERT INTO usuario VALUES("
                + nombre + ", " + apaterno + ", " + amaterno + ", " + contraseña + ")";

            try
            {
                // establece la conexion a mysql
                conexion = new MySql.Data.MySqlClient.MySqlConnection();
                conexion.ConnectionString = conexion_datos;
                conexion.Open();

                // introduce los datos del nuevo usuario

                            

            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
