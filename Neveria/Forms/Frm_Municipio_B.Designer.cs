namespace Neveria.Forms
{
    partial class Frm_Municipio_B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Municipio_B));
            this.btncancelar = new System.Windows.Forms.Button();
            this.brnaceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datasetmunicipio = new Neveria.datasetmunicipio();
            this.municipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipioTableAdapter = new Neveria.datasetmunicipioTableAdapters.MunicipioTableAdapter();
            this.iDMunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmuicipio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetmunicipio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(360, 338);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 30);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // brnaceptar
            // 
            this.brnaceptar.Location = new System.Drawing.Point(276, 338);
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
            this.iDMunicipioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.municipioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 272);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(91, 10);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(298, 22);
            this.txtbusqueda.TabIndex = 11;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Busqueda:";
            // 
            // datasetmunicipio
            // 
            this.datasetmunicipio.DataSetName = "datasetmunicipio";
            this.datasetmunicipio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // municipioBindingSource
            // 
            this.municipioBindingSource.DataMember = "Municipio";
            this.municipioBindingSource.DataSource = this.datasetmunicipio;
            // 
            // municipioTableAdapter
            // 
            this.municipioTableAdapter.ClearBeforeFill = true;
            // 
            // iDMunicipioDataGridViewTextBoxColumn
            // 
            this.iDMunicipioDataGridViewTextBoxColumn.DataPropertyName = "IDMunicipio";
            this.iDMunicipioDataGridViewTextBoxColumn.HeaderText = "IDMunicipio";
            this.iDMunicipioDataGridViewTextBoxColumn.Name = "iDMunicipioDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // btnmuicipio
            // 
            this.btnmuicipio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmuicipio.BackgroundImage")));
            this.btnmuicipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmuicipio.Location = new System.Drawing.Point(395, 5);
            this.btnmuicipio.Name = "btnmuicipio";
            this.btnmuicipio.Size = new System.Drawing.Size(86, 33);
            this.btnmuicipio.TabIndex = 15;
            this.btnmuicipio.UseVisualStyleBackColor = true;
            this.btnmuicipio.Click += new System.EventHandler(this.btnmuicipio_Click);
            // 
            // Frm_Municipio_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 373);
            this.Controls.Add(this.btnmuicipio);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.brnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Municipio_B";
            this.Text = "Frm_Municipio_B";
            this.Load += new System.EventHandler(this.Frm_Municipio_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetmunicipio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button brnaceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private datasetmunicipio datasetmunicipio;
        private System.Windows.Forms.BindingSource municipioBindingSource;
        private datasetmunicipioTableAdapters.MunicipioTableAdapter municipioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnmuicipio;
    }
}