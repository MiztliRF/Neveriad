namespace Neveria.Forms
{
    partial class frminfoventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminfoventa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtntodos = new System.Windows.Forms.RadioButton();
            this.rbtnproducto = new System.Windows.Forms.RadioButton();
            this.cboxproducto = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            this.dtfechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtfechainicial = new System.Windows.Forms.DateTimePicker();
            this.FV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxproducto);
            this.groupBox1.Controls.Add(this.rbtnproducto);
            this.groupBox1.Controls.Add(this.rbtntodos);
            this.groupBox1.Location = new System.Drawing.Point(8, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione";
            // 
            // rbtntodos
            // 
            this.rbtntodos.AutoSize = true;
            this.rbtntodos.Location = new System.Drawing.Point(24, 22);
            this.rbtntodos.Name = "rbtntodos";
            this.rbtntodos.Size = new System.Drawing.Size(69, 21);
            this.rbtntodos.TabIndex = 0;
            this.rbtntodos.TabStop = true;
            this.rbtntodos.Text = "Todos";
            this.rbtntodos.UseVisualStyleBackColor = true;
            this.rbtntodos.CheckedChanged += new System.EventHandler(this.rbtntodos_CheckedChanged);
            // 
            // rbtnproducto
            // 
            this.rbtnproducto.AutoSize = true;
            this.rbtnproducto.Location = new System.Drawing.Point(24, 77);
            this.rbtnproducto.Name = "rbtnproducto";
            this.rbtnproducto.Size = new System.Drawing.Size(86, 21);
            this.rbtnproducto.TabIndex = 0;
            this.rbtnproducto.TabStop = true;
            this.rbtnproducto.Text = "Producto";
            this.rbtnproducto.UseVisualStyleBackColor = true;
            this.rbtnproducto.CheckedChanged += new System.EventHandler(this.rbtnproducto_CheckedChanged);
            // 
            // cboxproducto
            // 
            this.cboxproducto.Enabled = false;
            this.cboxproducto.FormattingEnabled = true;
            this.cboxproducto.Location = new System.Drawing.Point(127, 74);
            this.cboxproducto.Name = "cboxproducto";
            this.cboxproducto.Size = new System.Drawing.Size(187, 24);
            this.cboxproducto.TabIndex = 1;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(224, 283);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 54);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmostrar.BackgroundImage")));
            this.btnmostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmostrar.Enabled = false;
            this.btnmostrar.Location = new System.Drawing.Point(75, 283);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 54);
            this.btnmostrar.TabIndex = 0;
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FV,
            this.CP,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Importe,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(350, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 331);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(29, 67);
            this.lblAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(24, 17);
            this.lblAl.TabIndex = 41;
            this.lblAl.Text = "Al:";
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Location = new System.Drawing.Point(29, 35);
            this.lblDel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(33, 17);
            this.lblDel.TabIndex = 40;
            this.lblDel.Text = "Del:";
            // 
            // dtfechafinal
            // 
            this.dtfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechafinal.Location = new System.Drawing.Point(92, 62);
            this.dtfechafinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtfechafinal.Name = "dtfechafinal";
            this.dtfechafinal.Size = new System.Drawing.Size(156, 22);
            this.dtfechafinal.TabIndex = 39;
            // 
            // dtfechainicial
            // 
            this.dtfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechainicial.Location = new System.Drawing.Point(92, 30);
            this.dtfechainicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtfechainicial.Name = "dtfechainicial";
            this.dtfechainicial.Size = new System.Drawing.Size(156, 22);
            this.dtfechainicial.TabIndex = 38;
            // 
            // FV
            // 
            this.FV.HeaderText = "Folio de la Venta";
            this.FV.Name = "FV";
            // 
            // CP
            // 
            this.CP.HeaderText = "Clave Del Producto";
            this.CP.Name = "CP";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha y Hora";
            this.Fecha.Name = "Fecha";
            // 
            // frminfoventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.Controls.Add(this.lblAl);
            this.Controls.Add(this.lblDel);
            this.Controls.Add(this.dtfechafinal);
            this.Controls.Add(this.dtfechainicial);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frminfoventa";
            this.Text = "Imprimir Ventas";
            this.Load += new System.EventHandler(this.frminfoventa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxproducto;
        private System.Windows.Forms.RadioButton rbtnproducto;
        private System.Windows.Forms.RadioButton rbtntodos;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label lblAl;
        internal System.Windows.Forms.Label lblDel;
        internal System.Windows.Forms.DateTimePicker dtfechafinal;
        internal System.Windows.Forms.DateTimePicker dtfechainicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}