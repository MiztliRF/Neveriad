using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Neveria.Forms
{
    public partial class Frm_Compras : Form
    {
        System.Data.SqlClient.SqlConnection conexion = new System.Data.SqlClient.SqlConnection(@"Data Source=LAPTOP-ED3OPSO6\MIZTLI;Initial Catalog=Neveria; User=sa;Password=geovanni12");
        System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
        System.Data.SqlClient.SqlDataReader lector;
        string sconexion;
        public Frm_Compras()
        {
            InitializeComponent();
        }
        public Frm_Compras(String sconexion)
        {
            InitializeComponent();
            this.sconexion = sconexion;
            this.sp_Detalle_CTableAdapter.Connection.ConnectionString = sconexion;
            this.proveedorTableAdapter.Connection.ConnectionString = sconexion;

        }

        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsmateria_prima.Materia_Prima' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'dsproveedor.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dsproveedor.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'compradaset.Compra_Detalle' Puede moverla o quitarla según sea necesario.
            //this.compra_DetalleTableAdapter.Fill(this.compradaset.Compra_Detalle);
            rellenar();

        }

        private void btnguardarv_Click(object sender, EventArgs e)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_Compras";
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@OP", 2);
            comando.Parameters.AddWithValue("@folio", int.Parse(txtfolio.Text));
            comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
            comando.Parameters.AddWithValue("@Folio_P", int.Parse(comboBox1.SelectedValue.ToString()));
            System.Data.SqlClient.SqlParameter p = comando.Parameters.AddWithValue("@detalle", dsdetalle.Sp_Detalle_C);
            p.SqlDbType = SqlDbType.Structured;
            p.TypeName = "dbo.detalles_type_C";
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
            DialogResult R = MessageBox.Show("Compra Realizada  ¿Desea Imprimir Ticket ?", "Exito", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (R==DialogResult.Yes)
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

        private void btnagregar_Click(object sender, EventArgs e)
        {
            dsdetalle.Sp_Detalle_CRow r;
            r = dsdetalle.Sp_Detalle_C.NewSp_Detalle_CRow();
            r.Folio_Compra = int.Parse(txtfolio.Text);
            r.Nombre = comboarticulo.Text;
            r.Cantidad = int.Parse(txtcantidad.Text);
            r.Precio = double.Parse(txtprecio.Text);
            r.Importe = double.Parse(txtimporte.Text);
            dsdetalle.Sp_Detalle_C.AddSp_Detalle_CRow(r);
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            CalculaImporte();
            btnagregar.Focus();
        }

        public void rellenar()
        {
            DataTable dt = new DataTable();
            conexion.Open();
            SqlCommand combo = new SqlCommand("select * from Materia_Prima", conexion);
            SqlDataAdapter da = new SqlDataAdapter(combo);
            da.Fill(dt);
            conexion.Close();
            this.comboarticulo.DataSource = dt;
            this.comboarticulo.ValueMember = "Clave";
            this.comboarticulo.DisplayMember = "Nombre";
            conexion.Close();
        }

        private void comboarticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtfoliomat.Text = comboarticulo.SelectedValue.ToString();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_MateriaP";
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
            if(e.KeyValue==13)
            {
                btnagregar.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            if (dataGridView1.Rows.Count==0)
            {//btnEliminar

            }
        }
    }
}
