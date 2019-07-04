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
       string  contraseña;
        string nivel;
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
            if (txtusuario.Text == "")
            {
                MessageBox.Show("No ingresado ningun usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                System.Data.SqlClient.SqlCommand comando = new SqlCommand("select US_NOMBRE,US_CONTRASEÑA from Usuarios where US_NOMBRE='" + txtusuario.Text + "' and US_CONTRASEÑA='" + txtcontra.Text + "'", conexion);
                conexion.Open();
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

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (e.KeyCode == Keys.Enter)
                {
                    
                    if (txtusuario.Text == "")
                    {
                        MessageBox.Show("Error el usuario no puede  ir en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtusuario.Focus();
                    }
                    else
                    {
                        conexion.Open();
                        string query = "select* from Usuarios where US_NOMBRE =@us_nombre";
                        SqlCommand comando= new SqlCommand(query, conexion);
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@us_nombre", txtusuario.Text);
                        SqlDataReader leer = comando.ExecuteReader();
                        //MessageBox.Show(comando.ToString());
                        //SqlCommand usuario = new SqlCommand("select US_NOMBRE from Usuarios where US_NOMBRE='" + txtusuario.Text, conexion);
                        if (leer.Read())
                        {
                            try
                            {
                                string ruta = "C:/Users/miztl/source/repos/Neveria Definitivo/Neveria Definitivo/Usuarios/";
                                string imagen = ruta + this.txtusuario.Text + ".jpg";
                                pictureBox1.Image = Image.FromFile(imagen);
                            }
                            catch (Exception ex)
                            {
                                string ruta = "C:/Users/miztl/source/repos/Neveria Definitivo/Neveria Definitivo/Usuarios/";
                                string imagen = ruta + "chente" + ".png";
                                pictureBox1.Image = Image.FromFile(imagen);
                                txtcontra.Enabled = true;
                                txtcontra.Focus();
                                txtusuario.Enabled = false;

                            }
                            contraseña = leer["US_CONTRASEÑA"].ToString();
                            nivel = leer["US_NIVEL"].ToString();
                            if (nivel == "1")
                            {
                                nivel = "Administrador";

                            }
                            if (nivel == "2")
                            {
                                nivel = "Operador";
                            }
                            conexion.Close();
                            txtcontra.Enabled = true;
                            txtcontra.Focus();
                            txtusuario.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("El Usuario que usted ingreso no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtusuario.Enabled = true;
                            txtusuario.Clear();
                            txtcontra.Enabled = false;
                        }
                        
                        conexion.Close();
                    }
                   


                }



            }
        }

        private void txtcontra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtcontra.Text.Trim()) || string.IsNullOrEmpty(txtusuario.Text.Trim()))
                {
                    MessageBox.Show("NO puede haber espacios en blancos");
                }
                else
                {
                    conexion.Open();
                    System.Data.SqlClient.SqlCommand comando = new SqlCommand("select US_NOMBRE,US_CONTRASEÑA from Usuarios where US_NOMBRE='" + txtusuario.Text + "' and US_CONTRASEÑA='" + txtcontra.Text + "'", conexion);
                   
                        lector = comando.ExecuteReader();

                        if (lector.Read())
                        {


                        MessageBox.Show("Bienvenido al sistema " + txtusuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clases.clusuario.persona = txtusuario.Text;
                        Clases.clauditoria.auditoria("Acceso al Sistema");
                        Menu frm = new Menu();
                            this.Hide();
                            frm.Show();
                        

                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

                            txtusuario.Enabled = false;
                            txtcontra.Clear();
                            txtcontra.Enabled = true;
                            string ruta1 = "C:/Users/miztl/source/repos/Neveria Definitivo/Neveria Definitivo/Usuarios/";
                            string imagen1 = ruta1 + txtusuario.Text + ".jpg";
                            pictureBox1.Image = Image.FromFile(imagen1);
                        }
                        lector.Close();
                        conexion.Close();
                    
                }

            }
        }

        private void txtcontra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtusuario.Enabled = true;
                txtusuario.Clear();
                txtusuario.Focus();
                txtcontra.Clear();
                txtcontra.Enabled = false;
                string ruta1 = "C:/Users/miztl/source/repos/Neveria Definitivo/Neveria Definitivo/Usuarios/";
                string imagen1 = ruta1 + "chente" + ".png";
                pictureBox1.Image = Image.FromFile(imagen1);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();

        }
    }
}
