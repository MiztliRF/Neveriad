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
    public partial class Frm_proveedores_B : Form
    {
        string buscar;
        public Frm_proveedores_B(string sconexion)
        {
            InitializeComponent();
            proveedorTableAdapter.Connection.ConnectionString = sconexion;
        }
        public Frm_proveedores_B()
        {
            InitializeComponent();
        }

        private void Frm_proveedores_B_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetproveedor1.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(proveedoresdataset.Proveedor, txtbuscar.Text);
            // TODO: esta línea de código carga datos en la tabla 'proveedoresdataset.Proveedor' Puede moverla o quitarla según sea necesario.
            //this.proveedorTableAdapter.Fill(this.proveedoresdataset.Proveedor);

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Proveedoresdataset datasetprovedores
        {
            get { return proveedoresdataset; }
        }

        public BindingSource provedoresbindingsource
        {
            get { return proveedorBindingSource; }
        }


        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.proveedorTableAdapter.Fill(proveedoresdataset.Proveedor,txtbuscar.Text);

        }
    }
}
