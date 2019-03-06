using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neveria.Forms
{
    public partial class Frm_Localidad_B : Form
    {
        public Frm_Localidad_B()
        {
            InitializeComponent();
        }

        private void Frm_Localidad_B_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetlocalidad.Localidad' Puede moverla o quitarla según sea necesario.
            this.localidadTableAdapter.Fill(this.datasetlocalidad.Localidad,txtbusqueda.Text);

        }

        private void brnaceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            this.localidadTableAdapter.Fill(this.datasetlocalidad.Localidad, txtbusqueda.Text);
        }

        public datasetlocalidad LocalidadDataSet
        {
            get
            {
                return datasetlocalidad;
            }
        }

        public BindingSource LocalidadBindingSource
        {
            get
            {
                return localidadBindingSource;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlocalidad_Click(object sender, EventArgs e)
        {
            Frm_Localidad B = new Frm_Localidad();
            B.ShowDialog();
        }
    }
}
