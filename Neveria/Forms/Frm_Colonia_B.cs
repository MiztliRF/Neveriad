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
    public partial class Frm_Colonia_B : Form
    {
        public Frm_Colonia_B()
        {
            InitializeComponent();
        }

        private void bttnactualizar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Colonia_B_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetcoloniab.Colonia' Puede moverla o quitarla según sea necesario.
            this.coloniaTableAdapter.Fill(this.datasetcoloniab.Colonia,txtbusqueda.Text);

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
        
        public datasetcoloniab ColoniaDataSet
        {
            get
            {
                return datasetcoloniab;
            }
        }

        public BindingSource ColoniaBindingSource
        {
            get
            {
                return coloniaBindingSource;
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            this.coloniaTableAdapter.Fill(datasetcoloniab.Colonia, txtbusqueda.Text);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Forms.Frm_Colonia L = new Frm_Colonia();
            L.ShowDialog();
        }
    }
}
