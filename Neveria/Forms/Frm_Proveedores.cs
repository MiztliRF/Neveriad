 
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


    public partial class Frm_Proveedores : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=Neveria;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();


        System.Data.SqlClient.SqlDataReader lector;
        string colonia, municipio, localidad;
        public Frm_Proveedores()
        {
            InitializeComponent();

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Proveedores";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 2);
            comando.Parameters.AddWithValue("@Folio", int.Parse(txtfolio.Text));
            comando.Parameters.AddWithValue("@A_Paterno", txtpaterno.Text);
            comando.Parameters.AddWithValue("@A_Materno", txtmaterno.Text);
            comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@Calle", txtcalle.Text);
            comando.Parameters.AddWithValue("@Num_Ext", int.Parse(txtnexterno.Text));
            comando.Parameters.AddWithValue("@Num_Int", int.Parse(txtinterno.Text));
            comando.Parameters.AddWithValue("@Telefono", txttelefono.Text);
            comando.Parameters.AddWithValue("@RFC", txtrfc.Text);
            comando.Parameters.AddWithValue("@Email", txtemail.Text);
            comando.Parameters.AddWithValue("@id_colonia", colonia);

            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Proveedores";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 3);
            comando.Parameters.AddWithValue("@Folio", int.Parse(txtfolio.Text));
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            CLEAR();
            MessageBox.Show("Se a eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void CLEAR()
        {
            txtpaterno.Clear();
            txtmaterno.Clear();
            txtnombre.Clear();
            txtinterno.Clear();
            txtnexterno.Clear();
            txtlocalidad.Clear();
            txtmunicipio.Clear();
            txtcalle.Clear();
            txtcolonia.Clear();
            txtrfc.Clear();
            txttelefono.Clear();
            txtemail.Clear();
            txtfolio.Focus();

        }
            
            
            

        private void txtfolio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_Proveedores";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@OP", 1);
                comando.Parameters.AddWithValue("@Folio", int.Parse(txtfolio.Text));
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtfolio.Text = lector["Folio"].ToString();
                    txtpaterno.Text = lector["A_Paterno"].ToString();
                    txtmaterno.Text = lector["A_Materno"].ToString();
                    txtnombre.Text = lector["Nombre"].ToString();
                    txtcalle.Text = lector["Calle"].ToString();
                    txtnexterno.Text = lector["Num_Ext"].ToString();
                    txtinterno.Text = lector["Num_Int"].ToString();
                    txttelefono.Text = lector["Telefono"].ToString();
                    txtrfc.Text = lector["RFC"].ToString();
                    txtemail.Text = lector["Email"].ToString();
                    txtcolonia.Text = lector["ID_Colonia"].ToString();

                }
                lector.Close();
                conexion.Close();
            }
        }

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetcolonia.Colonia' Puede moverla o quitarla según sea necesario.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_proveedores_B B = new Frm_proveedores_B(conexion.ConnectionString);
            B.ShowDialog();
            if (B.DialogResult == DialogResult.OK)
            {
                txtfolio.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].FOLIO.ToString();
                txtpaterno.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].A_Paterno.ToString();
                txtmaterno.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].A_Materno.ToString();
                txtnombre.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].Nombre1.ToString();
                txtcalle.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].CALLE.ToString();
                txtnexterno.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].NoEXT.ToString();
                txtinterno.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].NoINT.ToString();
                txtcolonia.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].NOMBRE_COLONIA.ToString();
                txtlocalidad.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].NOMBRE_LOCALIDAD.ToString();
                txtmunicipio.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].NOMBRE_MUNICIPIO.ToString();
                txttelefono.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].TELEFONO.ToString();
                txtrfc.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].RFC.ToString();
                txtemail.Text = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].CORREO.ToString();
                colonia = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].ID_Colonia.ToString();
                localidad = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].ID_LOCALIDAD.ToString();
                municipio = B.datasetprovedores.Proveedor[B.provedoresbindingsource.Position].ID_MUNICIPIO.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Forms.Frm_Localidad_B L = new Frm_Localidad_B();
            L.ShowDialog();
            if (L.DialogResult == DialogResult.OK)
            {
                txtlocalidad.Text = L.LocalidadDataSet.Localidad[L.LocalidadBindingSource.Position].Nombre.ToString();
                localidad = L.LocalidadDataSet.Localidad[L.LocalidadBindingSource.Position].IDLocalidad.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.Frm_Municipio_B M = new Frm_Municipio_B();
            M.ShowDialog();
            if (M.DialogResult==DialogResult.OK)
            {
                txtmunicipio.Text = M.MunicipioDataSet.Municipio[M.MunicipioBindingSource.Position].Nombre.ToString();
                municipio = M.MunicipioDataSet.Municipio[M.MunicipioBindingSource.Position].IDMunicipio.ToString();
            }
        }

        private void txtrfc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncerrarhijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncoloniab_Click(object sender, EventArgs e)
        {
            Frm_Colonia_B C = new Frm_Colonia_B();
            C.ShowDialog();
            if (C.DialogResult == DialogResult.OK)
            {
                // el if(DialogResult == DialogResult.OK) <<<  Bueno ahorita te hablo si sale algo mal <3 i love    oks
                txtcolonia.Text = C.ColoniaDataSet.Colonia[C.ColoniaBindingSource.Position].Nombre.ToString();
                colonia = C.ColoniaDataSet.Colonia[C.ColoniaBindingSource.Position].IDColonia.ToString();

            }
        }
    }
    }