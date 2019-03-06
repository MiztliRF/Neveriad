namespace Neveria.Forms
{
    partial class Frm_Localidad_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Localidad_B));
            this.btncancelar = new System.Windows.Forms.Button();
            this.brnaceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDLocalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetlocalidad = new Neveria.datasetlocalidad();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.localidadTableAdapter = new Neveria.datasetlocalidadTableAdapters.LocalidadTableAdapter();
            this.btnlocalidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetlocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(374, 350);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 30);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // brnaceptar
            // 
            this.brnaceptar.Location = new System.Drawing.Point(290, 350);
            this.brnaceptar.Name = "brnaceptar";
            this.brnaceptar.Size = new System.Drawing.Size(87, 30);
            this.brnaceptar.TabIndex = 8;
            this.brnaceptar.Text = "Aceptar";
            this.brnaceptar.UseVisualStyleBackColor = true;
            this.brnaceptar.Click += new System.EventHandler(this.brnaceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLocalidadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.iDMunicipioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.localidadBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 272);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDLocalidadDataGridViewTextBoxColumn
            // 
            this.iDLocalidadDataGridViewTextBoxColumn.DataPropertyName = "IDLocalidad";
            this.iDLocalidadDataGridViewTextBoxColumn.HeaderText = "IDLocalidad";
            this.iDLocalidadDataGridViewTextBoxColumn.Name = "iDLocalidadDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // iDMunicipioDataGridViewTextBoxColumn
            // 
            this.iDMunicipioDataGridViewTextBoxColumn.DataPropertyName = "ID_Municipio";
            this.iDMunicipioDataGridViewTextBoxColumn.HeaderText = "ID_Municipio";
            this.iDMunicipioDataGridViewTextBoxColumn.Name = "iDMunicipioDataGridViewTextBoxColumn";
            // 
            // localidadBindingSource
            // 
            this.localidadBindingSource.DataMember = "Localidad";
            this.localidadBindingSource.DataSource = this.datasetlocalidad;
            // 
            // datasetlocalidad
            // 
            this.datasetlocalidad.DataSetName = "datasetlocalidad";
            this.datasetlocalidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(105, 22);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(298, 22);
            this.txtbusqueda.TabIndex = 6;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Busqueda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // localidadTableAdapter
            // 
            this.localidadTableAdapter.ClearBeforeFill = true;
            // 
            // btnlocalidad
            // 
            this.btnlocalidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlocalidad.BackgroundImage")));
            this.btnlocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlocalidad.Location = new System.Drawing.Point(409, 20);
            this.btnlocalidad.Name = "btnlocalidad";
            this.btnlocalidad.Size = new System.Drawing.Size(66, 34);
            this.btnlocalidad.TabIndex = 10;
            this.btnlocalidad.UseVisualStyleBackColor = true;
            this.btnlocalidad.Click += new System.EventHandler(this.btnlocalidad_Click);
            // 
            // Frm_Localidad_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 387);
            this.Controls.Add(this.btnlocalidad);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.brnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Localidad_B";
            this.Text = "Frm_Localidad_B";
            this.Load += new System.EventHandler(this.Frm_Localidad_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetlocalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button brnaceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private datasetlocalidad datasetlocalidad;
        private System.Windows.Forms.BindingSource localidadBindingSource;
        private datasetlocalidadTableAdapters.LocalidadTableAdapter localidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLocalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnlocalidad;
    }
}