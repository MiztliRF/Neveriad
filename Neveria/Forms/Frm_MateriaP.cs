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

namespace Neveria.Forms
{
    public partial class Frm_MateriaP : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=Neveria;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();


        System.Data.SqlClient.SqlDataReader lector;
        public Frm_MateriaP()
        {
            InitializeComponent();
        }

        private void bttnregresar_Click(object sender, EventArgs e)
        {
           
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_MateriaP";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 3);
            comando.Parameters.AddWithValue("@ID", int.Parse(txtclave.Text));
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_MateriaP";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@OP", 1);
                comando.Parameters.AddWithValue("@ID", int.Parse(txtclave.Text));
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtclave.Text = lector["Clave"].ToString();
                    txtnombre.Text = lector["Nombre"].ToString();
                    txtprecio.Text = lector["Precio"].ToString();
                    txtfolioc.Text = lector["Folio_Compra_D"].ToString();

                }
                lector.Close();
                conexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_MateriaP_B C = new Frm_MateriaP_B();
            C.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_MateriaP";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 2);
            comando.Parameters.AddWithValue("@ID", int.Parse(txtclave.Text));
            comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@Precio", txtprecio.Text);
            comando.Parameters.AddWithValue("@Folio_Compra", txtfolioc.Text);
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
