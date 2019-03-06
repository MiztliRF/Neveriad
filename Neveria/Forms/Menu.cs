﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Neveria.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void abrirformhija(object formhija)
        {
            if (this.panelcontenedor.Controls.Count > 0)
            
                this.panelcontenedor.Controls.RemoveAt(0);
            
             Form fh = formhija as Form;
             fh.TopLevel = false;
              fh.Dock = DockStyle.Fill;
             this.panelcontenedor.Controls.Add(fh);
              this.panelcontenedor.Tag = fh;
              fh.Show();
            

        

            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnminimzar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void submenucatalogo_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {

            submenucatalogo.Visible = false;
            abrirformhija(new Frm_Proveedores());
        }

        private void btnmp_Click(object sender, EventArgs e)
        {
            submenucatalogo.Visible = false;
            abrirformhija(new Frm_MateriaP());
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            submenucatalogo.Visible = false;
            abrirformhija(new frm_Clientes());
        }

        private void btnreceta_Click(object sender, EventArgs e)
        {
            submenucatalogo.Visible = false;
        }

        private void btncatalogo_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            submenucatalogo.Visible = false;
        }

        private void btncatalogo_MouseDown(object sender, MouseEventArgs e)
        {
            submenucatalogo.Visible = true;
        }

        private void btnmovimiento_Click(object sender, EventArgs e)
        {
            PANELSUBMENUDEMOVI.Visible = true;
        }

        private void BTNVENTA_Click(object sender, EventArgs e)
        {
            PANELSUBMENUDEMOVI.Visible = false;
        }

        private void btnproduccion_Click(object sender, EventArgs e)
        {
            PANELSUBMENUDEMOVI.Visible = false;
        }
    }
}