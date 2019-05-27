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
    public partial class frm_Clientes : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=Neveria;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();


        System.Data.SqlClient.SqlDataReader lector;
        string colonia, municipio, localidad;
        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Frm_Clientes_B B = new Frm_Clientes_B();
            B.ShowDialog();
            
            if (B.DialogResult == DialogResult.OK)
            {
                txtfolio.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].FOLIO.ToString();
                txtpaterno.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].A_Paterno.ToString();
                txtmaterno.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].A_Materno.ToString();
                txtnombre.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].Nombre1.ToString();
                txtcalle.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].CALLE.ToString();
                txtnexterno.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].NoEXT.ToString();
                txtinterno.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].NoINT.ToString();
                txtcolonia.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].NOMBRE_COLONIA.ToString();
                txtlocalidad.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].NOMBRE_LOCALIDAD.ToString();
                txtmunicipio.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].NOMBRE_MUNICIPIO.ToString();
                txttelefono.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].TELEFONO.ToString();
                txtrfc.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].RFC.ToString();
                txtemail.Text = B.clientedataset.Cliente[B.clientebindigsource.Position].CORREO.ToString();
                colonia = B.clientedataset.Cliente[B.clientebindigsource.Position].ID_Colonia.ToString();
                localidad = B.clientedataset.Cliente[B.clientebindigsource.Position].ID_LOCALIDAD.ToString();
                municipio = B.clientedataset.Cliente[B.clientebindigsource.Position].ID_MUNICIPIO.ToString();
            }
    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Colonia_B C = new Frm_Colonia_B();
            C.ShowDialog();
            if (C.DialogResult == DialogResult.OK)
            {
                // el if(DialogResult == DialogResult.OK) <<<  Bueno ahorita te hablo si sale algo mal <3 i love    oks
                txtcolonia.Text = C.ColoniaDataSet.Colonia[C.ColoniaBindingSource.Position].Nombre.ToString();
                colonia = C.ColoniaDataSet.Colonia[C.ColoniaBindingSource.Position].IDColonia.ToString();
                //colonia = C.ColoniaDataSet.Colonia[C.ColoniaBindingSource.Position].IDColonia.ToString();

            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Cliente";
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
            comando.Parameters.AddWithValue("@Email", txtemail.Text);
            comando.Parameters.AddWithValue("@RFC", txtrfc.Text);
            comando.Parameters.AddWithValue("@id_colonia", colonia);
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se agregado los cambios,correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlocalidad_Click(object sender, EventArgs e)
        {
            Forms.Frm_Localidad_B L = new Frm_Localidad_B();
            L.ShowDialog();
            if (L.DialogResult == DialogResult.OK)
            {
                txtlocalidad.Text = L.LocalidadDataSet.Localidad[L.LocalidadBindingSource.Position].Nombre.ToString();
                localidad = L.LocalidadDataSet.Localidad[L.LocalidadBindingSource.Position].IDLocalidad.ToString();
            }
        }

        private void btnmunicipio_Click(object sender, EventArgs e)
        {
            Forms.Frm_Municipio_B M = new Frm_Municipio_B();
            M.ShowDialog();
            if (M.DialogResult == DialogResult.OK)
            {
                txtmunicipio.Text = M.MunicipioDataSet.Municipio[M.MunicipioBindingSource.Position].Nombre.ToString();
                municipio = M.MunicipioDataSet.Municipio[M.MunicipioBindingSource.Position].IDMunicipio.ToString();
            }
        }

        private void txtfolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcolonia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Cliente";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 3);
            comando.Parameters.AddWithValue("@Folio", int.Parse(txtfolio.Text));
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            CLEAR();
            MessageBox.Show("Se elimino correctamente ", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtfolio_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_Cliente";
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
    }
}
