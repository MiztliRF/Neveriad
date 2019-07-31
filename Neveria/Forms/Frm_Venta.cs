using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
        Clases.Clconexion objconexion;
        int Existe;
        public Frm_Venta()
        {
            InitializeComponent();
        }

        public void cargarcliente()
        {
            DataTable dt = new DataTable();
            Clconexion objconexion = new Clconexion();
            SqlConnection conexion = new SqlConnection(objconexion.conexion());
            SqlCommand combobox = new SqlCommand("select * from Cliente", conexion);
            SqlDataAdapter da = new SqlDataAdapter(combobox);
            da.Fill(dt);
            this.cboxcliente.DataSource = dt;
            this.cboxcliente.ValueMember = "CLI_CLAVE";
            this.cboxcliente.DisplayMember = "CLI_NOMBRE";
            conexion.Close();

      
        }
        public void rellenarproducto()
        {
            
                DataTable dt = new DataTable();
                Clconexion objconexion = new Clconexion();
                SqlConnection conexion = new SqlConnection(objconexion.conexion());
                conexion.Open();
                SqlCommand combobox = new SqlCommand("select * from Producto", conexion);
                SqlDataAdapter da = new SqlDataAdapter(combobox);
                da.Fill(dt);
                this.comboarticulo.DataSource = dt;
                this.comboarticulo.ValueMember = "PR_ID";
                this.comboarticulo.DisplayMember = "PR_NOMBRE";
                conexion.Close();

                AutoCompleteStringCollection colectar = new AutoCompleteStringCollection();
                foreach (DataRow Row in dt.Rows)
                {
                    colectar.Add(Convert.ToString(Row["PR_NOMBRE"]));
                }
                comboarticulo.AutoCompleteCustomSource = colectar;
                comboarticulo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboarticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
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
                string query = "select CLI_NOMBRE FROM Cliente where CLI_CLAVE=@Clave";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Clave", txtcliente.Text);
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {

                    txtnombrec.Text = lector["CLI_NOMBRE"].ToString();
                    txtcliente.Enabled = false;
                    //cboxempleado.Enabled = true;
                    //cboxempleado.Focus();
                    btnbuscarcliente.Enabled = false;
                }
                conexion.Close();
            }
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            cboxcliente.Visible = true;
        }
        private void cargaempleados()
        {
            //NEVERIACDataSet1 dt = new NEVERIACDataSet1();
            //Clconexion objconexion = new Clases.Clconexion();
            //SqlConnection conexion = new SqlConnection(objconexion.conexion());
            //try
            //{
            //    string query = "select US_NOMBRE FROM Usuarios";
            //    conexion.Open();
            //    SqlCommand cmd = new SqlCommand(query, conexion);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    cboxempleado.DataSource = dt;
            //    cboxempleado.ValueMember = "US_NOMBRE";

            //}
            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.ToString());
            //}
            //finally { conexion.Close(); }
        }

        //private void cargaconsecutivo()
        //{
        //    Clconexion objconexion = new Clases.Clconexion();
        //    conexion = new SqlConnection(objconexion.conexion());
        //    conexion.Open();
        //    string query = "select  max(VG_FOLIO)+1 as consecutivo from Venta_general";
        //    SqlCommand cmd = new SqlCommand(query, conexion);
        //    lector = cmd.ExecuteReader();
        //    if (lector.Read())
        //    {
        //        txtNumVenta.Text = lector["consecutivo"].ToString();
        //    }
        //}

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            cargarcliente();
            rellenarproducto();
            //cargaconsecutivo();
            //cargaempleados();
            txtcliente.Focus();
            maximo();
            //Clases.ClConsecutivo cons = new Clases.ClConsecutivo();
            //txtNumVenta.Text = cons.consecutivos("VG_FOLIO","Venta_general");
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
                            comboarticulo.Text = lector["PR_NOMBRE"].ToString();
                            txtprecio.Text = lector["PR_PRECIO"].ToString();
                        }
                    }
                    
                    txtprecio.Enabled = true;
                    txtcantidad.Enabled = true;
                    txtcantidad.Focus();
                }
                conexion.Close();
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
                total += Convert.ToDouble(row.Cells["Importe"].Value);
            }
            iva = total * .16;
            subtotal = total - iva;
          
            txttotal.Text = total.ToString("N2");
        }

        private void dataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void txtagregar_Click(object sender, EventArgs e)
        {
       
    

            dsdetalless.Sp_DetalleRow r;
            r = dsdetalless.Sp_Detalle.NewSp_DetalleRow();
            r.VD_FOLIOVENTA = int.Parse(txtNumVenta.Text);
            r.VD_CLAVEP = short.Parse(txtclaveA.Text);
            r.PR_NOMBRE = comboarticulo.Text;
            r.VD_CANTIDAD = decimal.Parse(txtcantidad.Text);
            r.VD_PRECIO = decimal.Parse(txtprecio.Text);
            r.Importe = decimal.Parse(txtimporte.Text);
            dsdetalless.Sp_Detalle.AddSp_DetalleRow(r);

         

            suma();
        }
        public void CargarClientes()
        {

            //DataTable dt = new DataTable();
            //Clconexion Objconexion = new Clases.Clconexion();
            //conexion = new SqlConnection(objconexion.conexion());
            //conexion.Open();
            //SqlCommand combobox = new SqlCommand("SELECT CLI_CLAVE, CLI_NOMBRE +' '+ CLI_APATERNO +' '+ CLI_AMATARNO as NombreCompleto FROM Cliente", conexion);
            //SqlDataAdapter da = new SqlDataAdapter(combobox);
            //da.Fill(dt);

            //this.cboxcliente.DataSource = dt;
            //this.cboxcliente.ValueMember = "cl_id";
            //this.cboxcliente.DisplayMember = "NombreCompleto";
            //conexion.Close();

            ////AutoCompleteStringCollection colectar = new AutoCompleteStringCollection();
            ////foreach (DataRow Row in dt.Rows)
            ////{
            ////    colectar.Add(Convert.ToString(Row["NombreCompleto"]));
            ////}
            ////cboxcliente.AutoCompleteCustomSource = colectar;
            ////cboxcliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ////cboxcliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void maximo()
        {
            Clconexion objconexion = new Clconexion();
            SqlConnection conexion = new SqlConnection(objconexion.conexion());
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT isnull(MAX(VG_FOLIO),0)+1 AS ultimo from Venta_general", conexion);

            SqlDataReader Lector = comando.ExecuteReader();
            if (Lector.Read())
            {
                txtNumVenta.Text = Lector["ultimo"].ToString();
            }
            conexion.Close();
        }

        private void btnbuscarArticulo_Click(object sender, EventArgs e)
        {
            Forms.Frm_BusquedadeA frm_BusquedadeA = new Frm_BusquedadeA();
            frm_BusquedadeA.ShowDialog();

        }

        private void cboxempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtclaveA.Enabled = true;
            //txtclaveA.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpago.Text.ToString().Trim()) && (string.IsNullOrEmpty(txtcambio.Text.ToString().Trim())))
            {
                MessageBox.Show("Faltan campos vacios, Pago y Cambio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea terminar la venta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    Clases.clauditoria.auditoria("Se realizo una venta, Folio:" + " " + txtclaveA.Text);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "SP_VENTAGENERAL";
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@OP", 2);
                    comando.Parameters.AddWithValue("@FOLIO", int.Parse(txtNumVenta.Text));
                    comando.Parameters.AddWithValue("@FECHA", dateTimePicker1.Value);
                    comando.Parameters.AddWithValue("@IDCLIENTE", int.Parse(txtcliente.Text));
                    comando.Parameters.AddWithValue("@TOTAL", decimal.Parse(txttotal.Text));
                    comando.Parameters.AddWithValue("@ESTADO", 1);
                    System.Data.SqlClient.SqlParameter p = comando.Parameters.AddWithValue("@DETALLE",dsdetalless.Sp_Detalle);
                    p.SqlDbType = SqlDbType.Structured;
                    p.TypeName = "detalles_type_BUENO2";

                    comando.Connection = conexion;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    DialogResult R = MessageBox.Show("Venta Realizada, Desea Imprimir Ticket?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    {
                        if (DialogResult.Yes == R)
                        {
                            Clases.clauditoria.auditoria("Se imprimio ticket, Folio ticket:" + " " + txtclaveA.Text);
                            Forms.frmreporte reporte = new frmreporte();

                            ConnectionInfo oConexInfo;
                            Tables oListaTablas;
                            //Table oTabla;
                            TableLogOnInfo oTablaConexInfo;
                            oConexInfo = new ConnectionInfo();
                            oConexInfo.ServerName = @"LAPTOP-ED3OPSO6\MIZTLI";
                            oConexInfo.DatabaseName = "NEVERIAC";
                            oConexInfo.UserID = "sa";
                            oConexInfo.Password = "geovanni12";
                            ReportDocument oRptPrueba = new ReportDocument();
                            oRptPrueba.Load(@"D:\Windows\Escritorio\NeveriaDefintiva\Neveria\Reporte\Reporteventa.rpt");
                           
                            //nose w no quiere agarrar esta puta mamada


                            //obtener la colección de tablas del informe
                            oListaTablas = oRptPrueba.Database.Tables;
                            //' por cada tabla del informe...
                            foreach (Table oTabla in oListaTablas)
                            {
                                //' ...obtener el objeto con los datos de conexión
                                oTablaConexInfo = oTabla.LogOnInfo;
                                //' asignar el objeto con datos de conexión que hemos creado
                                oTablaConexInfo.ConnectionInfo = oConexInfo;
                                //' aplicar cambios de conexión a la tabla
                                oTabla.ApplyLogOnInfo(oTablaConexInfo);
                            }



                            reporte.crystalReportViewer1.ReportSource = oRptPrueba;

                            reporte.WindowState = FormWindowState.Maximized;


                            ParameterFieldDefinitions crparametros;
                            ParameterFieldDefinition crparametro;
                            ParameterValues crpparametrovalue = new ParameterValues();
                            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
                            parameterDiscreteValue.Value = txtNumVenta.Text;

                            //fieldefinitions lo igualamos al objeto reportdocument
                            crparametros = oRptPrueba.DataDefinition.ParameterFields;
                            crparametro = crparametros["folio"];


                            crpparametrovalue.Add(parameterDiscreteValue);
                            crparametro.ApplyCurrentValues(crpparametrovalue);

                            reporte.crystalReportViewer1.ReportSource = oRptPrueba;
                            reporte.crystalReportViewer1.Refresh();

                            reporte.ShowDialog();

                            txtpago.Clear();
                            txtcambio.Clear();
                            txtcantidad.Clear();
                            txtimporte.Text = "";
                            txtprecio.Text = "";
                            //txt.Clear();
                            txtcliente.Clear();
                            //cboxempleado.SelectedIndex = 0;
                          //  txtclaveuser.Focus();
                            txttotal.Text = "";

                            LLENARGRID(0);
                            maximo();
                            BtnGuardardetalle.Enabled = false;
                          //  btnmenos.Enabled = false;
                        }


                        else
                        {
                            Clases.clauditoria.auditoria("No se imprimio ticket, Folio Ticket:" + " " + txtNumVenta.Text);
                            txttotal.Text = "";
                           // txtclaveuser.Focus();
                            txtpago.Clear();
                            txtcambio.Clear();
                            //txtclaveuser.Clear();
                            txtcliente.Clear();
                            //cboxempleado.SelectedIndex = 0;
                            txtcantidad.Clear();
                            txtimporte.Text = "";
                            txtprecio.Text = "";
                           // LLENARGRID(0);
                            maximo();
                            BtnGuardardetalle.Enabled = false;
                            ///btnmenos.Enabled = false;
                        }

                    }


                    //    try
                    //    {
                    //        Clconexion objconexion = new Clases.Clconexion();
                    //        conexion = new SqlConnection(objconexion.conexion());
                    //        conexion.Open();
                    //        string query = "insert into Venta_general values (@VG_FOLIO, @VG_FECHA,  @VG_FOLIOCLIENTE, @VG_TOTAL)";
                    //        SqlCommand cmd = new SqlCommand(query, conexion);
                    //        cmd.Parameters.AddWithValue("@VG_FOLIO", txtNumVenta.Text);
                    //        cmd.Parameters.AddWithValue("@VG_FECHA", dateTimePicker1.Value);
                    //        cmd.Parameters.AddWithValue("@VG_FOLIOCLIENTE", txtcliente.Text);
                    //        cmd.Parameters.AddWithValue("@VG_TOTAL", decimal.Parse(txttotal.Text));
                    //        cmd.ExecuteNonQuery();
                    //        for (int i = 0; i < DataTable.RowCount; i++)
                    //        {
                    //            //inserta en ventasdetalle
                    //            query = "insert into VENTAS_DET values (@ven_id, @ven_articulo, @ven_cantidad, @ven_importe)";
                    //            cmd = new SqlCommand(query, conexion);
                    //            cmd.Parameters.AddWithValue("@ven_id", txtNumVenta.Text);
                    //            cmd.Parameters.AddWithValue("@ven_articulo", DataTable.Rows[i].Cells["clave"].Value);
                    //            cmd.Parameters.AddWithValue("@ven_cantidad", DataTable.Rows[i].Cells["cantidad"].Value);
                    //            cmd.Parameters.AddWithValue("@ven_importe", DataTable.Rows[i].Cells["importe"].Value);
                    //            cmd.ExecuteNonQuery();



                    //        }

                    //        result = MessageBox.Show("La venta se ha guardado correctamente. ¿Desea imprimir Ticket de venta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //        if (result == DialogResult.Yes)
                    //        {

                    //            // Impresion del ticket.

                    //            txtcliente.Clear();
                    //            txtclienteN.Clear();
                    //            txtclaveA.Clear();
                    //            comboarticulo.SelectedIndex = -1;
                    //            txtprecio.Clear();
                    //            txtcantidad.Clear();
                    //            DataTable.Rows.Clear();
                    //            Reporte.reporteVenta2 rpt = new Reporte.reporteVenta2();
                    //            rpt.SetParameterValue("@ven_id", txtNumVenta.Text);
                    //            // Reporte.FrmPlantilla plantilla = new Reporte.FrmPlantilla();
                    //            //plantilla.crystalReportViewer1.ReportSource = rpt;
                    //            //plantilla.ShowDialog();
                    //            cargaconsecutivo();
                    //            txtcliente.Focus();
                    //        }
                    //        else
                    //        {
                    //            cargaconsecutivo();
                    //            txtcliente.Clear();
                    //            txtclienteN.Clear();
                    //            txtclaveA.Clear();
                    //            comboarticulo.SelectedIndex = -1;
                    //            txtprecio.Clear();
                    //            txtcantidad.Clear();
                    //            DataTable.Rows.Clear();
                    //            txtcliente.Focus();
                    //        }
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        MessageBox.Show(ex.ToString());
                    //    }
                    //    finally { conexion.Close(); }
                    //}
             }
          }
        }
        private void CalculaImporte()
        {
            double P = 0.00;
            if (txtprecio.Text.Length > 0)
            {
                P = double.Parse(txtprecio.Text);
            }
            int c = 0;
            if (txtcantidad.Text.Length > 0)
            {
                c = int.Parse(txtcantidad.Text);
            }
            txtimporte.Text = (c * P).ToString();
        }
        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtclaveA.Clear();
                comboarticulo.SelectedIndex = -1;
                txtprecio.Clear();
                txtcantidad.Clear();
                txtclaveA.Focus();
            }
        }

        private void comboarticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                conexion.Open();
                string query = "Select * from Producto where PR_NOMBRE = @nombre";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", comboarticulo.Text);
                SqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    txtclaveA.Text = leer["PR_ID"].ToString();
                    txtprecio.Text = leer["PR_PRECIO"].ToString();
                }
                conexion.Close();
               
            }
        
    }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            //val.soloNumeros(e);
            //{
            //    if (e.Handled == true)
            //    {
            //        MessageBox.Show("Solo Numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    if (e.KeyChar == 13)
            //    {
            //        if (string.IsNullOrEmpty(txtcantidad.Text.ToString()))
            //        {
            //            MessageBox.Show("Campo Vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else
            //        {
            //            CalculaImporte();
            //            btnagregar.Focus();

            //            txttotal.Text = txtimporte.Text;
            //        }
            //    }
            //}
        }
        public void cambio()
        {
            double P = 0.00;
            if (txttotal.Text.Length > 0)
            {
                P = double.Parse(txttotal.Text);
            }
            double c = 0;
            if (txtpago.Text.Length > 0)
            {
                c = double.Parse(txtpago.Text);
            }

            txtcambio.Text = (c - P).ToString("N2");
        }
        public void Suma()
        {
            double total = 0;

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                total += Convert.ToDouble(row.Cells["importeDataGridViewTextBoxColumn"].Value);
            }

            txttotal.Text = total.ToString("N2");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboarticulo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "")
            {
                txtimporte.Clear();
                txtcantidad.Focus();
            }
            else
            {
                decimal precio = decimal.Parse(txtprecio.Text);
                decimal cantidad = decimal.Parse(txtcantidad.Text);

                decimal importe = precio * cantidad;
                txtimporte.Text = importe.ToString();

                //que show :V
            }
            
        }

        private void cboxcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Clconexion objconexion = new Clconexion();
                SqlConnection conexion = new SqlConnection(objconexion.conexion());
                conexion.Open();
                string query = "select * FROM Cliente where CLI_NOMBRE=@Clave";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Clave", cboxcliente.Text);
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    txtcliente.Text = lector["CLI_CLAVE"].ToString();
                    txtnombrec.Text = lector["CLI_NOMBRE"].ToString();
                    txtcliente.Enabled = false;
                    cboxcliente.Visible = false;
                    //cboxempleado.Enabled = true;
                    //cboxempleado.Focus();
                }
                conexion.Close();
            }
        }
        private void LLENARGRID(int ifolio)
        {

            this.sp_DetalleTableAdapter.Fill(dsdetalless.Sp_Detalle, ifolio);
        }


        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                if(string.IsNullOrEmpty(txtpago.Text.ToString().Trim()))
                {
                    MessageBox.Show("Campo de pago Vacio", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    cambio();
                }
            }
        }

        private void txtprecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if(txtprecio.Text=="")
                {
                    MessageBox.Show("No Puede Haber espacios en blanco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtprecio.Focus();
                }
                else
                {
                    txtcantidad.Focus();
                }
            }
        }

        private void comboarticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtimporte.Clear();
        }
    } 

}
