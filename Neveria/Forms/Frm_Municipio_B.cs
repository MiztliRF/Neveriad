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
    public partial class Frm_Municipio_B : Form
    {
        public Frm_Municipio_B()
        {
            InitializeComponent();
        }

        private void Frm_Municipio_B_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetmunicipio.Municipio' Puede moverla o quitarla según sea necesario.
            this.municipioTableAdapter.Fill(this.datasetmunicipio.Municipio,txtbusqueda.Text);

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
            this.municipioTableAdapter.Fill(this.datasetmunicipio.Municipio, txtbusqueda.Text);
        }

        public datasetmunicipio MunicipioDataSet
        {
            get
            {
                return datasetmunicipio;
            }
        }

        public BindingSource MunicipioBindingSource
        {
            get
            {
                return municipioBindingSource;
            }
        }

        private void btnmuicipio_Click(object sender, EventArgs e)
        {
            Frm_Municipio B = new Frm_Municipio();
            B.ShowDialog();
        }
    }
}
