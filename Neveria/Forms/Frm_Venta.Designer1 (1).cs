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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtfoliomat = new System.Windows.Forms.TextBox();
            this.btnbuscarv = new System.Windows.Forms.Button();
            this.btnguardarv = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetCliente = new Neveria.datasetCliente();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.MaskedTextBox();
            this.txtcantidad = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new Neveria.datasetClienteTableAdapters.ClienteTableAdapter();
            this.comboarticulo = new System.Windows.Forms.ComboBox();
            this.sPVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spDetalle = new Neveria.spDetalle();
            this.spDetalleVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_Detalle_VTableAdapter = new Neveria.spDetalleTableAdapters.Sp_Detalle_VTableAdapter();
            this.folioVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(770, 148);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 30);
            this.btnEliminar.TabIndex = 67;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtfoliomat
            // 
            this.txtfoliomat.Location = new System.Drawing.Point(2, 156);
            this.txtfoliomat.Name = "txtfoliomat";
            this.txtfoliomat.Size = new System.Drawing.Size(23, 22);
            this.txtfoliomat.TabIndex = 66;
            this.txtfoliomat.Visible = false;
            // 
            // btnbuscarv
            // 
            this.btnbuscarv.Location = new System.Drawing.Point(162, 404);
            this.btnbuscarv.Name = "btnbuscarv";
            this.btnbuscarv.Size = new System.Drawing.Size(101, 33);
            this.btnbuscarv.TabIndex = 64;
            this.btnbuscarv.Text = "BUSCAR";
            this.btnbuscarv.UseVisualStyleBackColor = true;
            // 
            // btnguardarv
            // 
            this.btnguardarv.Location = new System.Drawing.Point(43, 404);
            this.btnguardarv.Name = "btnguardarv";
            this.btnguardarv.Size = new System.Drawing.Size(101, 33);
            this.btnguardarv.TabIndex = 63;
            this.btnguardarv.Text = "GUARDAR";
            this.btnguardarv.UseVisualStyleBackColor = true;
            this.btnguardarv.Click += new System.EventHandler(this.btnguardarv_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(173, 17);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(70, 29);
            this.btnguardar.TabIndex = 62;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 61;
            this.label7.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Enabled = false;
            this.txtimporte.Location = new System.Drawing.Point(538, 152);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(100, 22);
            this.txtimporte.TabIndex = 60;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clienteBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(490, 24);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.ValueMember = "Folio";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.datasetCliente;
            // 
            // datasetCliente
            // 
            this.datasetCliente.DataSetName = "datasetCliente";
            this.datasetCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Folio Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Folio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioVentaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spDetalleVBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 196);
            this.dataGridView1.TabIndex = 51;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(644, 148);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(125, 30);
            this.btnagregar.TabIndex = 50;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(418, 152);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(114, 22);
            this.txtprecio.TabIndex = 49;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(298, 152);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(114, 22);
            this.txtcantidad.TabIndex = 48;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(55, 20);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(114, 22);
            this.txtfolio.TabIndex = 46;
            this.txtfolio.Text = "0";
            this.txtfolio.TextChanged += new System.EventHandler(this.txtfolio_TextChanged);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // comboarticulo
            // 
            this.comboarticulo.FormattingEnabled = true;
            this.comboarticulo.Location = new System.Drawing.Point(43, 154);
            this.comboarticulo.Name = "comboarticulo";
            this.comboarticulo.Size = new System.Drawing.Size(239, 24);
            this.comboarticulo.TabIndex = 65;
            this.comboarticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboarticulo_KeyDown);
            // 
            // sP_VentasTableAdapter
            // 
            // spDetalle
            // 
            this.spDetalle.DataSetName = "spDetalle";
            this.spDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDetalleVBindingSource
            // 
            this.spDetalleVBindingSource.DataMember = "Sp_Detalle_V";
            this.spDetalleVBindingSource.DataSource = this.spDetalle;
            // 
            // sp_Detalle_VTableAdapter
            // 
            this.sp_Detalle_VTableAdapter.ClearBeforeFill = true;
            // 
            // folioVentaDataGridViewTextBoxColumn
            // 
            this.folioVentaDataGridViewTextBoxColumn.DataPropertyName = "Folio_Venta";
            this.folioVentaDataGridViewTextBoxColumn.HeaderText = "Folio_Venta";
            this.folioVentaDataGridViewTextBoxColumn.Name = "folioVentaDataGridViewTextBoxColumn";
            this.folioVentaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 449);
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
            this.Name = "Frm_Venta";
            this.Text = "Frm_Venta";
            this.Load += new System.EventHandler(this.Frm_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDetalleVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtfoliomat;
        private System.Windows.Forms.Button btnbuscarv;
        private System.Windows.Forms.Button btnguardarv;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
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
        private datasetCliente datasetCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private datasetClienteTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ComboBox comboarticulo;
        private System.Windows.Forms.BindingSource sPVentasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource spDetalleVBindingSource;
        private spDetalle spDetalle;
        private spDetalleTableAdapters.Sp_Detalle_VTableAdapter sp_Detalle_VTableAdapter;
    }
}