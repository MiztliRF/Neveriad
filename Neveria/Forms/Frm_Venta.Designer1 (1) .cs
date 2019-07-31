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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace Neveria.Forms
{
    public partial class Frm_Venta : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=Neveria; User=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        string sconexion;
        public Frm_Venta()
        {
            InitializeComponent();
        }

        public Frm_Venta(String sconexion)
        {
            InitializeComponent();
            this.sconexion = sconexion;
            this.clienteTableAdapter.Connection.ConnectionString = sconexion;
            this.sp_Detalle_VTableAdapter.Connection.ConnectionString = sconexion;
        }
        private void Frm_Venta_Load(object sender, EventArgs e)
        {
           
            // TODO: esta línea de código carga datos en la tabla 'datasetCliente.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.datasetCliente.Cliente);
             rellenar();
            Max();
        }

        private void btnguardarv_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Ventas";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 2);
            comando.Parameters.AddWithValue("@folio", int.Parse(txtfolio.Text));
            comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@Folio_C", int.Parse(comboBox1.SelectedValue.ToString()));
            System.Data.SqlClient.SqlParameter p = comando.Parameters.AddWithValue("@detalle", spDetalle.Sp_Detalle_V);
            p.SqlDbType = SqlDbType.Structured;
            p.TypeName = "dbo.detalles_type_V";
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            DialogResult R = MessageBox.Show("Compra Realizada  ¿Desea Imprimir Ticket ?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (R == DialogResult.Yes)
            {
                Forms.frmreporte reporte = new Forms.frmreporte();

                ConnectionInfo oConexInfo;
                Tables oListaTablas;
                //Table oTabla;
                TableLogOnInfo oTablaConexInfo;
                //instanciar objeto para guardar datos de conexión
                oConexInfo = new ConnectionInfo();
                oConexInfo.ServerName = @"LAPTOP-ED3OPSO6\MIZTLI";
                oConexInfo.DatabaseName = "Neveria";
                oConexInfo.UserID = "sa";
                oConexInfo.Password = "geovanni12";
                //instanciar objeto informe
                //Informes.ImpVenta oRptPrueba = new Informes.ImpVenta();
                ReportDocument oRptPrueba = new ReportDocument();
                oRptPrueba.Load(@"C:\Users\miztl\source\repos\Neveria\Neveria\Reporte\reportecompra.rpt");
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
                reporte.crystalReportViewer1.Refresh();
                reporte.ShowDialog();

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

            private void txtcantidad_Leave(object sender, EventArgs e)
            {
                CalculaImporte();
            }

            private void btnagregar_Click(object sender, EventArgs e)
            {
                spDetalle.Sp_Detalle_VRow R;
                R = spDetalle.Sp_Detalle_V.NewSp_Detalle_VRow();
                R.Folio_Venta = int.Parse(txtfolio.Text);
                R.Nombre = comboarticulo.Text;
                R.Cantidad = int.Parse(txtcantidad.Text);
                R.Precio = int.Parse(txtprecio.Text);
                R.Importe =int.Parse(txtprecio.Text);
                spDetalle.Sp_Detalle_V.AddSp_Detalle_VRow(R);
            }

        public void rellenar()
        {
            DataTable dt = new DataTable();
            conexion.Open();
            SqlCommand combo = new SqlCommand("select * from Producto", conexion);
            SqlDataAdapter da = new SqlDataAdapter(combo);
            da.Fill(dt);
            conexion.Close();
            this.comboarticulo.DataSource = dt;
            this.comboarticulo.ValueMember = "ID";
            this.comboarticulo.DisplayMember = "Nombre";
            conexion.Close();
        }

        private void comboarticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtfoliomat.Text = comboarticulo.SelectedValue.ToString();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_Producto";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@OP", 1);
                comando.Parameters.AddWithValue("@id", int.Parse(txtfoliomat.Text));
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                if (lector.Read())
                {

                    txtprecio.Text = lector["Precio"].ToString();

                }
            }
            txtcantidad.Focus();
            lector.Close();
            conexion.Close();
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnagregar.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            if (dataGridView1.Rows.Count == 0)
            {//btnEliminar

            }
        }
        public void Max()
        {
            conexion.Open();
            comando = new SqlCommand("select isnull(MAX(Folio),0)+1 as ultimo from Venta", conexion);
            lector = comando.ExecuteReader();
            if (lector.Read())
            {
                txtfolio.Text = lector["ultimo"].ToString();

            }
            conexion.Close();

        }

        private void txtfolio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
