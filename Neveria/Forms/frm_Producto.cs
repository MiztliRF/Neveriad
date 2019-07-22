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
    public partial class frm_Producto : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        int Existe;
        public frm_Producto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (txtidp.Text.Trim()=="".Trim())
                {
                    MessageBox.Show("El Id del producto de debe de ir vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtidp.Focus();
                }
                else
                {
                    conexion.Open();
                    string query = "Select * from  Producto where PR_ID=@Pr_ID";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@OP", 1);
                    comando.Parameters.AddWithValue("@Pr_ID",int.Parse( txtidp.Text));
                    comando.Connection = conexion;
                    lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        txtidp.Text = lector["PR_ID"].ToString();
                        txtNombre.Text = lector["PR_NOMBRE"].ToString();
                        txtPrecio.Text = lector["PR_PRECIO"].ToString();
                        Txtexist.Text = lector["PR_EXISTENCIA"].ToString();
                        cboxestatus.Text = lector["PR_ESTATUS"].ToString();
                        lector.Read();
                        conexion.Close();
                        txtNombre.Enabled = true;
                        txtPrecio.Enabled = true;
                        Txtexist.Enabled = true;
                        txtNombre.Focus();
                        txtidp.Enabled = false;
                        btnbuscar.Enabled = false;
                        btnguardar.Enabled = true;
                        Btneliminar.Enabled = true;
                        cboxestatus.Enabled = true;
                    }
                   else
                    {
                        MessageBox.Show("El Producto que usted ingreso no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        DialogResult result = MessageBox.Show("Desea Agregarlo", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result==DialogResult.Yes)
                        {
                            txtidp.Enabled = false;
                            txtNombre.Enabled = true;
                            txtNombre.Focus();
                            btnbuscar.Enabled = false;
                        }
                        if (result==DialogResult.No)
                        {
                            txtidp.Focus();
                            txtidp.Clear();
                            txtNombre.Enabled = false; 
                        }
                        conexion.Close();
                    }

                }
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Error El Nombre no puede ir en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
                else
                {
                    txtNombre.Enabled = false;
                    txtPrecio.Enabled = true;
                    txtPrecio.Focus();
                }
            }
            if(e.KeyCode==Keys.Escape)
            {
                txtidp.Enabled = true;
                txtidp.Focus();
                txtidp.Clear();
                txtNombre.Clear();
                txtNombre.Enabled = false;
            }
        }

        private void Txtexist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Error la existencia  no puede ir en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
                else
                {
                    Txtexist.Enabled = false;
                    cboxestatus.Enabled = true;
                    cboxestatus.Focus();
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cboxestatus.Text.Trim() == "1".Trim()||cboxestatus.Text.Trim()=="True".Trim())
            {
                
                DialogResult result = MessageBox.Show("¿Seguro que quiere hacer ese cambio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    conexion.Close();
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "SP_Producto";
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@OP", 2);
                    comando.Parameters.AddWithValue("@Pr_Id", txtidp.Text);
                    comando.Parameters.AddWithValue("@Pr_Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Pr_Precio ", txtPrecio.Text);
                    comando.Parameters.AddWithValue("@Pr_Existencia ", Txtexist.Text);
                    comando.Parameters.AddWithValue("@Pr_Estatus", cboxestatus.Text);
                    cboxestatus.Text = "1";
                    comando.Connection = conexion;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clases.clauditoria.auditoria("El " + Clases.clusuario.usuario + " Hizo un cambio con el producto " +txtNombre+ " y se encuentra" + cboxestatus );
                    Txtexist.Enabled = false;
                    txtidp.Enabled = true;
                    txtidp.Clear();
                    txtidp.Focus();
                    txtNombre.Clear();
                    txtNombre.Enabled = false;
                    txtPrecio.Clear();
                    txtPrecio.Enabled = false;
                    Txtexist.Clear();
                    cboxestatus.SelectedIndex= - 1;
                    cboxestatus.Enabled = false;
                }
               if(result==DialogResult.No)
                {
                    cboxestatus.Focus();
                }
            }
          else  if (cboxestatus.Text.Trim() == "0".Trim() || cboxestatus.Text.Trim() == "False".Trim())
            {

                DialogResult result = MessageBox.Show("¿Seguro que quiere hacer ese cambio?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    conexion.Close();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_Producto";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@OP", 2);
                comando.Parameters.AddWithValue("@Pr_Id", txtidp.Text);
                comando.Parameters.AddWithValue("@Pr_Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Pr_Precio ", txtPrecio.Text);
                comando.Parameters.AddWithValue("@Pr_Existencia ", Txtexist.Text);
                comando.Parameters.AddWithValue("@Pr_Estatus", cboxestatus.Text);
                cboxestatus.Text = "0";
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                    MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clases.clauditoria.auditoria("El " + Clases.clusuario.usuario + " Hizo un cambio con el producto " + txtNombre + " y se encuentra" + cboxestatus);
                    Txtexist.Enabled = false;
                    txtidp.Enabled = true;
                    txtidp.Clear();
                    txtidp.Focus();
                    txtNombre.Clear();
                    txtNombre.Enabled = false;
                    txtPrecio.Clear();
                    txtPrecio.Enabled = false;
                    Txtexist.Clear();
                    cboxestatus.SelectedIndex = -1;
                    cboxestatus.Enabled = false;
                }
                if (result == DialogResult.No)
                {
                    cboxestatus.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error El Estatus no puede ir Sin  ningun valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboxestatus.Focus();
            }
        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Producto";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 3);
            comando.Parameters.AddWithValue("@Pr_Id", int.Parse(txtidp.Text));
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPrecio.Text == "")
                {
                    MessageBox.Show("Error El Precio  no puede ir en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Focus();
                }
                else
                {
                    txtPrecio.Enabled = false;
                    Txtexist.Enabled = true;
                    Txtexist.Focus();
                }
            }
        }

        private void cboxestatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnguardar.Enabled = true;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
