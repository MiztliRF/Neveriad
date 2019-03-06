namespace Neveria
{
    partial class Frm_Prim
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Prim));
            this.button1 = new System.Windows.Forms.Button();
            this.Boton_2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionDeMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionDeImpresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(10, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 91);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizacion de Catalogo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Boton_2
            // 
            this.Boton_2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Boton_2.Location = new System.Drawing.Point(10, 257);
            this.Boton_2.Name = "Boton_2";
            this.Boton_2.Size = new System.Drawing.Size(236, 95);
            this.Boton_2.TabIndex = 1;
            this.Boton_2.Text = "Actualizacion de Movimiento";
            this.Boton_2.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(10, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 107);
            this.button2.TabIndex = 2;
            this.button2.Text = "Actualizacion de Impresion ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.ErrorImage = global::Neveria.Properties.Resources.depositphotos_52905549_stock_illustration_vector_icon_ice_cream;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarToolStripMenuItem,
            this.actualizacionDeMovimientoToolStripMenuItem,
            this.actualizacionDeImpresionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.movimientoToolStripMenuItem,
            this.impresionToolStripMenuItem});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.actualizarToolStripMenuItem.Text = "Actualizacion De Catalogo";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.catalogoToolStripMenuItem.Text = "Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // movimientoToolStripMenuItem
            // 
            this.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem";
            this.movimientoToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.movimientoToolStripMenuItem.Text = "Movimiento";
            // 
            // impresionToolStripMenuItem
            // 
            this.impresionToolStripMenuItem.Name = "impresionToolStripMenuItem";
            this.impresionToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.impresionToolStripMenuItem.Text = "Impresion";
            // 
            // actualizacionDeMovimientoToolStripMenuItem
            // 
            this.actualizacionDeMovimientoToolStripMenuItem.Name = "actualizacionDeMovimientoToolStripMenuItem";
            this.actualizacionDeMovimientoToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.actualizacionDeMovimientoToolStripMenuItem.Text = "Actualizacion De Movimiento";
            // 
            // actualizacionDeImpresionToolStripMenuItem
            // 
            this.actualizacionDeImpresionToolStripMenuItem.Name = "actualizacionDeImpresionToolStripMenuItem";
            this.actualizacionDeImpresionToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.actualizacionDeImpresionToolStripMenuItem.Text = "Actualizacion De Impresion";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(688, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 66);
            this.panel1.TabIndex = 7;
            // 
            // Frm_Prim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1110, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Boton_2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Prim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neveria \"Chente\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Boton_2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionDeMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionDeImpresionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

