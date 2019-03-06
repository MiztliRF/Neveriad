namespace Neveria.Forms
{
    partial class Frm_Proveedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.txtpaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnexterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtinterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.coloniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetcolonia = new Neveria.DataSetcolonia();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrarhijo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proveedoresBdatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coloniaTableAdapter = new Neveria.DataSetcoloniaTableAdapters.ColoniaTableAdapter();
            this.btncoloniab = new System.Windows.Forms.Button();
            this.txtcolonia = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetcolonia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarhijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBdatasetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folio:";
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(133, 69);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(183, 22);
            this.txtfolio.TabIndex = 1;
            this.txtfolio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfolio_KeyDown);
            // 
            // txtpaterno
            // 
            this.txtpaterno.Location = new System.Drawing.Point(133, 109);
            this.txtpaterno.Name = "txtpaterno";
            this.txtpaterno.Size = new System.Drawing.Size(183, 22);
            this.txtpaterno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "A. Paterno:";
            // 
            // txtmaterno
            // 
            this.txtmaterno.Location = new System.Drawing.Point(133, 154);
            this.txtmaterno.Name = "txtmaterno";
            this.txtmaterno.Size = new System.Drawing.Size(183, 22);
            this.txtmaterno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "A. Materno:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(133, 197);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(183, 22);
            this.txtnombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // txtcalle
            // 
            this.txtcalle.Location = new System.Drawing.Point(133, 240);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(183, 22);
            this.txtcalle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Calle:";
            // 
            // txtnexterno
            // 
            this.txtnexterno.Location = new System.Drawing.Point(133, 280);
            this.txtnexterno.Name = "txtnexterno";
            this.txtnexterno.Size = new System.Drawing.Size(183, 22);
            this.txtnexterno.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "N. Externo:";
            // 
            // txtinterno
            // 
            this.txtinterno.Location = new System.Drawing.Point(133, 326);
            this.txtinterno.Name = "txtinterno";
            this.txtinterno.Size = new System.Drawing.Size(183, 22);
            this.txtinterno.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "N. Interno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Colonia:";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Location = new System.Drawing.Point(522, 110);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(183, 22);
            this.txtlocalidad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Localidad";
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.Enabled = false;
            this.txtmunicipio.Location = new System.Drawing.Point(524, 150);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(181, 22);
            this.txtmunicipio.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Municipio";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(522, 190);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(183, 22);
            this.txttelefono.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Telefono:";
            // 
            // txtrfc
            // 
            this.txtrfc.Location = new System.Drawing.Point(522, 233);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(183, 22);
            this.txtrfc.TabIndex = 23;
            this.txtrfc.TextChanged += new System.EventHandler(this.txtrfc_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(432, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "RFC:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(522, 276);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(183, 22);
            this.txtemail.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "E-MAIL:";
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnactualizar.BackgroundImage")));
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnactualizar.Location = new System.Drawing.Point(46, 407);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(171, 71);
            this.btnactualizar.TabIndex = 27;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Location = new System.Drawing.Point(245, 407);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(171, 71);
            this.btneliminar.TabIndex = 28;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // coloniaBindingSource
            // 
            this.coloniaBindingSource.DataMember = "Colonia";
            this.coloniaBindingSource.DataSource = this.dataSetcolonia;
            // 
            // dataSetcolonia
            // 
            this.dataSetcolonia.DataSetName = "DataSetcolonia";
            this.dataSetcolonia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(322, 60);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 29;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.btncerrarhijo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 37);
            this.panel1.TabIndex = 67;
            // 
            // btncerrarhijo
            // 
            this.btncerrarhijo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncerrarhijo.BackgroundImage")));
            this.btncerrarhijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncerrarhijo.Location = new System.Drawing.Point(793, 0);
            this.btncerrarhijo.Name = "btncerrarhijo";
            this.btncerrarhijo.Size = new System.Drawing.Size(51, 37);
            this.btncerrarhijo.TabIndex = 1;
            this.btncerrarhijo.TabStop = false;
            this.btncerrarhijo.Click += new System.EventHandler(this.btncerrarhijo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-19, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // coloniaTableAdapter
            // 
            this.coloniaTableAdapter.ClearBeforeFill = true;
            // 
            // btncoloniab
            // 
            this.btncoloniab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncoloniab.BackgroundImage")));
            this.btncoloniab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncoloniab.Location = new System.Drawing.Point(713, 65);
            this.btncoloniab.Name = "btncoloniab";
            this.btncoloniab.Size = new System.Drawing.Size(83, 31);
            this.btncoloniab.TabIndex = 34;
            this.btncoloniab.UseVisualStyleBackColor = true;
            this.btncoloniab.Click += new System.EventHandler(this.btncoloniab_Click);
            // 
            // txtcolonia
            // 
            this.txtcolonia.Enabled = false;
            this.txtcolonia.Location = new System.Drawing.Point(524, 70);
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(183, 22);
            this.txtcolonia.TabIndex = 68;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(713, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 69;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(713, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 31);
            this.button3.TabIndex = 70;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 513);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtcolonia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncoloniab);
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
            this.Name = "Frm_Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Frm_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetcolonia)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrarhijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBdatasetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.TextBox txtpaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnexterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtinterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmunicipio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btncerrarhijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource proveedoresBdatasetBindingSource;
        private DataSetcolonia dataSetcolonia;
        private System.Windows.Forms.BindingSource coloniaBindingSource;
        private DataSetcoloniaTableAdapters.ColoniaTableAdapter coloniaTableAdapter;
        private System.Windows.Forms.Button btncoloniab;
        private System.Windows.Forms.TextBox txtcolonia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}