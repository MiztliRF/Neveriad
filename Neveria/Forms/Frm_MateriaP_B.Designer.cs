namespace Neveria.Forms
{
    partial class Frm_MateriaP_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MateriaP_B));
            this.btncancelar = new System.Windows.Forms.Button();
            this.brnaceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folioCompraDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaPrimaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetmateriap = new Neveria.datasetmateriap();
            this.materia_PrimaTableAdapter = new Neveria.datasetmateriapTableAdapters.Materia_PrimaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetmateriap)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(340, 342);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 30);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // brnaceptar
            // 
            this.brnaceptar.Location = new System.Drawing.Point(256, 342);
            this.brnaceptar.Name = "brnaceptar";
            this.brnaceptar.Size = new System.Drawing.Size(87, 30);
            this.brnaceptar.TabIndex = 13;
            this.brnaceptar.Text = "Aceptar";
            this.brnaceptar.UseVisualStyleBackColor = true;
            this.brnaceptar.Click += new System.EventHandler(this.brnaceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.folioCompraDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materiaPrimaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 272);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(91, 8);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(298, 22);
            this.txtbusqueda.TabIndex = 11;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Busqueda:";
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "Clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // folioCompraDDataGridViewTextBoxColumn
            // 
            this.folioCompraDDataGridViewTextBoxColumn.DataPropertyName = "Folio_Compra_D";
            this.folioCompraDDataGridViewTextBoxColumn.HeaderText = "Folio_Compra_D";
            this.folioCompraDDataGridViewTextBoxColumn.Name = "folioCompraDDataGridViewTextBoxColumn";
            // 
            // materiaPrimaBindingSource
            // 
            this.materiaPrimaBindingSource.DataMember = "Materia_Prima";
            this.materiaPrimaBindingSource.DataSource = this.datasetmateriap;
            // 
            // datasetmateriap
            // 
            this.datasetmateriap.DataSetName = "datasetmateriap";
            this.datasetmateriap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materia_PrimaTableAdapter
            // 
            this.materia_PrimaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_MateriaP_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 375);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.brnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Name = "Frm_MateriaP_B";
            this.Text = "Frm_MateriaP_B";
            this.Load += new System.EventHandler(this.Frm_MateriaP_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaPrimaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetmateriap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button brnaceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private datasetmateriap datasetmateriap;
        private System.Windows.Forms.BindingSource materiaPrimaBindingSource;
        private datasetmateriapTableAdapters.Materia_PrimaTableAdapter materia_PrimaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioCompraDDataGridViewTextBoxColumn;
    }
}