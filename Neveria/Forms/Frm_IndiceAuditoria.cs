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
    public partial class Frm_IndiceAuditoria : Form
    {
        public Frm_IndiceAuditoria()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            Forms.Frm_Resempledo ad = new Frm_Resempledo();
            ad.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
