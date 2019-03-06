using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neveria.Forms
{
    public partial class Frm_Colonia : Form
    {System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=Neveria;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        public Frm_Colonia()
        {
            InitializeComponent();
        }

        private void bttnactualizar_Click(object sender, EventArgs e)
        {

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Colonia";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 2);
            comando.Parameters.AddWithValue("@ID", int.Parse(txtid.Text));
            comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@Codigo_Postal", txtcp.Text);
            comando.Parameters.AddWithValue("@ID_Localidad", txtidlocalidad.Text);
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            txtnombre.Clear();
            txtid.Focus();
        }

        private void bttneliminar_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Colonia";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 3);
            comando.Parameters.AddWithValue("@ID", int.Parse(txtid.Text));
            comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@Codigo_Postal", txtcp.Text);
            comando.Parameters.AddWithValue("@ID_Localidad", txtidlocalidad.Text);
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            txtnombre.Clear();
            txtid.Focus();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_Colonia";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@OP", 1);
                comando.Parameters.AddWithValue("@ID", int.Parse(txtid.Text));
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtid.Text = lector["IDColonia"].ToString();
                    txtnombre.Text = lector["Nombre"].ToString();
                    txtcp.Text = lector["Codigo_Postal"].ToString();
                    txtidlocalidad.Text = lector["ID_Localidad"].ToString();
                }
                lector.Close();
                conexion.Close();
            }
        }

        private void bttnbuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
