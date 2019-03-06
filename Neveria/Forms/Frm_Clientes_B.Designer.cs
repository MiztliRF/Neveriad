namespace Neveria.Forms
{
    partial class Frm_Clientes_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes_B));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetcliente = new Neveria.Datasetcliente();
            this.clienteTableAdapter = new Neveria.DatasetclienteTableAdapters.ClienteTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noINTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rFCDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMUNICIPIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREMUNICIPIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRELOCALIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCOLONIA1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRECOLONIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.noEXTDataGridViewTextBoxColumn,
            this.noINTDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.rFCDataGridViewTextBoxColumn1,
            this.cORREODataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.iDMUNICIPIODataGridViewTextBoxColumn,
            this.nOMBREMUNICIPIODataGridViewTextBoxColumn,
            this.iDLOCALIDADDataGridViewTextBoxColumn,
            this.nOMBRELOCALIDADDataGridViewTextBoxColumn,
            this.iDCOLONIA1DataGridViewTextBoxColumn,
            this.nOMBRECOLONIADataGridViewTextBoxColumn,
            this.nombre1DataGridViewTextBoxColumn,
            this.aPaternoDataGridViewTextBoxColumn,
            this.aMaternoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 249);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rFCDataGridViewTextBoxColumn
            // 
            this.rFCDataGridViewTextBoxColumn.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn.Name = "rFCDataGridViewTextBoxColumn";
            // 
            // CORREO
            // 
            this.CORREO.DataPropertyName = "CORREO";
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.Name = "CORREO";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.datasetcliente;
            // 
            // datasetcliente
            // 
            this.datasetcliente.DataSetName = "Datasetcliente";
            this.datasetcliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FOLIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "FOLIO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CALLE";
            this.dataGridViewTextBoxColumn3.HeaderText = "CALLE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // rFCDataGridViewTextBoxColumn1
            // 
            this.rFCDataGridViewTextBoxColumn1.DataPropertyName = "RFC";
            this.rFCDataGridViewTextBoxColumn1.HeaderText = "RFC";
            this.rFCDataGridViewTextBoxColumn1.Name = "rFCDataGridViewTextBoxColumn1";
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID Colonia";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Colonia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            // nombre1DataGridViewTextBoxColumn
            // 
            this.nombre1DataGridViewTextBoxColumn.DataPropertyName = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn.HeaderText = "Nombre1";
            this.nombre1DataGridViewTextBoxColumn.Name = "nombre1DataGridViewTextBoxColumn";
            // 
            // aPaternoDataGridViewTextBoxColumn
            // 
            this.aPaternoDataGridViewTextBoxColumn.DataPropertyName = "A_Paterno";
            this.aPaternoDataGridViewTextBoxColumn.HeaderText = "A_Paterno";
            this.aPaternoDataGridViewTextBoxColumn.Name = "aPaternoDataGridViewTextBoxColumn";
            // 
            // aMaternoDataGridViewTextBoxColumn
            // 
            this.aMaternoDataGridViewTextBoxColumn.DataPropertyName = "A_Materno";
            this.aMaternoDataGridViewTextBoxColumn.HeaderText = "A_Materno";
            this.aMaternoDataGridViewTextBoxColumn.Name = "aMaternoDataGridViewTextBoxColumn";
            // 
            // Frm_Clientes_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Frm_Clientes_B";
            this.Text = "Buscar Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Datasetcliente datasetcliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DatasetclienteTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numExtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDColoniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noINTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rFCDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMUNICIPIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREMUNICIPIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRELOCALIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOLONIA1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRECOLONIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMaternoDataGridViewTextBoxColumn;
    }
}