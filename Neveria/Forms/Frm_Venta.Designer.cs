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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Venta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txtclienteN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxempleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtclaveA = new System.Windows.Forms.TextBox();
            this.btnbuscarArticulo = new System.Windows.Forms.Button();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumVenta = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtagregar = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.nEVERIACDataSet1 = new Neveria.NEVERIACDataSet1();
            this.nEVERIACDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEVERIACDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEVERIACDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(883, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 38);
            this.panel2.TabIndex = 0;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(145, 91);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(100, 22);
            this.txtcliente.TabIndex = 1;
            this.txtcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcliente_KeyDown);
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarcliente.BackgroundImage")));
            this.btnbuscarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscarcliente.Location = new System.Drawing.Point(251, 75);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(96, 38);
            this.btnbuscarcliente.TabIndex = 3;
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txtclienteN
            // 
            this.txtclienteN.Location = new System.Drawing.Point(353, 91);
            this.txtclienteN.Name = "txtclienteN";
            this.txtclienteN.Size = new System.Drawing.Size(222, 22);
            this.txtclienteN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleado:";
            // 
            // cboxempleado
            // 
            this.cboxempleado.FormattingEnabled = true;
            this.cboxempleado.Location = new System.Drawing.Point(145, 133);
            this.cboxempleado.Name = "cboxempleado";
            this.cboxempleado.Size = new System.Drawing.Size(202, 24);
            this.cboxempleado.TabIndex = 6;
            this.cboxempleado.SelectedIndexChanged += new System.EventHandler(this.cboxempleado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clave de Articulos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Articulo:";
            // 
            // txtclaveA
            // 
            this.txtclaveA.Location = new System.Drawing.Point(145, 188);
            this.txtclaveA.Name = "txtclaveA";
            this.txtclaveA.Size = new System.Drawing.Size(100, 22);
            this.txtclaveA.TabIndex = 9;
            this.txtclaveA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclaveA_KeyDown);
            // 
            // btnbuscarArticulo
            // 
            this.btnbuscarArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscarArticulo.BackgroundImage")));
            this.btnbuscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscarArticulo.Location = new System.Drawing.Point(251, 172);
            this.btnbuscarArticulo.Name = "btnbuscarArticulo";
            this.btnbuscarArticulo.Size = new System.Drawing.Size(96, 38);
            this.btnbuscarArticulo.TabIndex = 10;
            this.btnbuscarArticulo.UseVisualStyleBackColor = true;
            this.btnbuscarArticulo.Click += new System.EventHandler(this.btnbuscarArticulo_Click);
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(145, 238);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(379, 22);
            this.txtArticulo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número de Venta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha:";
            // 
            // txtNumVenta
            // 
            this.txtNumVenta.Enabled = false;
            this.txtNumVenta.Location = new System.Drawing.Point(733, 54);
            this.txtNumVenta.Name = "txtNumVenta";
            this.txtNumVenta.Size = new System.Drawing.Size(128, 22);
            this.txtNumVenta.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(707, 89);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 7, 11, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 7, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2019, 7, 11, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(588, 235);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 22);
            this.txtprecio.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(694, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(761, 235);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 19;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // txtagregar
            // 
            this.txtagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtagregar.BackgroundImage")));
            this.txtagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtagregar.Location = new System.Drawing.Point(867, 227);
            this.txtagregar.Name = "txtagregar";
            this.txtagregar.Size = new System.Drawing.Size(63, 38);
            this.txtagregar.TabIndex = 20;
            this.txtagregar.UseVisualStyleBackColor = true;
            this.txtagregar.Click += new System.EventHandler(this.txtagregar_Click);
            // 
            // DataTable
            // 
            this.DataTable.AutoGenerateColumns = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.DataSource = this.nEVERIACDataSet1BindingSource;
            this.DataTable.Location = new System.Drawing.Point(7, 283);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowTemplate.Height = 24;
            this.DataTable.Size = new System.Drawing.Size(911, 221);
            this.DataTable.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(728, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Subtotal:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Location = new System.Drawing.Point(814, 529);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(104, 22);
            this.txtsubtotal.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(728, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(814, 571);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(104, 22);
            this.txttotal.TabIndex = 25;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(814, 615);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(116, 44);
            this.BtnGuardar.TabIndex = 26;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // nEVERIACDataSet1
            // 
            this.nEVERIACDataSet1.DataSetName = "NEVERIACDataSet1";
            this.nEVERIACDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nEVERIACDataSet1BindingSource
            // 
            this.nEVERIACDataSet1BindingSource.DataSource = this.nEVERIACDataSet1;
            this.nEVERIACDataSet1BindingSource.Position = 0;
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(966, 719);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.txtagregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNumVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.btnbuscarArticulo);
            this.Controls.Add(this.txtclaveA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboxempleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtclienteN);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Venta";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Venta";
            this.Load += new System.EventHandler(this.Frm_Venta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEVERIACDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEVERIACDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txtclienteN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxempleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtclaveA;
        private System.Windows.Forms.Button btnbuscarArticulo;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumVenta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button txtagregar;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.BindingSource nEVERIACDataSet1BindingSource;
        private NEVERIACDataSet1 nEVERIACDataSet1;
    }
}