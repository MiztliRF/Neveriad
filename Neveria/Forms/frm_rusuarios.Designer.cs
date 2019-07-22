namespace Neveria.Forms
{
    partial class frm_rusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_rusuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtVcontraseña = new System.Windows.Forms.TextBox();
            this.cboxnivel = new System.Windows.Forms.ComboBox();
            this.txtNcontraseña = new System.Windows.Forms.TextBox();
            this.lblNcontraseña = new System.Windows.Forms.Label();
            this.lblVcontraseña = new System.Windows.Forms.Label();
            this.txtVNcontraseña = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.cbcamviarcontraseña = new System.Windows.Forms.CheckBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(167)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 37);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(92, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(68, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Verificar Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(114, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nivel";
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Location = new System.Drawing.Point(159, 73);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(115, 22);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontraseña.Enabled = false;
            this.txtcontraseña.Location = new System.Drawing.Point(159, 117);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontraseña_KeyDown);
            // 
            // txtVcontraseña
            // 
            this.txtVcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVcontraseña.Enabled = false;
            this.txtVcontraseña.Location = new System.Drawing.Point(159, 152);
            this.txtVcontraseña.Name = "txtVcontraseña";
            this.txtVcontraseña.PasswordChar = '*';
            this.txtVcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtVcontraseña.TabIndex = 3;
            this.txtVcontraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVcontraseña_KeyDown);
            // 
            // cboxnivel
            // 
            this.cboxnivel.Enabled = false;
            this.cboxnivel.FormattingEnabled = true;
            this.cboxnivel.Items.AddRange(new object[] {
            "--Selecionar Nivel---",
            "Administrador",
            "Operador"});
            this.cboxnivel.Location = new System.Drawing.Point(159, 190);
            this.cboxnivel.Name = "cboxnivel";
            this.cboxnivel.Size = new System.Drawing.Size(170, 24);
            this.cboxnivel.TabIndex = 4;
            this.cboxnivel.Text = "--Selecionar Nivel--";
            this.cboxnivel.SelectedIndexChanged += new System.EventHandler(this.cboxnivel_SelectedIndexChanged);
            // 
            // txtNcontraseña
            // 
            this.txtNcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNcontraseña.Location = new System.Drawing.Point(156, 259);
            this.txtNcontraseña.Name = "txtNcontraseña";
            this.txtNcontraseña.PasswordChar = '*';
            this.txtNcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtNcontraseña.TabIndex = 6;
            this.txtNcontraseña.Visible = false;
            this.txtNcontraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNcontraseña_KeyDown);
            // 
            // lblNcontraseña
            // 
            this.lblNcontraseña.AutoSize = true;
            this.lblNcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNcontraseña.Location = new System.Drawing.Point(23, 264);
            this.lblNcontraseña.Name = "lblNcontraseña";
            this.lblNcontraseña.Size = new System.Drawing.Size(130, 17);
            this.lblNcontraseña.TabIndex = 10;
            this.lblNcontraseña.Text = "Nueva Contraseña:";
            this.lblNcontraseña.Visible = false;
            // 
            // lblVcontraseña
            // 
            this.lblVcontraseña.AutoSize = true;
            this.lblVcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVcontraseña.Location = new System.Drawing.Point(7, 314);
            this.lblVcontraseña.Name = "lblVcontraseña";
            this.lblVcontraseña.Size = new System.Drawing.Size(141, 17);
            this.lblVcontraseña.TabIndex = 12;
            this.lblVcontraseña.Text = "Verificar Contraseña:";
            this.lblVcontraseña.Visible = false;
            // 
            // txtVNcontraseña
            // 
            this.txtVNcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVNcontraseña.Location = new System.Drawing.Point(156, 309);
            this.txtVNcontraseña.Name = "txtVNcontraseña";
            this.txtVNcontraseña.PasswordChar = '*';
            this.txtVNcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtVNcontraseña.TabIndex = 7;
            this.txtVNcontraseña.Visible = false;
            this.txtVNcontraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVNcontraseña_KeyDown);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar.BackgroundImage")));
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(15, 372);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(121, 55);
            this.btn_agregar.TabIndex = 9;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(142, 372);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(124, 55);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.Location = new System.Drawing.Point(272, 372);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(123, 55);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // cbcamviarcontraseña
            // 
            this.cbcamviarcontraseña.AutoSize = true;
            this.cbcamviarcontraseña.Location = new System.Drawing.Point(159, 230);
            this.cbcamviarcontraseña.Name = "cbcamviarcontraseña";
            this.cbcamviarcontraseña.Size = new System.Drawing.Size(159, 21);
            this.cbcamviarcontraseña.TabIndex = 13;
            this.cbcamviarcontraseña.Text = "Cambiar Contraseña";
            this.cbcamviarcontraseña.UseVisualStyleBackColor = true;
            this.cbcamviarcontraseña.Visible = false;
            this.cbcamviarcontraseña.CheckedChanged += new System.EventHandler(this.cbcamviarcontraseña_CheckedChanged);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(359, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(92, 37);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 3;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // frm_rusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(141)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(451, 439);
            this.Controls.Add(this.cbcamviarcontraseña);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txtVNcontraseña);
            this.Controls.Add(this.lblVcontraseña);
            this.Controls.Add(this.txtNcontraseña);
            this.Controls.Add(this.lblNcontraseña);
            this.Controls.Add(this.cboxnivel);
            this.Controls.Add(this.txtVcontraseña);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_rusuarios";
            this.Text = "1";
            this.Load += new System.EventHandler(this.frm_rusuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtVcontraseña;
        private System.Windows.Forms.ComboBox cboxnivel;
        private System.Windows.Forms.TextBox txtNcontraseña;
        private System.Windows.Forms.Label lblNcontraseña;
        private System.Windows.Forms.Label lblVcontraseña;
        private System.Windows.Forms.TextBox txtVNcontraseña;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbcamviarcontraseña;
        private System.Windows.Forms.PictureBox btncerrar;
    }
}