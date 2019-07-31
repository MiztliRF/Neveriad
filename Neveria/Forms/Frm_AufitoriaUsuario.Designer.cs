namespace Neveria.Forms
{
    partial class Frm_AufitoriaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AufitoriaUsuario));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.brnmostrar = new System.Windows.Forms.Button();
            this.cboxusuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtusuario = new System.Windows.Forms.RadioButton();
            this.rbttodos = new System.Windows.Forms.RadioButton();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            this.dtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtfechainicial = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rptAuditoria1 = new Neveria.Reporte.RptAuditoria();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(951, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.brnmostrar);
            this.panel1.Controls.Add(this.cboxusuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblAl);
            this.panel1.Controls.Add(this.lblDel);
            this.panel1.Controls.Add(this.dtfechafinal);
            this.panel1.Controls.Add(this.dtfechainicial);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(234, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 77);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 28);
            this.panel4.TabIndex = 11;
            // 
            // brnmostrar
            // 
            this.brnmostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnmostrar.BackgroundImage")));
            this.brnmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brnmostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnmostrar.Enabled = false;
            this.brnmostrar.Location = new System.Drawing.Point(74, 367);
            this.brnmostrar.Margin = new System.Windows.Forms.Padding(4);
            this.brnmostrar.Name = "brnmostrar";
            this.brnmostrar.Size = new System.Drawing.Size(77, 53);
            this.brnmostrar.TabIndex = 40;
            this.brnmostrar.UseVisualStyleBackColor = true;
            this.brnmostrar.Click += new System.EventHandler(this.brnmostrar_Click);
            // 
            // cboxusuario
            // 
            this.cboxusuario.FormattingEnabled = true;
            this.cboxusuario.Location = new System.Drawing.Point(18, 302);
            this.cboxusuario.Name = "cboxusuario";
            this.cboxusuario.Size = new System.Drawing.Size(189, 24);
            this.cboxusuario.TabIndex = 2;
            this.cboxusuario.SelectedIndexChanged += new System.EventHandler(this.cboxusuario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtusuario);
            this.groupBox1.Controls.Add(this.rbttodos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(175, 135);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar";
            // 
            // rbtusuario
            // 
            this.rbtusuario.AutoSize = true;
            this.rbtusuario.Location = new System.Drawing.Point(16, 87);
            this.rbtusuario.Name = "rbtusuario";
            this.rbtusuario.Size = new System.Drawing.Size(79, 24);
            this.rbtusuario.TabIndex = 1;
            this.rbtusuario.TabStop = true;
            this.rbtusuario.Text = "Usario";
            this.rbtusuario.UseVisualStyleBackColor = true;
            this.rbtusuario.CheckedChanged += new System.EventHandler(this.rbtusuario_CheckedChanged);
            // 
            // rbttodos
            // 
            this.rbttodos.AutoSize = true;
            this.rbttodos.Location = new System.Drawing.Point(16, 35);
            this.rbttodos.Name = "rbttodos";
            this.rbttodos.Size = new System.Drawing.Size(76, 24);
            this.rbttodos.TabIndex = 0;
            this.rbttodos.TabStop = true;
            this.rbttodos.Text = "Todos";
            this.rbttodos.UseVisualStyleBackColor = true;
            this.rbttodos.CheckedChanged += new System.EventHandler(this.rbttodos_CheckedChanged);
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(2, 70);
            this.lblAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(24, 17);
            this.lblAl.TabIndex = 37;
            this.lblAl.Text = "Al:";
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Location = new System.Drawing.Point(2, 38);
            this.lblDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(33, 17);
            this.lblDel.TabIndex = 36;
            this.lblDel.Text = "Del:";
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechafinal.Location = new System.Drawing.Point(65, 65);
            this.dtfechafinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtfechafinal.Name = "dtfechafinal";
            this.dtfechafinal.Size = new System.Drawing.Size(156, 22);
            this.dtfechafinal.TabIndex = 35;
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechainicial.Location = new System.Drawing.Point(65, 33);
            this.dtfechainicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtfechainicial.Name = "dtfechainicial";
            this.dtfechainicial.Size = new System.Drawing.Size(156, 22);
            this.dtfechainicial.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.descripcion,
            this.fecha});
            this.dataGridView1.Location = new System.Drawing.Point(234, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 326);
            this.dataGridView1.TabIndex = 2;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 350;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha Y Hora";
            this.fecha.Name = "fecha";
            this.fecha.Width = 150;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsalir.Location = new System.Drawing.Point(516, 342);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(119, 73);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneliminar.BackgroundImage")));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(397, 342);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(111, 73);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(502, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 178);
            this.panel2.TabIndex = 10;
            // 
            // Frm_AufitoriaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AufitoriaUsuario";
            this.Text = "Auditoria por Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Reporte.RptAuditoria rptAuditoria1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label lblAl;
        internal System.Windows.Forms.Label lblDel;
        internal System.Windows.Forms.DateTimePicker dtfechafinal;
        internal System.Windows.Forms.DateTimePicker dtfechainicial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button brnmostrar;
        private System.Windows.Forms.ComboBox cboxusuario;
        private System.Windows.Forms.RadioButton rbtusuario;
        private System.Windows.Forms.RadioButton rbttodos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}