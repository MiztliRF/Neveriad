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
    public partial class Login : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        public Login()
        {
            InitializeComponent();
        }
        public void Logins()
        {
           
            
           
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.Size = new Size(70, 30);
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnlogin_Click(object sender, EventArgs e)
        {
            
            conexion.Open();
            System.Data.SqlClient.SqlCommand comando = new SqlCommand("select Usuario,Contraseña from Usuarios where Usuario='" + txtusuario.Text + "' and Contraseña='" + txtcontra.Text + "'", conexion);
            {
                lector = comando.ExecuteReader();

                if (lector.Read())
                {
                Menu frm = new Menu();
                this.Hide();
                frm.Show();

                }
                else
                {
                    MessageBox.Show("Imposible conectarse");


                }
                lector.Close();
                conexion.Close();
            }

            
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               
 
                 txtcontra.Focus();
                txtcontra.Enabled = true;

            }
        }

        private void txtcontra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conexion.Open();
                System.Data.SqlClient.SqlCommand usuario = new SqlCommand("select   US_NOMBRE from Usuarios where US_NOMBRE='" + txtusuario.Text, conexion);
                if (txtusuario.Text==usuario.ToString())
                {


                    if (string.IsNullOrEmpty(txtcontra.Text.Trim()) || string.IsNullOrEmpty(txtusuario.Text.Trim()))
                    {
                        MessageBox.Show("NO puede haber espacios en blancos");
                    }
                    else
                    {
                        System.Data.SqlClient.SqlCommand comando = new SqlCommand("select   US_NOMBRE,US_CONTRASEÑA from Usuarios where US_NOMBRE='" + txtusuario.Text + "' and US_CONTRASEÑA='" + txtcontra.Text + "'", conexion);
                        {
                            lector = comando.ExecuteReader();

                            if (lector.Read())
                            {
                                Menu frm = new Menu();
                                this.Hide();
                                frm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Imposible conectarse");


                            }
                            lector.Close();
                            conexion.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NO Existe");
                }
            }

        }
    }
}
