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
    public partial class frminfoventa : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        Clases.Clconexion objconexion;

        public frminfoventa()
        {
            InitializeComponent();
        }
       

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Clases.clauditoria.auditoria("Salio de depuracion de movimientos");
            this.Close();
            Clases.clauditoria.auditoria("Acceso al menu");
            Close();
        }

      

        public void cargarprod()
        {
            DataTable dt = new DataTable();
            Clases.Clconexion objconexion = new Clases.Clconexion();
            SqlConnection conexion = new SqlConnection(objconexion.conexion());
            conexion.Open();
            SqlCommand combobox = new SqlCommand("select * from Producto", conexion);
            SqlDataAdapter da = new SqlDataAdapter(combobox);
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["PR_NOMBRE"] = "Seleccionar Producto";
            dt.Rows.InsertAt(dr, 0);
     
            this.cboxproducto.DataSource = dt;
            this.cboxproducto.ValueMember = "PR_ID";
            this.cboxproducto.DisplayMember = "PR_NOMBRE";
            conexion.Close();

          
        }

        private void frminfoventa_Load(object sender, EventArgs e)
        {
            Clases.clauditoria.auditoria("Acceso al formulario de depuracion de ventas");
           
            cargarprod();
     
        }

        private void rbtntodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtntodos.Checked==true)
            {
                btnmostrar.Enabled = true;

          
                cboxproducto.SelectedIndex = 0;
                cboxproducto.Enabled = false;
                dataGridView1.Rows.Clear();
            }
        }

        private void rbtnusuario_CheckedChanged(object sender, EventArgs e)
        {
            btnmostrar.Enabled = true;
            
            cboxproducto.SelectedIndex = 0;
            cboxproducto.Enabled = false;
        }

        private void rbtnproducto_CheckedChanged(object sender, EventArgs e)
        {
            btnmostrar.Enabled = true;
            cboxproducto.Enabled = true;
            dataGridView1.Rows.Clear();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
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
                if (rbtntodos.Checked == true)
                {
                    Clases.clauditoria.auditoria("Visualizo movimientos de todos de depuracion de venta");
                    objconexion = new Clases.Clconexion();
                    conexion = new SqlConnection(objconexion.conexion());
                    conexion.Open();
                    string query = "Select * from infoventa where VG_FECHA >= @del and VG_FECHA <= @hasta order by VG_FECHA";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@del", dtfechainicial.Value);
                    comando.Parameters.AddWithValue("@hasta", dtfechafinal.Value);
                    SqlDataReader leer = comando.ExecuteReader();

                    while (leer.Read())
                    {


                        string folio, fecha, desc,cp,cantidad,precio,importe;
                        folio = leer["VD_FOLIOVENTA"].ToString();
                        fecha = leer["VG_FECHA"].ToString();
                        cantidad = leer["VD_CANTIDAD"].ToString();
                        precio = leer["VD_PRECIO"].ToString();
                        importe = leer["IMPORTE"].ToString();
                        cp = leer["VD_CLAVEP"].ToString();
                        desc = leer["PR_NOMBRE"].ToString();

                        int renglon = dataGridView1.Rows.Add();

                        dataGridView1.Rows[renglon].Cells["FV"].Value = folio;

                        dataGridView1.Rows[renglon].Cells["Fecha"].Value = fecha;
                        dataGridView1.Rows[renglon].Cells["Cantidad"].Value = cantidad;
                        dataGridView1.Rows[renglon].Cells["Precio"].Value = precio;
                        dataGridView1.Rows[renglon].Cells["Importe"].Value = importe;
                        dataGridView1.Rows[renglon].Cells["CP"].Value = cp;
                        dataGridView1.Rows[renglon].Cells["Producto"].Value = desc;
                    }
                    conexion.Close();


                }

                if (rbtnproducto.Checked == true)
                {
                    if(cboxproducto.SelectedIndex == 0)
                    {
                        MessageBox.Show("Porfavor seleccione un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Clases.clauditoria.auditoria("Visualizo movimientos por usuario de depuracion de movimientos");
                        objconexion = new Clases.Clconexion();
                        conexion = new SqlConnection(objconexion.conexion());
                        conexion.Open();
                        string query = "Select * from INFOVENTA where VG_FECHA >= @del and VG_FECHA <= @hasta  and  VD_CLAVEP = @PRODUCTO order by VG_FECHA";
                        SqlCommand comando = new SqlCommand(query, conexion);
                        comando.Parameters.Clear();
                        comando.Parameters.AddWithValue("@del", dtfechainicial.Value);
                        comando.Parameters.AddWithValue("@hasta", dtfechafinal.Value);
                        comando.Parameters.AddWithValue("@PRODUCTO", cboxproducto.SelectedValue);
                        SqlDataReader leer = comando.ExecuteReader();


                        while (leer.Read())
                        {
                            string folio, fecha, desc, cp, cantidad, precio, importe;
                            folio = leer["VD_FOLIOVENTA"].ToString();
                            fecha = leer["VG_FECHA"].ToString();
                            cantidad = leer["VD_CANTIDAD"].ToString();
                            precio = leer["VD_PRECIO"].ToString();
                            importe = leer["IMPORTE"].ToString();
                            cp = leer["VD_CLAVEP"].ToString();
                            desc = leer["PR_NOMBRE"].ToString();

                            int renglon = dataGridView1.Rows.Add();

                            dataGridView1.Rows[renglon].Cells["FV"].Value = folio;

                            dataGridView1.Rows[renglon].Cells["Fecha"].Value = fecha;
                            dataGridView1.Rows[renglon].Cells["Cantidad"].Value = cantidad;
                            dataGridView1.Rows[renglon].Cells["Precio"].Value = precio;
                            dataGridView1.Rows[renglon].Cells["Importe"].Value = importe;
                            dataGridView1.Rows[renglon].Cells["CP"].Value = cp;
                            dataGridView1.Rows[renglon].Cells["Producto"].Value = desc;

                        }
                    }

                }
            }
        }

        private void Btnimprimir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
