namespace Neveria.Forms
{
    partial class Frm_Compras
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
            this.btnbuscarv = new System.Windows.Forms.Button();
            this.btnguardarv = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsproveedor = new Neveria.dsproveedor();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folioCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spDetalleCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsdetalle = new Neveria.dsdetalle();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.MaskedTextBox();
            this.txtcantidad = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.sp_Detalle_CTableAdapter = new Neveria.dsdetalleTableAdapters.Sp_Detalle_CTableAdapter();
            this.proveedorTableAdapter = new Neveria.dsproveedorTableAdapters.ProveedorTableAdapter();
            this.comboarticulo = new System.Windows.Forms.ComboBox();
            this.txtfoliomat = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsproveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscarv
            // 
            this.btnbuscarv.Location = new System.Drawing.Point(172, 411);
            this.btnbuscarv.Name = "btnbuscarv";
            this.btnbuscarv.Size = new System.Drawing.Size(101, 33);
            this.btnbuscarv.TabIndex = 40;
            this.btnbuscarv.Text = "BUSCAR";
            this.btnbuscarv.UseVisualStyleBackColor = true;
            // 
            // btnguardarv
            // 
            this.btnguardarv.Location = new System.Drawing.Point(53, 411);
            this.btnguardarv.Name = "btnguardarv";
            this.btnguardarv.Size = new System.Drawing.Size(101, 33);
            this.btnguardarv.TabIndex = 39;
            this.btnguardarv.Text = "GUARDAR";
            this.btnguardarv.UseVisualStyleBackColor = true;
            this.btnguardarv.Click += new System.EventHandler(this.btnguardarv_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(183, 24);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(70, 29);
            this.btnguardar.TabIndex = 38;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Enabled = false;
            this.txtimporte.Location = new System.Drawing.Point(548, 159);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(100, 22);
            this.txtimporte.TabIndex = 36;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.proveedorBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(490, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "Folio";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dsproveedor;
            // 
            // dsproveedor
            // 
            this.dsproveedor.DataSetName = "dsproveedor";
            this.dsproveedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Folio Proveedor";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(580, 27);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(125, 30);
            this.btnbuscar.TabIndex = 33;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Folio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioCompraDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spDetalleCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 196);
            this.dataGridView1.TabIndex = 27;
            // 
            // folioCompraDataGridViewTextBoxColumn
            // 
            this.folioCompraDataGridViewTextBoxColumn.DataPropertyName = "Folio_Compra";
            this.folioCompraDataGridViewTextBoxColumn.HeaderText = "Folio_Compra";
            this.folioCompraDataGridViewTextBoxColumn.Name = "folioCompraDataGridViewTextBoxColumn";
            this.folioCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spDetalleCBindingSource
            // 
            this.spDetalleCBindingSource.DataMember = "Sp_Detalle_C";
            this.spDetalleCBindingSource.DataSource = this.dsdetalle;
            // 
            // dsdetalle
            // 
            this.dsdetalle.DataSetName = "dsdetalle";
            this.dsdetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(654, 155);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(125, 30);
            this.btnagregar.TabIndex = 26;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(428, 159);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(114, 22);
            this.txtprecio.TabIndex = 25;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(308, 159);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(114, 22);
            this.txtcantidad.TabIndex = 24;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(65, 27);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(114, 22);
            this.txtfolio.TabIndex = 21;
            this.txtfolio.Text = "0";
            // 
            // sp_Detalle_CTableAdapter
            // 
            this.sp_Detalle_CTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // comboarticulo
            // 
            this.comboarticulo.FormattingEnabled = true;
            this.comboarticulo.Location = new System.Drawing.Point(53, 161);
            this.comboarticulo.Name = "comboarticulo";
            this.comboarticulo.Size = new System.Drawing.Size(239, 24);
            this.comboarticulo.TabIndex = 43;
            this.comboarticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboarticulo_KeyDown);
            // 
            // txtfoliomat
            // 
            this.txtfoliomat.Location = new System.Drawing.Point(12, 163);
            this.txtfoliomat.Name = "txtfoliomat";
            this.txtfoliomat.Size = new System.Drawing.Size(23, 22);
            this.txtfoliomat.TabIndex = 44;
            this.txtfoliomat.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(780, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 30);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Frm_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 459);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtfoliomat);
            this.Controls.Add(this.comboarticulo);
            this.Controls.Add(this.btnbuscarv);
            this.Controls.Add(this.btnguardarv);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtfolio);
            this.Name = "Frm_Compras";
            this.Text = "Frm_Compras";
            this.Load += new System.EventHandler(this.Frm_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsproveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscarv;
        private System.Windows.Forms.Button btnguardarv;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.MaskedTextBox txtprecio;
        private System.Windows.Forms.MaskedTextBox txtcantidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spDetalleCBindingSource;
        private dsdetalle dsdetalle;
        private dsdetalleTableAdapters.Sp_Detalle_CTableAdapter sp_Detalle_CTableAdapter;
        private dsproveedor dsproveedor;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private dsproveedorTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.ComboBox comboarticulo;
        private System.Windows.Forms.TextBox txtfoliomat;
        private System.Windows.Forms.Button btnEliminar;
    }
}