namespace Neveria.Forms
{
    partial class frm_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Producto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidp = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Txtexist = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxestatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 39);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resgistro de Producto";
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(610, 3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(78, 33);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 2;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existencia:";
            // 
            // txtidp
            // 
            this.txtidp.Location = new System.Drawing.Point(139, 63);
            this.txtidp.Name = "txtidp";
            this.txtidp.Size = new System.Drawing.Size(88, 22);
            this.txtidp.TabIndex = 6;
            this.txtidp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtidp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(139, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 22);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(139, 147);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(89, 22);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            // 
            // Txtexist
            // 
            this.Txtexist.Enabled = false;
            this.Txtexist.Location = new System.Drawing.Point(139, 199);
            this.Txtexist.Name = "Txtexist";
            this.Txtexist.Size = new System.Drawing.Size(89, 22);
            this.Txtexist.TabIndex = 9;
            this.Txtexist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtexist_KeyDown);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbuscar.BackgroundImage")));
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(233, 53);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(94, 36);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(57, 321);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(94, 36);
            this.btnguardar.TabIndex = 12;
            this.btnguardar.Text = "Guardar ";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Enabled = false;
            this.Btneliminar.Location = new System.Drawing.Point(168, 321);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(94, 36);
            this.Btneliminar.TabIndex = 13;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estatus:";
            this.label6.Visible = false;
            // 
            // cboxestatus
            // 
            this.cboxestatus.Enabled = false;
            this.cboxestatus.FormattingEnabled = true;
            this.cboxestatus.Items.AddRange(new object[] {
            "--Seleccione--",
            "0",
            "1"});
            this.cboxestatus.Location = new System.Drawing.Point(139, 253);
            this.cboxestatus.Name = "cboxestatus";
            this.cboxestatus.Size = new System.Drawing.Size(98, 24);
            this.cboxestatus.TabIndex = 10;
            this.cboxestatus.Text = "1";
            this.cboxestatus.Visible = false;
            this.cboxestatus.SelectedIndexChanged += new System.EventHandler(this.cboxestatus_SelectedIndexChanged);
            // 
            // frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(688, 369);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cboxestatus);
            this.Controls.Add(this.Txtexist);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtidp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Producto";
            this.Text = "frm_Producto";
            this.Load += new System.EventHandler(this.frm_Producto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox Txtexist;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxestatus;
    }
}