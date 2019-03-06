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
    public partial class Frm_MateriaP_B : Form
    {
        public Frm_MateriaP_B()
        {
            InitializeComponent();
        }

        private void Frm_MateriaP_B_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetmateriap.Materia_Prima' Puede moverla o quitarla según sea necesario.
            this.materia_PrimaTableAdapter.Fill(this.datasetmateriap.Materia_Prima,txtbusqueda.Text);

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
        public datasetmateriap Datasetmateriap
        {
            get { return datasetmateriap; }
        }

        public BindingSource materiapBindingSource
        {
            get
            {
                return materiapBindingSource;
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            this.materia_PrimaTableAdapter.Fill(this.datasetmateriap.Materia_Prima, txtbusqueda.Text);
        }
    }
}
