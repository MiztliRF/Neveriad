namespace Neveria.Forms
{
    partial class Frm_Colonia_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Colonia_B));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.iDColoniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetcoloniab = new Neveria.datasetcoloniab();
            this.coloniaTableAdapter = new Neveria.datasetcoloniabTableAdapters.ColoniaTableAdapter();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcoloniab)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(99, 33);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(298, 22);
            this.txtbusqueda.TabIndex = 1;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDColoniaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coloniaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 272);
            this.dataGridView1.TabIndex = 2;
            // 
            // brnaceptar
            // 
            this.brnaceptar.Location = new System.Drawing.Point(284, 361);
            this.brnaceptar.Name = "brnaceptar";
            this.brnaceptar.Size = new System.Drawing.Size(87, 30);
            this.brnaceptar.TabIndex = 3;
            this.brnaceptar.Text = "Aceptar";
            this.brnaceptar.UseVisualStyleBackColor = true;
            this.brnaceptar.Click += new System.EventHandler(this.brnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(377, 361);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 30);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // iDColoniaDataGridViewTextBoxColumn
            // 
            this.iDColoniaDataGridViewTextBoxColumn.DataPropertyName = "IDColonia";
            this.iDColoniaDataGridViewTextBoxColumn.HeaderText = "IDColonia";
            this.iDColoniaDataGridViewTextBoxColumn.Name = "iDColoniaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // coloniaBindingSource
            // 
            this.coloniaBindingSource.DataMember = "Colonia";
            this.coloniaBindingSource.DataSource = this.datasetcoloniab;
            // 
            // datasetcoloniab
            // 
            this.datasetcoloniab.DataSetName = "datasetcoloniab";
            this.datasetcoloniab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coloniaTableAdapter
            // 
            this.coloniaTableAdapter.ClearBeforeFill = true;
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnagregar.Location = new System.Drawing.Point(403, 12);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(68, 53);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Frm_Colonia_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 403);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.brnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Colonia_B";
            this.Text = "Buscar Colonia ";
            this.Load += new System.EventHandler(this.Frm_Colonia_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetcoloniab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private datasetcoloniab datasetcoloniab;
        private System.Windows.Forms.BindingSource coloniaBindingSource;
        private datasetcoloniabTableAdapters.ColoniaTableAdapter coloniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDColoniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLocalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button brnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnagregar;
    }
}