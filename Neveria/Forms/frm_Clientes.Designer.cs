namespace Neveria.Forms
{
    partial class frm_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clientes));
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtinterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnexterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnlocalidad = new System.Windows.Forms.Button();
            this.btnmunicipio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proveedoresdataset1 = new Neveria.Dataset.proveedoresdataset();
            this.txtcolonia = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresdataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(221, 367);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(171, 71);
            this.btneliminar.TabIndex = 59;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnactualizar.BackgroundImage")));
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnactualizar.Location = new System.Drawing.Point(22, 367);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(171, 71);
            this.btnactualizar.TabIndex = 58;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(503, 266);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(183, 22);
            this.txtemail.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 56;
            this.label13.Text = "E-MAIL:";
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(503, 223);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(183, 22);
            this.txtrfc.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 223);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "RFC:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(503, 180);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(183, 22);
            this.txttelefono.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "Telefono:";
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.Enabled = false;
            this.txtmunicipio.Location = new System.Drawing.Point(505, 140);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(181, 22);
            this.txtmunicipio.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Municipio";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Location = new System.Drawing.Point(503, 100);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(183, 22);
            this.txtlocalidad.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Localidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Colonia:";
            // 
            // txtinterno
            // 
            this.txtinterno.Location = new System.Drawing.Point(114, 313);
            this.txtinterno.Name = "txtinterno";
            this.txtinterno.Size = new System.Drawing.Size(183, 22);
            this.txtinterno.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "N. Interno:";
            // 
            // txtnexterno
            // 
            this.txtnexterno.Location = new System.Drawing.Point(114, 264);
            this.txtnexterno.Name = "txtnexterno";
            this.txtnexterno.Size = new System.Drawing.Size(183, 22);
            this.txtnexterno.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "N. Externo:";
            // 
            // txtcalle
            // 
            this.txtcalle.Location = new System.Drawing.Point(114, 227);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(183, 22);
            this.txtcalle.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Calle:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(114, 184);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(183, 22);
            this.txtnombre.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nombre:";
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(114, 141);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(183, 22);
            this.txtmaterno.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "A. Materno:";
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(114, 96);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(183, 22);
            this.txtpaterno.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "A. Paterno:";
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(114, 56);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(183, 22);
            this.txtfolio.TabIndex = 34;
            this.txtfolio.TextChanged += new System.EventHandler(this.txtfolio_TextChanged);
            this.txtfolio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfolio_KeyDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Folio:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(303, 41);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(692, 43);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(71, 37);
            this.button2.TabIndex = 63;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlocalidad
            // 
            this.btnlocalidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlocalidad.BackgroundImage")));
            this.btnlocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlocalidad.Image = ((System.Drawing.Image)(resources.GetObject("btnlocalidad.Image")));
            this.btnlocalidad.Location = new System.Drawing.Point(692, 91);
            this.btnlocalidad.Name = "btnlocalidad";
            this.btnlocalidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnlocalidad.Size = new System.Drawing.Size(71, 37);
            this.btnlocalidad.TabIndex = 64;
            this.btnlocalidad.UseVisualStyleBackColor = true;
            this.btnlocalidad.Click += new System.EventHandler(this.btnlocalidad_Click);
            // 
            // btnmunicipio
            // 
            this.btnmunicipio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmunicipio.BackgroundImage")));
            this.btnmunicipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmunicipio.Image = ((System.Drawing.Image)(resources.GetObject("btnmunicipio.Image")));
            this.btnmunicipio.Location = new System.Drawing.Point(692, 134);
            this.btnmunicipio.Name = "btnmunicipio";
            this.btnmunicipio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnmunicipio.Size = new System.Drawing.Size(71, 36);
            this.btnmunicipio.TabIndex = 65;
            this.btnmunicipio.UseVisualStyleBackColor = true;
            this.btnmunicipio.Click += new System.EventHandler(this.btnmunicipio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 37);
            this.panel1.TabIndex = 66;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(752, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-19, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // proveedoresdataset1
            // 
            this.proveedoresdataset1.DataSetName = "proveedoresdataset";
            this.proveedoresdataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtcolonia
            // 
            this.txtcolonia.Enabled = false;
            this.txtcolonia.Location = new System.Drawing.Point(503, 58);
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(183, 22);
            this.txtcolonia.TabIndex = 67;
            this.txtcolonia.TextChanged += new System.EventHandler(this.txtcolonia_TextChanged);
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 443);
            this.Controls.Add(this.txtcolonia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmunicipio);
            this.Controls.Add(this.btnlocalidad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmunicipio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtinterno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnexterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpaterno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresdataset1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmunicipio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtinterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnexterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnlocalidad;
        private System.Windows.Forms.Button btnmunicipio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Dataset.proveedoresdataset proveedoresdataset1;
        private System.Windows.Forms.TextBox txtcolonia;
    }
}