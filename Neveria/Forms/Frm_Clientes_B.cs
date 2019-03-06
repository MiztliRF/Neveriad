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
    public partial class Frm_Clientes_B : Form
    {
        public Frm_Clientes_B()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_B_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datasetcliente.Cliente' Puede moverla o quitarla según sea necesario.
           this.clienteTableAdapter.Fill(this.datasetcliente.Cliente,textBox1.Text);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            clienteTableAdapter.Fill(datasetcliente.Cliente, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
       
        public Datasetcliente clientedataset
        {
            get { return datasetcliente; }
        }

        public BindingSource clientebindigsource
        {
            get { return clienteBindingSource; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
