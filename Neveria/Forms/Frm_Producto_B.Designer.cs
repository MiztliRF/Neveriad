namespace Neveria.Forms
{
    partial class Frm_Producto_B
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.brnaceptar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productoBdataset = new Neveria.ProductoBdataset();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Neveria.ProductoBdatasetTableAdapters.ProductoTableAdapter();
            this.pRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREXISTENCIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTATUSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 50);
            this.panel1.TabIndex = 0;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(406, 391);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(108, 47);
            this.btncancelar.TabIndex = 24;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // brnaceptar
            // 
            this.brnaceptar.Location = new System.Drawing.Point(290, 391);
            this.brnaceptar.Name = "brnaceptar";
            this.brnaceptar.Size = new System.Drawing.Size(110, 47);
            this.brnaceptar.TabIndex = 23;
            this.brnaceptar.Text = "Aceptar";
            this.brnaceptar.UseVisualStyleBackColor = true;
            this.brnaceptar.Click += new System.EventHandler(this.brnaceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRIDDataGridViewTextBoxColumn,
            this.pRNOMBREDataGridViewTextBoxColumn,
            this.pRPRECIODataGridViewTextBoxColumn,
            this.pREXISTENCIADataGridViewTextBoxColumn,
            this.pRESTATUSDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 272);
            this.dataGridView1.TabIndex = 22;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(102, 62);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(450, 22);
            this.txtbusqueda.TabIndex = 21;
            this.txtbusqueda.TextChanged += new System.EventHandler(this.txtbusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Busqueda:";
            // 
            // productoBdataset
            // 
            this.productoBdataset.DataSetName = "ProductoBdataset";
            this.productoBdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.productoBdataset;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // pRIDDataGridViewTextBoxColumn
            // 
            this.pRIDDataGridViewTextBoxColumn.DataPropertyName = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.HeaderText = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.Name = "pRIDDataGridViewTextBoxColumn";
            // 
            // pRNOMBREDataGridViewTextBoxColumn
            // 
            this.pRNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.HeaderText = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.Name = "pRNOMBREDataGridViewTextBoxColumn";
            // 
            // pRPRECIODataGridViewTextBoxColumn
            // 
            this.pRPRECIODataGridViewTextBoxColumn.DataPropertyName = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.HeaderText = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.Name = "pRPRECIODataGridViewTextBoxColumn";
            // 
            // pREXISTENCIADataGridViewTextBoxColumn
            // 
            this.pREXISTENCIADataGridViewTextBoxColumn.DataPropertyName = "PR_EXISTENCIA";
            this.pREXISTENCIADataGridViewTextBoxColumn.HeaderText = "PR_EXISTENCIA";
            this.pREXISTENCIADataGridViewTextBoxColumn.Name = "pREXISTENCIADataGridViewTextBoxColumn";
            // 
            // pRESTATUSDataGridViewCheckBoxColumn
            // 
            this.pRESTATUSDataGridViewCheckBoxColumn.DataPropertyName = "PR_ESTATUS";
            this.pRESTATUSDataGridViewCheckBoxColumn.HeaderText = "PR_ESTATUS";
            this.pRESTATUSDataGridViewCheckBoxColumn.Name = "pRESTATUSDataGridViewCheckBoxColumn";
            // 
            // Frm_Producto_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.brnaceptar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Producto_B";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Producto_B";
            this.Load += new System.EventHandler(this.Frm_Producto_B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button brnaceptar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private ProductoBdataset productoBdataset;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private ProductoBdatasetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREXISTENCIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pRESTATUSDataGridViewCheckBoxColumn;
    }
}