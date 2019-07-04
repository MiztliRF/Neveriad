using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neveria.Forms
{

    public partial class frm_rusuarios : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        string contraseña;
        int Existe;
        string contraseñaN;
        
        
        public frm_rusuarios()
        {
            InitializeComponent();
        }

        private void frm_rusuarios_Load(object sender, EventArgs e)
        {
            cbcamviarcontraseña.Enabled=false;
            txtusuario.Focus();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNcontraseña.Visible = true;
            lblVcontraseña.Visible = true;

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
                        SqlCommand comando = new SqlCommand(query, conexion);
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@us_nombre", txtusuario.Text);
                        SqlDataReader leer = comando.ExecuteReader();
                        //MessageBox.Show(comando.ToString());
                        //SqlCommand usuario = new SqlCommand("select US_NOMBRE from Usuarios where US_NOMBRE='" + txtusuario.Text, conexion);
                        if (leer.Read())
                        {     
                            try
                            {

                            }
                            catch (Exception ex)
                            {

                                txtcontraseña.Enabled = true;
                                txtcontraseña.Focus();
                                txtusuario.Enabled = false;

                            }
                            contraseña = leer["US_CONTRASEÑA"].ToString();
                             Clases.clusuario.nivel = leer["US_NIVEL"].ToString();
                            cboxnivel.Text = leer["US_NIVEL"].ToString();
                            if (Clases.clusuario.nivel == "1")
                            {
                                Clases.clusuario.nivel = "Administrador";
                                cboxnivel.Text = "Administrador";

                            }
                            if (Clases.clusuario.nivel == "2")
                            {
                                Clases.clusuario.nivel = "Operador";
                                cboxnivel.Text = "Operador";
                            }
                            conexion.Close();
                            txtcontraseña.Enabled = true;
                            txtcontraseña.Focus();
                            txtusuario.Enabled = false;
                            Existe = 1;
                            btn_agregar.Enabled = false;
                            btn_eliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("El Usuario que usted ingreso no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                           DialogResult result= MessageBox.Show("Desea Agregarlo", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result==DialogResult.Yes)
                            {
                                txtusuario.Enabled = false;
                                txtcontraseña.Enabled = true;
                                cbcamviarcontraseña.Enabled = false;
                                txtcontraseña.Focus();
                                

                            }
                            if (result == DialogResult.No)
                            {
                                txtcontraseña.Enabled = false;
                                txtusuario.Enabled = true;
                                txtusuario.Clear();
                                txtusuario.Focus();
                            }
                            
                        }

                        conexion.Close();
                    }



                }



            }
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (txtusuario.Text == "")
            //    {
            //        MessageBox.Show("Error el Usuario no puede ir en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtusuario.Focus();
            //    }
            //    else
            //    {
            //        System.Data.SqlClient.SqlCommand usuario = new SqlCommand("select US_NOMBRE from Usuarios where US_NOMBRE='" + txtusuario.Text, conexion);
            //        conexion.Open();
            //        comando.CommandType = CommandType.StoredProcedure;
            //        comando.CommandText = "SP_Usuarios";
            //        comando.Parameters.Clear();
            //        comando.Parameters.AddWithValue("@OP", 1);
            //        comando.Parameters.AddWithValue("@Nombre", (txtusuario.Text));
            //        comando.Connection = conexion;
            //        lector = comando.ExecuteReader();
            //        if (lector.Read())
            //        {

            //            txtusuario.Text = lector["US_NOMBRE"].ToString();
            //            txtcontraseña.Enabled = true;
            //            cboxnivel.Enabled = true;
            //            txtNcontraseña.Enabled = true;
            //        }
            //        else
            //        {
            //            lector.Close();
            //            conexion.Close();
            //            txtcontraseña.Enabled = true;
            //            txtcontraseña.Focus();

            //        }
            //        txtcontraseña.Enabled = true;
            //        txtcontraseña.Focus();
            //        txtusuario.Enabled = false;
            //    }
            //}

        }

        private void txtcontraseña_KeyDown(object sender, KeyEventArgs e)
        {

           
            
            if (e.KeyCode == Keys.Enter)
            {
                if (txtcontraseña.Text == "")
                {
                    MessageBox.Show("Error la Contraseña no puede ir en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusuario.Focus();
                }
                else
                {
                    if (Existe == 1)
                    {
                        if (contraseña.Trim()==txtcontraseña.Text.Trim())
                        {
                            MessageBox.Show("Contraseña Correcta","Bien",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            cboxnivel.Enabled = true;
                            cboxnivel.Focus();
                            txtcontraseña.Enabled = false;
                            cbcamviarcontraseña.Enabled = true;
                            cbcamviarcontraseña.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                txtusuario.Enabled = true;
                              txtusuario.Clear();
                                 txtusuario.Focus();
                                 txtcontraseña.Clear();
                                txtcontraseña.Enabled = false;
                        }
                        //conexion.Open();
                        //System.Data.SqlClient.SqlCommand comando = new SqlCommand("select US_NOMBRE,US_CONTRASEÑA from Usuarios where US_NOMBRE='" + txtusuario.Text + "' and US_CONTRASEÑA='" + txtcontraseña.Text + "'", conexion);

                        //lector = comando.ExecuteReader();

                        //if (lector.Read())
                        //{
                        //    Menu frm = new Menu();
                        //    this.Hide();
                        //    frm.Show();


                        //    lector.Close();
                        //    conexion.Close();


                        //    comando.CommandType = CommandType.StoredProcedure;
                        //    comando.CommandText = "SP_Usuario";
                        //    comando.Parameters.Clear();
                        //    comando.Parameters.AddWithValue("@OP", 2);
                        //    comando.Parameters.AddWithValue("@Nivel", (cboxnivel.Text));
                        //    comando.Connection = conexion;
                        //    conexion.Open();
                        //    comando.ExecuteNonQuery();
                        //    conexion.Close();


                        //    txtcontraseña.Enabled = true;
                        //    txtcontraseña.Focus();
                        //    txtusuario.Enabled = false;
                        //    txtVcontraseña.Enabled = false;
                        //// }
                        // else
                        // {
                        //     MessageBox.Show("Contraseña Incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //     txtusuario.Enabled = true;
                        //     txtusuario.Clear();
                        //     txtusuario.Focus();
                        //     txtcontraseña.Clear();
                        //     txtcontraseña.Enabled = false;
                        // }
                    }
                    else
                    {
                        txtVcontraseña.Enabled = true;
                        txtVcontraseña.Focus();
                        txtcontraseña.Enabled = false;
                    }

                }

                

                
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtusuario.Enabled = true;
                txtusuario.Focus();
                txtusuario.Clear();
                txtcontraseña.Clear();
                txtcontraseña.Enabled = false;
                cboxnivel.SelectedIndex = -1;
                btn_agregar.Enabled = false;
                btn_eliminar.Enabled = false;

            }

            
        }

        private void txtVcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { if (txtVcontraseña.Text == "")
                {
                    MessageBox.Show("No Puede estar en blanco", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtVcontraseña.Focus();
                }
                else
                {
                    if (txtcontraseña.Text == txtVcontraseña.Text)
                    {
                        cboxnivel.Enabled = true;
                        cboxnivel.Focus();
                        btn_agregar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("La contraseña debe de coincidir,Intentelo otra vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtVcontraseña.Clear();
                        txtVcontraseña.Focus();
                    }
                }
               
            }
            if (e.KeyCode==Keys.Escape)
            {
                txtcontraseña.Enabled = true;
                txtcontraseña.Clear();
                txtcontraseña.Focus();
                txtVcontraseña.Clear();
                txtVcontraseña.Enabled = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (cbcamviarcontraseña.Checked==true)
            {

            if (cboxnivel.Text=="Administrador")
            {
                   DialogResult result=MessageBox.Show("¿Seguro Usted esta Seguro de Hacer esta accion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {


                        cboxnivel.Text = "1";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SP_Usuarios";
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@OP", 2);
                        comando.Parameters.AddWithValue("@Nombre", txtusuario.Text);
                        comando.Parameters.AddWithValue("@Contraseña", txtNcontraseña.Text);
                        comando.Parameters.AddWithValue("@Nivel", cboxnivel.Text);
                        comando.Connection = conexion;
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clases.clusuario.persona = txtusuario.Text;
                        Clases.clauditoria.auditoria("El "+Clases.clusuario.usuario+" Cambio la contraseña del  Usuario "+txtusuario.Text+" y el nivel"+cboxnivel.Text+"a el Nivel Administrador");
                        cleartotal();
                    }
                    if (result == DialogResult.No)
                    {
                        txtVNcontraseña.Focus();
                    }
            }
            if (cboxnivel.Text=="Operador")
            {
                    DialogResult result = MessageBox.Show("¿Seguro Usted esta Seguro de Hacer esta accion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cboxnivel.Text = "2";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SP_Usuarios";
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@OP", 2);
                        comando.Parameters.AddWithValue("@Nombre", txtusuario.Text);
                        comando.Parameters.AddWithValue("@Contraseña", txtNcontraseña.Text);
                        comando.Parameters.AddWithValue("@Nivel", cboxnivel.Text);
                        comando.Connection = conexion;
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clases.clusuario.persona = txtusuario.Text;
                        Clases.clauditoria.auditoria("El " + Clases.clusuario.usuario + " Cambio la contraseña del  Usuario " + txtusuario.Text + " y el nivel" + cboxnivel.Text + "a el Nivel Operador");
                        cleartotal();
                    }
                    if (result == DialogResult.No)
                    {
                        txtVNcontraseña.Focus();


                    }
            }
            else
            {
                MessageBox.Show("Error, No selecciono ningun Nivel para el nuevo usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
            else
            {

                if (cboxnivel.Text == "Administrador")
                {
                    DialogResult result = MessageBox.Show("¿Seguro Usted esta Seguro de Hacer esta accion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cboxnivel.Text = "1";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SP_Usuarios";
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@OP", 2);
                        comando.Parameters.AddWithValue("@Nombre", txtusuario.Text);
                        comando.Parameters.AddWithValue("@Contraseña", txtcontraseña.Text);
                        comando.Parameters.AddWithValue("@Nivel", cboxnivel.Text);
                        comando.Connection = conexion;
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                        MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clases.clusuario.persona = txtusuario.Text;
                        Clases.clauditoria.auditoria("El " + Clases.clusuario.usuario + " Agrego un nuevo  Usuario " + txtusuario.Text + " con el nivel" + cboxnivel.Text);
                        cleartotal();
                    }
                    if (result == DialogResult.No)
                    {
                        cboxnivel.Focus();
                    }
                }
                if (cboxnivel.Text == "Operador")
                {
                    DialogResult result = MessageBox.Show("¿Seguro Usted esta Seguro de Hacer esta accion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        cboxnivel.Text = "2";
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.CommandText = "SP_Usuarios";
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@OP", 2);
                        comando.Parameters.AddWithValue("@Nombre", txtusuario.Text);
                        comando.Parameters.AddWithValue("@Contraseña", txtcontraseña.Text);
                        comando.Parameters.AddWithValue("@Nivel", cboxnivel.Text);
                        comando.Connection = conexion;
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();

                        MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clases.clusuario.persona = txtusuario.Text;
                        Clases.clauditoria.auditoria("El " + Clases.clusuario.usuario + " Agrego un nuevo  Usuario " + txtusuario.Text + " con el nivel" + cboxnivel.Text);
                        cleartotal();
                    }
                    else
                    {
                        cboxnivel.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error, No selecciono ningun Nivel para el nuevo usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void cboxnivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_agregar.Enabled = true;
            btn_eliminar.Enabled = true;

        }

        private void cbcamviarcontraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbcamviarcontraseña.Checked == true)
            {
                lblNcontraseña.Visible = true;
                lblVcontraseña.Visible = true;
                txtNcontraseña.Visible = true;
                txtVNcontraseña.Visible = true;
                txtNcontraseña.Focus();
                btn_agregar.Enabled = false;

            }
            else
            {
                lblNcontraseña.Visible = false;
                lblVcontraseña.Visible = false;
                txtNcontraseña.Visible = false;
                txtVNcontraseña.Visible = false;
                txtNcontraseña.Clear();
                cboxnivel.Focus();
                btn_agregar.Enabled = true;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void txtNcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtVNcontraseña.Focus();
                contraseñaN = txtNcontraseña.Text;
            }
        }

        private void txtVNcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (contraseñaN.Trim() == txtVNcontraseña.Text.Trim())
                {
                    MessageBox.Show("Las Contraseñas Coiciden ", "Bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Open();
                    string query = "Update US_CONTRASEÑA,US_NIVEL from Usuarios where US_NOMBRE =@us_nombre";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Clear();
                    conexion.Close();
                    btn_agregar.Enabled = true;
                    btn_eliminar.Enabled = true;
                    btn_agregar.Focus();
                }
                else
                {
                    MessageBox.Show("Las Contraseñas No Coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVNcontraseña.Focus();
                    txtVNcontraseña.Clear();
                }
            }
        }

        public void cleartotal()
        {
            txtusuario.Enabled = true;
            txtusuario.Focus();
            txtusuario.Clear();
            txtcontraseña.Clear();
            txtNcontraseña.Clear();
            txtVNcontraseña.Clear();
            txtVcontraseña.Clear();
            cboxnivel.SelectedIndex = -1;
            cbcamviarcontraseña.Checked = false;
            cboxnivel.Enabled=false;
        }
    }
}
