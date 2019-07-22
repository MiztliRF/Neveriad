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
    public partial class Frm_Producto_B : Form
    {
        public Frm_Producto_B()
        {
            InitializeComponent();
        }

        private void Frm_Producto_B_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productoBdataset.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.productoBdataset.Producto);

        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
           //productoTableAdapter.Fill(productoBdataset.Producto, txtbusqueda.Text);
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
        public ProductoBdataset ProductoBdataset
        {
            get { return ProductoBdataset; }
        }
        public BindingSource productobindigsource
        {
            get { return productoBindingSource; }
        }
    }
}
