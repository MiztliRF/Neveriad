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
    public partial class frmrespaldo : Form
    {
        public frmrespaldo()
        {
            InitializeComponent();
        }
        public void escogerruta()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                btnbuscar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se selecciono la carpeta !", "Seleccione una carpeta");
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            escogerruta();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == progressBar1.Maximum)
            {

                this.timer1.Stop();


                try
                {
                    string ruta = textBox1.Text;
                    Clases.respaldo.realizar(ruta);
                    this.progressBar1.Visible = true;
                    Clases.clauditoria.auditoria("Se realizo respaldo");
                    MessageBox.Show("Se realizo respaldo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressBar1.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    progressBar1.Value = 0;
                }


            }
        }

        private void frmrespaldo_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
