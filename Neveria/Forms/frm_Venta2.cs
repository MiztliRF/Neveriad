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
    public partial class frm_Venta2 : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=Neveria; User=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        string sconexion;
        public frm_Venta2()
        {
            InitializeComponent();
            Max();
            rellenarcliente();
            rellenarproducto();
        }

        private void btnguardarv_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Ventas2";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 2);
            comando.Parameters.AddWithValue("@folio", int.Parse(txtfolio.Text));
            comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@Folio_C", int.Parse(comboBox1.SelectedValue.ToString()));
            System.Data.SqlClient.SqlParameter p = comando.Parameters.AddWithValue("@detalle", dsdetallev.Sp_Detalle_V2);
            p.SqlDbType = SqlDbType.Structured;
            p.TypeName = "dbo.detalles_type_V2";
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
                oRptPrueba.Load(@"C:\Users\miztl\source\repos\Neveria\Neveria\Reporte\reporteVenta2.rpt");
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


                oRptPrueba.SetParameterValue("Folio", (txtfolio.Text));
                reporte.crystalReportViewer1.ReportSource = null;

                reporte.crystalReportViewer1.ReportSource = oRptPrueba;

                reporte.crystalReportViewer1.Refresh();

                reporte.ShowDialog();
            }
        }

        private void frm_Venta2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cliente._Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.cliente._Cliente);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            dsdetallev.Sp_Detalle_V2Row r;
            r = dsdetallev.Sp_Detalle_V2.NewSp_Detalle_V2Row();
            r.Folio_Venta = int.Parse(txtfolio.Text);
            r.Nombre = comboarticulo.Text;
            r.Cantidad = int.Parse(txtcantidad.Text);
            r.Precio = int.Parse(txtprecio.Text);
            r.Importe = int.Parse(txtimporte.Text);
            dsdetallev.Sp_Detalle_V2.AddSp_Detalle_V2Row(r);
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


        public void rellenarcliente()
        {
            DataTable dt = new DataTable();
            conexion.Open();
            SqlCommand combo = new SqlCommand("select * from Cliente", conexion);
            SqlDataAdapter da = new SqlDataAdapter(combo);
            da.Fill(dt);
            conexion.Close();
            this.comboBox1.DataSource = dt;
            this.comboBox1.ValueMember = "Folio";
            this.comboBox1.DisplayMember = "Nombre";
            conexion.Close();
        }

        public void rellenarproducto()
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
                comando.Parameters.AddWithValue("@ID", int.Parse(txtfoliomat.Text));
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
            if (e.KeyValue ==13)
            {
                btnagregar.Focus();
            }
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            CalculaImporte();
        }
    }
}
