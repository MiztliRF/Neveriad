namespace Neveria.Forms
{
    partial class Frm_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Venta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtclaveA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.spDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsdetalless = new Neveria.dsdetalless();
            this.spDetalleVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetventa2 = new Neveria.datasetventa2();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.BtnGuardardetalle = new System.Windows.Forms.Button();
            this.sp_Detalle_VTableAdapter = new Neveria.datasetventa2TableAdapters.Sp_Detalle_VTableAdapter();
            this.comboarticulo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxcliente = new System.Windows.Forms.ComboBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txtnombrec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sp_DetalleTableAdapter = new Neveria.dsdetallessTableAdapters.Sp_DetalleTableAdapter();
            this.VD_CLAVEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PR_NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VD_CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VD_PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDFOLIOVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDCLAVEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDCANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdetalless)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetventa2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(883, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 38);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(72, 119);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(48, 22);
            this.txtcliente.TabIndex = 1;
            this.txtcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcliente_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clave de Articulos:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Articulo:";
            // 
            // txtclaveA
            // 
            this.txtclaveA.Location = new System.Drawing.Point(143, 37);
            this.txtclaveA.Name = "txtclaveA";
            this.txtclaveA.Size = new System.Drawing.Size(100, 22);
            this.txtclaveA.TabIndex = 9;
            this.txtclaveA.Visible = false;
            this.txtclaveA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclaveA_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número de Venta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha:";
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.Enabled = false;
            this.txtNumVenta.Location = new System.Drawing.Point(733, 54);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.Size = new System.Drawing.Size(128, 22);
            this.txtNumVenta.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 89);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 7, 11, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 7, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2019, 7, 11, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(445, 245);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 22);
            this.txtprecio.TabIndex = 4;
            this.txtprecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprecio_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(616, 243);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 5;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AutoGenerateColumns = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VD_CLAVEP,
            this.PR_NOMBRE,
            this.VD_CANTIDAD,
            this.VD_PRECIO,
            this.Importe,
            this.importeDataGridViewTextBoxColumn,
            this.vDFOLIOVENTADataGridViewTextBoxColumn,
            this.vDCLAVEPDataGridViewTextBoxColumn,
            this.pRNOMBREDataGridViewTextBoxColumn,
            this.vDCANTIDADDataGridViewTextBoxColumn,
            this.vDPRECIODataGridViewTextBoxColumn});
            this.DataTable.DataSource = this.spDetalleBindingSource;
            this.DataTable.Location = new System.Drawing.Point(7, 283);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(919, 221);
            this.DataTable.TabIndex = 19;
            // 
            // spDetalleBindingSource
            // 
            this.spDetalleBindingSource.DataMember = "Sp_Detalle";
            this.spDetalleBindingSource.DataSource = this.dsdetalless;
            // 
            // dsdetalless
            // 
            this.dsdetalless.DataSetName = "dsdetalless";
            this.dsdetalless.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDetalleVBindingSource
            // 
            this.spDetalleVBindingSource.DataMember = "Sp_Detalle_V";
            this.spDetalleVBindingSource.DataSource = this.datasetventa2;
            // 
            // datasetventa2
            // 
            this.datasetventa2.DataSetName = "datasetventa2";
            this.datasetventa2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(730, 545);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cambio:";
            // 
            // txtcambio
            // 
            this.txtcambio.Enabled = false;
            this.txtcambio.Location = new System.Drawing.Point(814, 542);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(104, 22);
            this.txtcambio.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(728, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(814, 571);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(104, 22);
            this.txttotal.TabIndex = 13;
            // 
            // BtnGuardardetalle
            // 
            this.BtnGuardardetalle.Location = new System.Drawing.Point(782, 623);
            this.BtnGuardardetalle.Name = "BtnGuardardetalle";
            this.BtnGuardardetalle.Size = new System.Drawing.Size(116, 44);
            this.BtnGuardardetalle.TabIndex = 11;
            this.BtnGuardardetalle.Text = "Guardar";
            this.BtnGuardardetalle.UseVisualStyleBackColor = true;
            this.BtnGuardardetalle.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // sp_Detalle_VTableAdapter
            // 
            this.sp_Detalle_VTableAdapter.ClearBeforeFill = true;
            // 
            // comboarticulo
            // 
            this.comboarticulo.FormattingEnabled = true;
            this.comboarticulo.Location = new System.Drawing.Point(87, 243);
            this.comboarticulo.Name = "comboarticulo";
            this.comboarticulo.Size = new System.Drawing.Size(301, 24);
            this.comboarticulo.TabIndex = 3;
            this.comboarticulo.SelectedIndexChanged += new System.EventHandler(this.comboarticulo_SelectedIndexChanged);
            this.comboarticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboarticulo_KeyDown);
            this.comboarticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboarticulo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(730, 518);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Pago:";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(814, 515);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(104, 22);
            this.txtpago.TabIndex = 8;
            this.txtpago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpago_KeyPress);
            // 
            // txtimporte
            // 
            this.txtimporte.Enabled = false;
            this.txtimporte.Location = new System.Drawing.Point(782, 245);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(100, 22);
            this.txtimporte.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(722, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Importe:";
            // 
            // cboxcliente
            // 
            this.cboxcliente.FormattingEnabled = true;
            this.cboxcliente.Location = new System.Drawing.Point(186, 119);
            this.cboxcliente.Name = "cboxcliente";
            this.cboxcliente.Size = new System.Drawing.Size(202, 24);
            this.cboxcliente.TabIndex = 32;
            this.cboxcliente.Visible = false;
            this.cboxcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxcliente_KeyDown);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnagregar.Location = new System.Drawing.Point(891, 232);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(63, 38);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.txtagregar_Click);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarcliente.BackgroundImage")));
            this.btnbuscarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscarcliente.Location = new System.Drawing.Point(126, 109);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(54, 38);
            this.btnbuscarcliente.TabIndex = 3;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txtnombrec
            // 
            this.txtnombrec.Enabled = false;
            this.txtnombrec.Location = new System.Drawing.Point(72, 165);
            this.txtnombrec.Name = "txtnombrec";
            this.txtnombrec.Size = new System.Drawing.Size(316, 22);
            this.txtnombrec.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // sp_DetalleTableAdapter
            // 
            this.sp_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // VD_CLAVEP
            // 
            this.VD_CLAVEP.DataPropertyName = "VD_CLAVEP";
            this.VD_CLAVEP.HeaderText = "CLAVE";
            this.VD_CLAVEP.Name = "VD_CLAVEP";
            this.VD_CLAVEP.ReadOnly = true;
            // 
            // PR_NOMBRE
            // 
            this.PR_NOMBRE.DataPropertyName = "PR_NOMBRE";
            this.PR_NOMBRE.HeaderText = "NOMBRE";
            this.PR_NOMBRE.Name = "PR_NOMBRE";
            this.PR_NOMBRE.ReadOnly = true;
            // 
            // VD_CANTIDAD
            // 
            this.VD_CANTIDAD.DataPropertyName = "VD_CANTIDAD";
            this.VD_CANTIDAD.HeaderText = "CANTIDAD";
            this.VD_CANTIDAD.Name = "VD_CANTIDAD";
            this.VD_CANTIDAD.ReadOnly = true;
            // 
            // VD_PRECIO
            // 
            this.VD_PRECIO.DataPropertyName = "VD_PRECIO";
            this.VD_PRECIO.HeaderText = "PRECIO";
            this.VD_PRECIO.Name = "VD_PRECIO";
            this.VD_PRECIO.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "IMPORTE";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDFOLIOVENTADataGridViewTextBoxColumn
            // 
            this.vDFOLIOVENTADataGridViewTextBoxColumn.DataPropertyName = "VD_FOLIOVENTA";
            this.vDFOLIOVENTADataGridViewTextBoxColumn.HeaderText = "VD_FOLIOVENTA";
            this.vDFOLIOVENTADataGridViewTextBoxColumn.Name = "vDFOLIOVENTADataGridViewTextBoxColumn";
            this.vDFOLIOVENTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDCLAVEPDataGridViewTextBoxColumn
            // 
            this.vDCLAVEPDataGridViewTextBoxColumn.DataPropertyName = "VD_CLAVEP";
            this.vDCLAVEPDataGridViewTextBoxColumn.HeaderText = "VD_CLAVEP";
            this.vDCLAVEPDataGridViewTextBoxColumn.Name = "vDCLAVEPDataGridViewTextBoxColumn";
            this.vDCLAVEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRNOMBREDataGridViewTextBoxColumn
            // 
            this.pRNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.HeaderText = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.Name = "pRNOMBREDataGridViewTextBoxColumn";
            this.pRNOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDCANTIDADDataGridViewTextBoxColumn
            // 
            this.vDCANTIDADDataGridViewTextBoxColumn.DataPropertyName = "VD_CANTIDAD";
            this.vDCANTIDADDataGridViewTextBoxColumn.HeaderText = "VD_CANTIDAD";
            this.vDCANTIDADDataGridViewTextBoxColumn.Name = "vDCANTIDADDataGridViewTextBoxColumn";
            this.vDCANTIDADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vDPRECIODataGridViewTextBoxColumn
            // 
            this.vDPRECIODataGridViewTextBoxColumn.DataPropertyName = "VD_PRECIO";
            this.vDPRECIODataGridViewTextBoxColumn.HeaderText = "VD_PRECIO";
            this.vDPRECIODataGridViewTextBoxColumn.Name = "vDPRECIODataGridViewTextBoxColumn";
            this.vDPRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(966, 719);
            this.Controls.Add(this.txtnombrec);
            this.Controls.Add(this.cboxcliente);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboarticulo);
            this.Controls.Add(this.BtnGuardardetalle);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNumVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtclaveA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Venta";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "-";
            this.Load += new System.EventHandler(this.Frm_Venta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdetalless)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetventa2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtclaveA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button BtnGuardardetalle;
        private System.Windows.Forms.BindingSource spDetalleVBindingSource;
        private datasetventa2 datasetventa2;
        private datasetventa2TableAdapters.Sp_Detalle_VTableAdapter sp_Detalle_VTableAdapter;
        private System.Windows.Forms.ComboBox comboarticulo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboxcliente;
        private System.Windows.Forms.TextBox txtnombrec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource spDetalleBindingSource;
        private dsdetalless dsdetalless;
        private dsdetallessTableAdapters.Sp_DetalleTableAdapter sp_DetalleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn VD_CLAVEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PR_NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn VD_CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VD_PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDFOLIOVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDCLAVEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDCANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDPRECIODataGridViewTextBoxColumn;
    }
}