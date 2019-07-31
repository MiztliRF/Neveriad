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
    public partial class Frm_Cliente : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        int Existe;
        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtclave.Text == "")
                {
                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtclave.Focus();
                    txtclave.Clear();

                }
                else
                {
                    conexion.Open();
                    string query = "Select  * from Cliente where CLI_CLAVE=@clave";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@clave", int.Parse(txtclave.Text));
                    lector = comando.ExecuteReader();
                    if (lector.Read())
                    {
                        try
                        {

                        }
                        catch (Exception ex)
                        {
                            txtAp.Enabled = true;
                            txtAp.Focus();
                            txtAp.Enabled = false;
                        }

                        txtAp.Text = lector["CLI_APATERNO"].ToString();
                        txtAm.Text = lector["CLI_AMATARNO"].ToString();
                        txtnombre.Text = lector["CLI_NOMBRE"].ToString();
                        txtcalle.Text = lector["CLI_CALLE"].ToString();
                        txtne.Text = lector["CLI_NEXTERIOR"].ToString();
                        txtni.Text = lector["CLI_NINTERIOR"].ToString();
                        txttelefono.Text = lector["CLI_TELEFONO"].ToString();
                        txtrfc.Text = lector["CLI_RFC"].ToString();
                        txtemail.Text = lector["CLI_EMAIL"].ToString();
                        cbcolonia.Text = lector["CLI_COLONIA"].ToString();
                        conexion.Close();
                        txtAp.Enabled = true;
                        txtAm.Enabled = true;
                        txtnombre.Enabled = true;
                        txtcalle.Enabled = true;
                        txtne.Enabled = true;
                        txtni.Enabled = true;
                        txttelefono.Enabled = true;
                        txtrfc.Enabled = true;
                        txtemail.Enabled = true;
                        cbcolonia.Enabled = true;
                        Existe = 1;
                        txtclave.Enabled = false;
                        btnagregar.Enabled = true;
                        btneliminar.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("El Cliente que usted ingreso no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        DialogResult result = MessageBox.Show("Desea Agregarlo", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            txtclave.Enabled = false;
                            txtAp.Enabled = true;
                            txtAp.Focus();

                        }
                        if (result == DialogResult.No)
                        {
                            txtclave.Clear();
                            txtAp.Enabled = false;
                            txtclave.Focus();
                        }
                        Existe = 0;

                    }
                    conexion.Close();
                    //   lector
                }
            }
        }

        private void txtAp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txtAm.Enabled = true;
                    txtAm.Focus();
                    txtAp.Enabled = false;
                }
            }
            if(e.KeyCode==Keys.Escape)
            {
                txtclave.Enabled = true;
                txtclave.Focus();
                txtAp.Clear();
                txtAp.Enabled = false;
            }

        }

        private void txtAm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txtnombre.Enabled = true;
                    txtnombre.Focus();
                    txtAm.Enabled = false;
                }
            }
            if (e.KeyCode==Keys.Escape)
            {
                txtAp.Enabled = true;
                txtAp.Focus();
                txtAm.Clear();
                txtAm.Enabled = false;
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txtcalle.Enabled = true;
                    txtcalle.Focus();
                    txtnombre.Enabled = false;
                }
            }
            if (e.KeyCode==Keys.Escape)
            {
                txtAm.Enabled = true;
                txtAm.Focus();
                txtnombre.Clear();
                txtnombre.Enabled = false;
            }
        }

        private void txtcalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txtne.Enabled = true;
                    txtne.Focus();
                    txtcalle.Enabled = false;
                }
            }
            if (e.KeyCode==Keys.Escape)
            {
                txtnombre.Enabled = true;
                txtnombre.Focus();
                txtcalle.Clear();
                txtcalle.Enabled = false;
            }
        }

        private void txtne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txtni.Enabled = true;
                    txtni.Focus();
                    txtne.Enabled = false;
                }
            }
        }

        private void txtni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txttelefono.Enabled = true;
                    txttelefono.Focus();
                    txtni.Enabled = false;
                }
            }
        }

        private void txttelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txtrfc.Enabled = true;
                    txtrfc.Focus();
                    txttelefono.Enabled = false;
                }
            }
        }

        private void txtrfc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    txtemail.Enabled = true;
                    txtemail.Focus();
                    txtrfc.Enabled = false;
                }
            }
        }

        private void cbcolonia_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnagregar.Enabled = true;

        }

        private void cbcolonia_KeyDown(object sender, KeyEventArgs e)
        {
            btnagregar.Enabled = true;
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAp.Text == "")
                {

                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                }
                else
                {
                    cbcolonia.Enabled = true;
                    cbcolonia.Focus();
                    txtemail.Enabled = false;
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbcolonia.Text == "")
            {
                MessageBox.Show("Error, No selecciono ninguna Colonia para el nuevo usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Seguro Usted esta Seguro de Hacer esta accion?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "SP_Cliente";
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@OP", 2);
                    comando.Parameters.AddWithValue("@Cli_Id", int.Parse(txtclave.Text));
                    comando.Parameters.AddWithValue("@Cli_Ap", txtAp.Text);
                    comando.Parameters.AddWithValue("@Cli_Am", txtAm.Text);
                    comando.Parameters.AddWithValue("@Cli_Nombre", txtnombre.Text);
                    comando.Parameters.AddWithValue("@Cli_Calle", txtcalle.Text);
                    comando.Parameters.AddWithValue("@Cli_Ne", int.Parse(txtne.Text));
                    comando.Parameters.AddWithValue("@Cli_Ni", int.Parse(txtni.Text));
                    comando.Parameters.AddWithValue("@Cli_Telefono", txttelefono.Text);
                    comando.Parameters.AddWithValue("@Cli_Email", txtemail.Text);
                    comando.Parameters.AddWithValue("@Cli_RFC", txtrfc.Text);
                    comando.Parameters.AddWithValue("@Cli_Colonia", cbcolonia.SelectedValue);
                    comando.Parameters.AddWithValue("@Cli_Estatus",1);
                    comando.Connection = conexion;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clases.clauditoria.auditoria("Realizo un cambio en el catalgo de cliente con el ID " +txtclave+" Con el Nombre "+ txtnombre);
                    cleartotal();
                }
            }

        }

        public void cleartotal()
        {
            txtAp.Clear();
            txtAp.Enabled = false;
            txtAm.Clear();
            txtAm.Enabled = false;
            txtnombre.Enabled = false;
            txtnombre.Clear();
            txtcalle.Enabled = false;
            txtcalle.Clear();
            txtne.Enabled = false;
            txtni.Clear();
            txtne.Clear();
            txtni.Enabled = false;
            txttelefono.Enabled = false;
            txttelefono.Clear();
            txtemail.Enabled = false;
            txtemail.Clear();
            txtrfc.Enabled = false;
            txtrfc.Clear();
            cbcolonia.Enabled = false;
            cbcolonia.SelectedIndex = -1;
            btnagregar.Enabled = false;
            txtclave.Clear();
            txtclave.Enabled = true;
            txtclave.Focus();


        }
        public void rellenar()
        {
            DataTable dt = new DataTable();
            conexion.Open();
            SqlCommand combo = new SqlCommand("select * from Colonia", conexion);
            SqlDataAdapter da = new SqlDataAdapter(combo);
            da.Fill(dt);
            conexion.Close();
            this.cbcolonia.DataSource = dt;
            this.cbcolonia.ValueMember = "CO_ID";
            this.cbcolonia.DisplayMember = "CO_NOMBRE";
            conexion.Close();
        }
        private void Frm_Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dATASETCOLONIA.Colonia' Puede moverla o quitarla según sea necesario.
            // this.coloniaTableAdapter1.Fill(this.dATASETCOLONIA.Colonia);
            // TODO: esta línea de código carga datos en la tabla 'nEVERIACcolonia.Colonia' Puede moverla o quitarla según sea necesario.
            //this.coloniaTableAdapter.Fill(this.nEVERIACcolonia.Colonia);
            rellenar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void cargaconsecutivo()
        {
            Clases.Clconexion objconexion = new Clases.Clconexion();
            conexion = new SqlConnection(objconexion.conexion());
            conexion.Open();
            string query = "select  max(CLI_CLAVE)+1 as consecutivo from Cliente";
            SqlCommand cmd = new SqlCommand(query, conexion);
            lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                txtclave.Text = lector["consecutivo"].ToString();
            }
        }
    }
}
