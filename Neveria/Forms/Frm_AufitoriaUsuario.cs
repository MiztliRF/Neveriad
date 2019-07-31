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
    public partial class Frm_AufitoriaUsuario : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        Clases.Clconexion objconexion;
        string accion = "Entro a ventana de depuracion de movimientos";
        string accion2 = "Realizo Venta";
        string accion3 = "Salio de ventana de ventas";
        public Frm_AufitoriaUsuario()
        {
            InitializeComponent();
        }
        public void cargaruser()
        {
            DataTable dt = new DataTable();
            //establezcp conexion
            objconexion = new Clases.Clconexion();
            conexion = new System.Data.SqlClient.SqlConnection(objconexion.conexion());
            conexion.Open();
            SqlCommand combobox = new SqlCommand("SELECT US_NOMBRE,US_NOMBRE as NOMBRE  FROM Usuarios", conexion);

            SqlDataAdapter da = new SqlDataAdapter(combobox);
            //leno el data table
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["nombre"] = "Seleccionar Usuario";
            dt.Rows.InsertAt(dr, 0);
            this.cboxusuario.DataSource = dt;
            //establesco como fuente de edatos del combobox el data table
            //defino los campos de la tabla
            this.cboxusuario.ValueMember = "US_NOMBRE";
            this.cboxusuario.DisplayMember = "nombre";
            conexion.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Clases.clauditoria.auditoria("Acceso al formulario de depuracion de movimientos");
            cargaruser();
        }

        private void rbttodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbttodos.Checked == true)
            {
                cboxusuario.Enabled = false;
                cboxusuario.SelectedIndex = 0;
                dataGridView1.Rows.Clear();
                brnmostrar.Enabled = true;

            }
        }

        private void rbtusuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtusuario.Enabled == true)
            {
                cboxusuario.Enabled = true;
                dataGridView1.Rows.Clear();
                brnmostrar.Enabled = true;
            }
        }

        private void brnmostrar_Click(object sender, EventArgs e)
        {

            dtfechainicial.Value = DateTime.Parse(dtfechainicial.Text);
            dtfechafinal.Value = DateTime.Parse(dtfechafinal.Text);
            if (dtfechainicial.Value > dtfechafinal.Value)
            {
                dataGridView1.Rows.Clear();

                MessageBox.Show("Verifique la fecha Por favor", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbttodos.Checked == true)
                {
                    Clases.clauditoria.auditoria("Visualizo movimientos de todos de depuracion de movimientos");
                    objconexion = new Clases.Clconexion();
                    conexion = new SqlConnection(objconexion.conexion());
                    conexion.Open();
                    string query = "Select * from Auditoria where AU_FECHA >= @del and AU_FECHA <= @hasta order by AU_FECHA";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@del", dtfechainicial.Value);
                    comando.Parameters.AddWithValue("@hasta", dtfechafinal.Value);
                    SqlDataReader leer = comando.ExecuteReader();


                    while (leer.Read())
                    {


                        string user, fecha, desc;
                        user = leer["AU_USUARIO"].ToString();
                        fecha = leer["AU_FECHA"].ToString();

                        desc = leer["AU_DESCRIP"].ToString();

                        btneliminar.Enabled = true;
                        int renglon = dataGridView1.Rows.Add();

                        dataGridView1.Rows[renglon].Cells["Usuario"].Value = user;
                        
                        dataGridView1.Rows[renglon].Cells["Fecha"].Value = fecha;
                        dataGridView1.Rows[renglon].Cells["Descripcion"].Value = desc;
                        rbttodos.Checked = false;
                        rbttodos.Enabled = false;
                    }
                    conexion.Close();


                }
                else if (rbtusuario.Checked == true)
                {
                    if (cboxusuario.SelectedIndex == 0)
                    {
                        MessageBox.Show("Porfavor seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Clases.clauditoria.auditoria("Visualizo movimientos por usuario de depuracion de movimientos");
                        objconexion = new Clases.Clconexion();
                        conexion = new SqlConnection(objconexion.conexion());
                        conexion.Open();
                        string query = "Select * from Auditoria where AU_FECHA >= @del and AU_FECHA <= @hasta  and AU_USUARIO = @usuario order by AU_FECHA";
                        SqlCommand comando = new SqlCommand(query, conexion);
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@del", dtfechainicial.Value);
                        comando.Parameters.AddWithValue("@hasta", dtfechafinal.Value);
                        comando.Parameters.AddWithValue("@usuario", cboxusuario.SelectedValue);
                        SqlDataReader leer = comando.ExecuteReader();


                        while (leer.Read())
                        {


                            string user, fecha, time, desc;
                            user = leer["AU_USUARIO"].ToString();
                            fecha = leer["AU_FECHA"].ToString();

                            desc = leer["AU_DESCRIP"].ToString();

                            btneliminar.Enabled = true;
                            int renglon = dataGridView1.Rows.Add();

                            dataGridView1.Rows[renglon].Cells["Usuario"].Value = user;
                            dataGridView1.Rows[renglon].Cells["Descripcion"].Value = desc;
                            dataGridView1.Rows[renglon].Cells["Fecha"].Value = fecha;
                            brnmostrar.Enabled = false;

                        }
                        conexion.Close();
                    }

                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Clases.clauditoria.auditoria("Salio de depuracion de movimientos");
            this.Close();
            Clases.clauditoria.auditoria("Acceso al menu");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar?... La informacion no se podra recuperar ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (rbttodos.Checked == true)
                {

                    Clases.clauditoria.auditoria("Elimino registros de todos de depuracion de movimientos");
                    objconexion = new Clases.Clconexion();
                    conexion = new SqlConnection(objconexion.conexion());
                    conexion.Open();
                    string query = "delete from Auditoria where au_fecha >= @del and au_fecha <= @hasta";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@del", dtfechainicial.Value);
                    comando.Parameters.AddWithValue("@hasta", dtfechafinal.Value);


                    comando.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();

                    MessageBox.Show("Borrado Correctamente.", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboxusuario.SelectedIndex = 0;
                    rbttodos.Checked = false;
                    rbtusuario.Checked = false;


                    conexion.Close();
                }

                else if (rbtusuario.Checked == true)
                {
                    Clases.clauditoria.auditoria("Elimino registros por usuario de depuracion de movimientos");
                    objconexion = new Clases.Clconexion();
                    conexion = new SqlConnection(objconexion.conexion());
                    conexion.Open();
                    string query = "delete from Auditoria where au_fecha >= @del and au_fecha <= @hasta and au_usuario = @usuario";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@del", dtfechainicial.Value);
                    comando.Parameters.AddWithValue("@hasta", dtfechafinal.Value);
                    comando.Parameters.AddWithValue("@usuario", cboxusuario.SelectedValue);


                    comando.ExecuteNonQuery();
                    dataGridView1.Rows.Clear();

                    MessageBox.Show("Borrado Correctamente.", "◄ AVISO ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboxusuario.SelectedIndex = 0;
                    rbttodos.Checked = false;
                    rbtusuario.Checked = false;

                    conexion.Close();
                }

            }
        }

        private void cboxusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            brnmostrar.Enabled = true;
        }
    }
}
