namespace Neveria.Forms
{
    partial class Frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbcolonia = new System.Windows.Forms.ComboBox();
            this.coloniaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dATASETCOLONIA = new Neveria.DATASETCOLONIA();
            this.label14 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtni = new System.Windows.Forms.TextBox();
            this.txtne = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtAm = new System.Windows.Forms.TextBox();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nEVERIACcolonia = new Neveria.NEVERIACcolonia();
            this.coloniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coloniaTableAdapter = new Neveria.NEVERIACcoloniaTableAdapters.ColoniaTableAdapter();
            this.coloniaTableAdapter1 = new Neveria.DATASETCOLONIATableAdapters.ColoniaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATASETCOLONIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEVERIACcolonia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 43);
            this.panel1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(271, 32);
            this.label16.TabIndex = 2;
            this.label16.Text = "Registro de Clientes";
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(724, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 43);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 1;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.cbcolonia);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtrfc);
            this.panel2.Controls.Add(this.txttelefono);
            this.panel2.Controls.Add(this.txtni);
            this.panel2.Controls.Add(this.txtne);
            this.panel2.Controls.Add(this.txtcalle);
            this.panel2.Controls.Add(this.txtnombre);
            this.panel2.Controls.Add(this.txtAm);
            this.panel2.Controls.Add(this.txtAp);
            this.panel2.Controls.Add(this.txtclave);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1472, 780);
            this.panel2.TabIndex = 1;
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(480, 384);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(119, 58);
            this.btnagregar.TabIndex = 32;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btneliminar.Enabled = false;
            this.btneliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btneliminar.Location = new System.Drawing.Point(620, 384);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(134, 58);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Location = new System.Drawing.Point(298, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 41);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbcolonia
            // 
            this.cbcolonia.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coloniaBindingSource1, "CO_ID", true));
            this.cbcolonia.Enabled = false;
            this.cbcolonia.FormattingEnabled = true;
            this.cbcolonia.Location = new System.Drawing.Point(566, 174);
            this.cbcolonia.Name = "cbcolonia";
            this.cbcolonia.Size = new System.Drawing.Size(223, 24);
            this.cbcolonia.TabIndex = 27;
            this.cbcolonia.SelectedIndexChanged += new System.EventHandler(this.cbcolonia_SelectedIndexChanged);
            this.cbcolonia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbcolonia_KeyDown);
            // 
            // coloniaBindingSource1
            // 
            this.coloniaBindingSource1.DataMember = "Colonia";
            this.coloniaBindingSource1.DataSource = this.dATASETCOLONIA;
            // 
            // dATASETCOLONIA
            // 
            this.dATASETCOLONIA.DataSetName = "DATASETCOLONIA";
            this.dATASETCOLONIA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(496, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Colonia";
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(566, 123);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(208, 22);
            this.txtemail.TabIndex = 20;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtemail_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "E-mail";
            // 
            // txtrfc
            // 
            this.txtrfc.Enabled = false;
            this.txtrfc.Location = new System.Drawing.Point(566, 71);
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(208, 22);
            this.txtrfc.TabIndex = 18;
            this.txtrfc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrfc_KeyDown);
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(175, 346);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(208, 22);
            this.txttelefono.TabIndex = 17;
            this.txttelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttelefono_KeyDown);
            // 
            // txtni
            // 
            this.txtni.Enabled = false;
            this.txtni.Location = new System.Drawing.Point(175, 305);
            this.txtni.Name = "txtni";
            this.txtni.Size = new System.Drawing.Size(90, 22);
            this.txtni.TabIndex = 16;
            this.txtni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtni_KeyDown);
            // 
            // txtne
            // 
            this.txtne.Enabled = false;
            this.txtne.Location = new System.Drawing.Point(175, 261);
            this.txtne.Name = "txtne";
            this.txtne.Size = new System.Drawing.Size(90, 22);
            this.txtne.TabIndex = 15;
            this.txtne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtne_KeyDown);
            // 
            // txtcalle
            // 
            this.txtcalle.Enabled = false;
            this.txtcalle.Location = new System.Drawing.Point(175, 217);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(208, 22);
            this.txtcalle.TabIndex = 14;
            this.txtcalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcalle_KeyDown);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(175, 176);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(208, 22);
            this.txtnombre.TabIndex = 13;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            // 
            // txtAm
            // 
            this.txtAm.Enabled = false;
            this.txtAm.Location = new System.Drawing.Point(175, 125);
            this.txtAm.Name = "txtAm";
            this.txtAm.Size = new System.Drawing.Size(208, 22);
            this.txtAm.TabIndex = 12;
            this.txtAm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAm_KeyDown);
            // 
            // txtAp
            // 
            this.txtAp.Enabled = false;
            this.txtAp.Location = new System.Drawing.Point(175, 73);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(208, 22);
            this.txtAp.TabIndex = 11;
            this.txtAp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAp_KeyDown);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(175, 31);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(108, 22);
            this.txtclave.TabIndex = 10;
            this.txtclave.TextChanged += new System.EventHandler(this.txtclave_TextChanged);
            this.txtclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclave_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "RFC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numero Interior";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero Exterior";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // nEVERIACcolonia
            // 
            this.nEVERIACcolonia.DataSetName = "NEVERIACcolonia";
            this.nEVERIACcolonia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloniaBindingSource
            // 
            this.coloniaBindingSource.DataMember = "Colonia";
            this.coloniaBindingSource.DataSource = this.nEVERIACcolonia;
            // 
            // coloniaTableAdapter
            // 
            this.coloniaTableAdapter.ClearBeforeFill = true;
            // 
            // coloniaTableAdapter1
            // 
            this.coloniaTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(801, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATASETCOLONIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEVERIACcolonia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtni;
        private System.Windows.Forms.TextBox txtne;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtAm;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private NEVERIACcolonia nEVERIACcolonia;
        private System.Windows.Forms.BindingSource coloniaBindingSource;
        private NEVERIACcoloniaTableAdapters.ColoniaTableAdapter coloniaTableAdapter;
        private System.Windows.Forms.ComboBox cbcolonia;
        private DATASETCOLONIA dATASETCOLONIA;
        private System.Windows.Forms.BindingSource coloniaBindingSource1;
        private DATASETCOLONIATableAdapters.ColoniaTableAdapter coloniaTableAdapter1;
    }
}