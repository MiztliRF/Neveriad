using Neveria.Clases;
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
    public partial class Frm_Venta : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=NEVERIAC;Persist Security Info=True;User ID=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        int Existe;
        public Frm_Venta()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clconexion objconexion = new Clconexion();
                SqlConnection conexion = new SqlConnection(objconexion.conexion());
                conexion.Open();
                string query = "select CLI_NOMBRE,CLI_APATERNO,CLI_AMATERNO,CLI_ESTATUS FROM Cliente where CLI_CLAVE=@Clave";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CLAVE", txtcliente.Text);
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        bool estatus = Convert.ToBoolean(lector["CLI_ESTATUS"].ToString());
                        if (estatus == true)
                        {
                            txtclienteN.Text = lector["CLI_NOMBRE" + "CLI_APATERNO" + "CLI_AMATERNO"].ToString();
                        }
                    }
                    txtcliente.Enabled = false;
                    cboxempleado.Enabled = true;
                    cboxempleado.Focus();
                }
                conexion.Close();
            }
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {

        }
        private void cargaempleados()
        {
            NEVERIACDataSet1 dt = new NEVERIACDataSet1();
            Clconexion objconexion = new Clases.Clconexion();
            SqlConnection conexion = new SqlConnection(objconexion.conexion());
            try
            {
                string query = "select US_NOMBRE FROM USUARIOS";
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cboxempleado.DataSource = dt;
                cboxempleado.ValueMember = "US_NOMBRE";
                cboxempleado.DisplayMember = "US_NOMBRE";

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            finally { conexion.Close(); }
        }

        private void cargaconsecutivo()
        {
            Clconexion objconexion = new Clases.Clconexion();
            conexion = new SqlConnection(objconexion.conexion());
            conexion.Open();
            string query = "select  max(ven_id)+1 as consecutivo from VENTAS_GEN";
            SqlCommand cmd = new SqlCommand(query, conexion);
            lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                txtNumVenta.Text = lector["consecutivo"].ToString();
            }
        }

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            cargaconsecutivo();
            cargaempleados();
            txtcliente.Focus();
        }

        private void txtclaveA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clconexion objconexion = new Clases.Clconexion();
                conexion = new SqlConnection(objconexion.conexion());
                conexion.Open();
                string query = "select PR_NOMBRE, PR_PRECIO, PR_ESTATUS from PRODUCTO where PR_ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", txtclaveA.Text);
                lector = cmd.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        bool estatus = Convert.ToBoolean(lector["PR_ESTATUS"].ToString());
                        if (estatus == true)
                        {
                            txtArticulo.Text = lector["PR_NOMBRE"].ToString();
                            txtprecio.Text = lector["PR_PRECIO"].ToString();
                        }
                    }
                    txtprecio.Enabled = true;
                    txtcantidad.Enabled = true;
                    txtcantidad.Focus();
                }
            }
        }
        private double multiplicacion()
        {
            double importe1 = 0;
            if (txtcantidad.Text != "" && txtprecio.Text != "")
            {
                importe1 = Convert.ToDouble(txtprecio.Text) * Convert.ToDouble(txtcantidad.Text);

            }
            return (importe1);
        }
        private void suma()
        {

            double iva = 0;
            double total = 0;
            double subtotal = 0;
            foreach (DataGridViewRow row in DataTable.Rows)
            {
                total += Convert.ToDouble(row.Cells["importe"].Value);
            }
            iva = total * .16;
            subtotal = total - iva;
            txtsubtotal.Text = subtotal.ToString("N2");
            txttotal.Text = total.ToString("N2");
        }

        private void dataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtagregar_Click(object sender, EventArgs e)
        {
            DataTable.Rows.Add(txtclaveA.Text, txtArticulo, txtcantidad.Text, txtprecio.Text, multiplicacion());
            suma();
            txtclaveA.Clear();
            txtArticulo.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtcantidad.Enabled = false;
            txtprecio.Enabled = false;
            txtclaveA.Focus();
        }

        private void btnbuscarArticulo_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Clconexion objconexion = new Clases.Clconexion();
            //    conexion = new SqlConnection(objconexion.conexion());
            //      Frm_BusquedadeA busqueda = new Frm_BusquedadeA("PRODUCTOS");
            //    Clases.cl_globales.query = "SELECT ar_id AS CLAVE, ar_nombre AS ARTICULO, ar_preciounit AS [PRECIO UNITARIO], ar_cantidad AS CANTIDAD, ar_preciocompra AS [PRECIO DE COMPRA], ar_presentacion AS PRESENTACION from ARTICULOS where ar_estatus = 1";
            //    busqueda.ShowDialog();
            //    if (busqueda.id != "")
            //    {
            //        string query = "select * from ARTICULOS where ar_id = @ar_id";
            //        conexion.Open();
            //        SqlCommand cmd = new SqlCommand(query, conexion);
            //        cmd.Parameters.Clear();
            //        cmd.Parameters.AddWithValue("@ar_id", busqueda.id);
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        if (reader.HasRows)
            //        {
            //            while (reader.Read())
            //            {
            //                txtclaveA.Text = reader["ar_id"].ToString();
            //                txtArticulo.Text = reader["ar_nombre"].ToString();
            //                txtprecio.Text = reader["ar_preciounit"].ToString();
            //            }
            //            txtprecio.Enabled = true;
            //            txtcantidad.Enabled = true;
            //            txtcantidad.Focus();
            //        }
            //    }
            //} catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());

            //}
            //finally { conexion.Close(); }
        }

        private void cboxempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtclaveA.Enabled = true;
            txtclaveA.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea terminar la venta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                   Clconexion objconexion = new Clases.Clconexion();
                    conexion = new SqlConnection(objconexion.conexion());
                    conexion.Open();
                    string query = "insert into Venta_general values (@VG_FOLIO, @VG_FECHA,  @VG_FOLIOCLIENTE, @VG_TOTAL)";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@VG_FOLIO", txtNumVenta.Text);
                    cmd.Parameters.AddWithValue("@VG_FECHA", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@VG_FOLIOCLIENTE", txtcliente.Text);
                    cmd.Parameters.AddWithValue("@VG_TOTAL",decimal.Parse (txttotal.Text));
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < DataTable.RowCount; i++)
                    {
                        //inserta en ventasdetalle
                        query = "insert into VENTAS_DET values (@ven_id, @ven_articulo, @ven_cantidad, @ven_importe)";
                        cmd = new SqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@ven_id", txtNumVenta.Text);
                        cmd.Parameters.AddWithValue("@ven_articulo", DataTable.Rows[i].Cells["clave"].Value);
                        cmd.Parameters.AddWithValue("@ven_cantidad", DataTable.Rows[i].Cells["cantidad"].Value);
                        cmd.Parameters.AddWithValue("@ven_importe", DataTable.Rows[i].Cells["importe"].Value);
                        cmd.ExecuteNonQuery();



                    }

                    result = MessageBox.Show("La venta se ha guardado correctamente. ¿Desea imprimir Ticket de venta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {

                        // Impresion del ticket.

                        txtcliente.Clear();
                        txtclienteN.Clear();
                        txtclaveA.Clear();
                        txtArticulo.Clear();
                        txtprecio.Clear();
                        txtcantidad.Clear();
                        DataTable.Rows.Clear();
                       Reporte.reporteVenta2 rpt = new Reporte.reporteVenta2();
                        rpt.SetParameterValue("@ven_id", txtNumVenta.Text);
                       // Reporte.FrmPlantilla plantilla = new Reporte.FrmPlantilla();
                        //plantilla.crystalReportViewer1.ReportSource = rpt;
                        //plantilla.ShowDialog();
                        cargaconsecutivo();
                        txtcliente.Focus();
                    }
                    else
                    {
                        cargaconsecutivo();
                        txtcliente.Clear();
                        txtclienteN.Clear();
                        txtclaveA.Clear();
                        txtArticulo.Clear();
                        txtprecio.Clear();
                        txtcantidad.Clear();
                        DataTable.Rows.Clear();
                        txtcliente.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally { conexion.Close(); }
            }
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtclaveA.Clear();
                txtArticulo.Clear();
                txtprecio.Clear();
                txtcantidad.Clear();
                txtclaveA.Focus();
            }
        }
    } 
}
