namespace Neveria.Forms
{
    partial class Frm_proveedores_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_proveedores_B));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datasetproveedor1 = new Neveria.datasetproveedor1();
            this.proveedorTableAdapter1 = new Neveria.datasetproveedor1TableAdapters.ProveedorTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noINTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDColoniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMUNICIPIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREMUNICIPIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRELOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCOLONIA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECOLONIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresdataset = new Neveria.Proveedoresdataset();
            this.proveedorTableAdapter = new Neveria.ProveedoresdatasetTableAdapters.ProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetproveedor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(234, 31);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(643, 22);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(963, 493);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(1044, 493);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.datasetproveedor1;
            // 
            // datasetproveedor1
            // 
            this.datasetproveedor1.DataSetName = "datasetproveedor1";
            this.datasetproveedor1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.cALLEDataGridViewTextBoxColumn,
            this.noEXTDataGridViewTextBoxColumn,
            this.noINTDataGridViewTextBoxColumn,
            this.rFCDataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.iDColoniaDataGridViewTextBoxColumn,
            this.iDMUNICIPIODataGridViewTextBoxColumn,
            this.nOMBREMUNICIPIODataGridViewTextBoxColumn,
            this.iDLOCALIDADDataGridViewTextBoxColumn,
            this.nOMBRELOCALIDADDataGridViewTextBoxColumn,
            this.iDCOLONIA1DataGridViewTextBoxColumn,
            this.nOMBRECOLONIADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1423, 400);
            this.dataGridView1.TabIndex = 5;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cALLEDataGridViewTextBoxColumn
            // 
            this.cALLEDataGridViewTextBoxColumn.DataPropertyName = "CALLE";
            this.cALLEDataGridViewTextBoxColumn.HeaderText = "CALLE";
            this.cALLEDataGridViewTextBoxColumn.Name = "cALLEDataGridViewTextBoxColumn";
            // 
            // noEXTDataGridViewTextBoxColumn
            // 
            this.noEXTDataGridViewTextBoxColumn.DataPropertyName = "NoEXT";
            this.noEXTDataGridViewTextBoxColumn.HeaderText = "NoEXT";
            this.noEXTDataGridViewTextBoxColumn.Name = "noEXTDataGridViewTextBoxColumn";
            // 
            // noINTDataGridViewTextBoxColumn
            // 
            this.noINTDataGridViewTextBoxColumn.DataPropertyName = "NoINT";
            this.noINTDataGridViewTextBoxColumn.HeaderText = "NoINT";
            this.noINTDataGridViewTextBoxColumn.Name = "noINTDataGridViewTextBoxColumn";
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            // 
            // iDColoniaDataGridViewTextBoxColumn
            // 
            this.iDColoniaDataGridViewTextBoxColumn.DataPropertyName = "ID Colonia";
            this.iDColoniaDataGridViewTextBoxColumn.HeaderText = "ID Colonia";
            this.iDColoniaDataGridViewTextBoxColumn.Name = "iDColoniaDataGridViewTextBoxColumn";
            // 
            // iDMUNICIPIODataGridViewTextBoxColumn
            // 
            this.iDMUNICIPIODataGridViewTextBoxColumn.DataPropertyName = "ID MUNICIPIO";
            this.iDMUNICIPIODataGridViewTextBoxColumn.HeaderText = "ID MUNICIPIO";
            this.iDMUNICIPIODataGridViewTextBoxColumn.Name = "iDMUNICIPIODataGridViewTextBoxColumn";
            // 
            // nOMBREMUNICIPIODataGridViewTextBoxColumn
            // 
            this.nOMBREMUNICIPIODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE MUNICIPIO";
            this.nOMBREMUNICIPIODataGridViewTextBoxColumn.HeaderText = "NOMBRE MUNICIPIO";
            this.nOMBREMUNICIPIODataGridViewTextBoxColumn.Name = "nOMBREMUNICIPIODataGridViewTextBoxColumn";
            // 
            // iDLOCALIDADDataGridViewTextBoxColumn
            // 
            this.iDLOCALIDADDataGridViewTextBoxColumn.DataPropertyName = "ID LOCALIDAD";
            this.iDLOCALIDADDataGridViewTextBoxColumn.HeaderText = "ID LOCALIDAD";
            this.iDLOCALIDADDataGridViewTextBoxColumn.Name = "iDLOCALIDADDataGridViewTextBoxColumn";
            // 
            // nOMBRELOCALIDADDataGridViewTextBoxColumn
            // 
            this.nOMBRELOCALIDADDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE LOCALIDAD";
            this.nOMBRELOCALIDADDataGridViewTextBoxColumn.HeaderText = "NOMBRE LOCALIDAD";
            this.nOMBRELOCALIDADDataGridViewTextBoxColumn.Name = "nOMBRELOCALIDADDataGridViewTextBoxColumn";
            // 
            // iDCOLONIA1DataGridViewTextBoxColumn
            // 
            this.iDCOLONIA1DataGridViewTextBoxColumn.DataPropertyName = "ID COLONIA1";
            this.iDCOLONIA1DataGridViewTextBoxColumn.HeaderText = "ID COLONIA1";
            this.iDCOLONIA1DataGridViewTextBoxColumn.Name = "iDCOLONIA1DataGridViewTextBoxColumn";
            // 
            // nOMBRECOLONIADataGridViewTextBoxColumn
            // 
            this.nOMBRECOLONIADataGridViewTextBoxColumn.DataPropertyName = "NOMBRE COLONIA";
            this.nOMBRECOLONIADataGridViewTextBoxColumn.HeaderText = "NOMBRE COLONIA";
            this.nOMBRECOLONIADataGridViewTextBoxColumn.Name = "nOMBRECOLONIADataGridViewTextBoxColumn";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.proveedoresdataset;
            // 
            // proveedoresdataset
            // 
            this.proveedoresdataset.DataSetName = "Proveedoresdataset";
            this.proveedoresdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_proveedores_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1447, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Name = "Frm_proveedores_B";
            this.Text = "Busqueda:";
            this.Load += new System.EventHandler(this.Frm_proveedores_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetproveedor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresdataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private Proveedoresdataset proveedoresdataset;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private ProveedoresdatasetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private datasetproveedor1 datasetproveedor1;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private datasetproveedor1TableAdapters.ProveedorTableAdapter proveedorTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noINTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDColoniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMUNICIPIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREMUNICIPIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRELOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOLONIA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECOLONIADataGridViewTextBoxColumn;
    }
}