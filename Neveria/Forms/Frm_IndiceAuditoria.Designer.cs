namespace Neveria.Forms
{
    partial class Frm_IndiceAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IndiceAuditoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RUsuario = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbcamviarcontraseña = new System.Windows.Forms.CheckBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txtVNcontraseña = new System.Windows.Forms.TextBox();
            this.lblVcontraseña = new System.Windows.Forms.Label();
            this.txtNcontraseña = new System.Windows.Forms.TextBox();
            this.lblNcontraseña = new System.Windows.Forms.Label();
            this.cboxnivel = new System.Windows.Forms.ComboBox();
            this.txtVcontraseña = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RUsuario);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1580, 853);
            this.tabControl1.TabIndex = 0;
            // 
            // RUsuario
            // 
            this.RUsuario.Controls.Add(this.cbcamviarcontraseña);
            this.RUsuario.Controls.Add(this.btn_cerrar);
            this.RUsuario.Controls.Add(this.btn_eliminar);
            this.RUsuario.Controls.Add(this.btn_agregar);
            this.RUsuario.Controls.Add(this.txtVNcontraseña);
            this.RUsuario.Controls.Add(this.lblVcontraseña);
            this.RUsuario.Controls.Add(this.txtNcontraseña);
            this.RUsuario.Controls.Add(this.lblNcontraseña);
            this.RUsuario.Controls.Add(this.cboxnivel);
            this.RUsuario.Controls.Add(this.txtVcontraseña);
            this.RUsuario.Controls.Add(this.txtcontraseña);
            this.RUsuario.Controls.Add(this.txtusuario);
            this.RUsuario.Controls.Add(this.label5);
            this.RUsuario.Controls.Add(this.label4);
            this.RUsuario.Controls.Add(this.label3);
            this.RUsuario.Controls.Add(this.label2);
            this.RUsuario.Location = new System.Drawing.Point(4, 25);
            this.RUsuario.Name = "RUsuario";
            this.RUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.RUsuario.Size = new System.Drawing.Size(1572, 824);
            this.RUsuario.TabIndex = 0;
            this.RUsuario.Text = "Registro de Usuarios";
            this.RUsuario.UseVisualStyleBackColor = true;
            this.RUsuario.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 71);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbcamviarcontraseña
            // 
            this.cbcamviarcontraseña.AutoSize = true;
            this.cbcamviarcontraseña.Location = new System.Drawing.Point(171, 183);
            this.cbcamviarcontraseña.Name = "cbcamviarcontraseña";
            this.cbcamviarcontraseña.Size = new System.Drawing.Size(159, 21);
            this.cbcamviarcontraseña.TabIndex = 29;
            this.cbcamviarcontraseña.Text = "Cambiar Contraseña";
            this.cbcamviarcontraseña.UseVisualStyleBackColor = true;
            this.cbcamviarcontraseña.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cerrar.Location = new System.Drawing.Point(284, 325);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(123, 55);
            this.btn_cerrar.TabIndex = 27;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(154, 325);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(124, 55);
            this.btn_eliminar.TabIndex = 25;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregar.BackgroundImage")));
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(27, 325);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(121, 55);
            this.btn_agregar.TabIndex = 24;
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txtVNcontraseña
            // 
            this.txtVNcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVNcontraseña.Location = new System.Drawing.Point(168, 262);
            this.txtVNcontraseña.Name = "txtVNcontraseña";
            this.txtVNcontraseña.PasswordChar = '*';
            this.txtVNcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtVNcontraseña.TabIndex = 23;
            this.txtVNcontraseña.Visible = false;
            // 
            // lblVcontraseña
            // 
            this.lblVcontraseña.AutoSize = true;
            this.lblVcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblVcontraseña.Location = new System.Drawing.Point(19, 267);
            this.lblVcontraseña.Name = "lblVcontraseña";
            this.lblVcontraseña.Size = new System.Drawing.Size(141, 17);
            this.lblVcontraseña.TabIndex = 28;
            this.lblVcontraseña.Text = "Verificar Contraseña:";
            this.lblVcontraseña.Visible = false;
            // 
            // txtNcontraseña
            // 
            this.txtNcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNcontraseña.Location = new System.Drawing.Point(168, 212);
            this.txtNcontraseña.Name = "txtNcontraseña";
            this.txtNcontraseña.PasswordChar = '*';
            this.txtNcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtNcontraseña.TabIndex = 22;
            this.txtNcontraseña.Visible = false;
            // 
            // lblNcontraseña
            // 
            this.lblNcontraseña.AutoSize = true;
            this.lblNcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNcontraseña.Location = new System.Drawing.Point(35, 217);
            this.lblNcontraseña.Name = "lblNcontraseña";
            this.lblNcontraseña.Size = new System.Drawing.Size(130, 17);
            this.lblNcontraseña.TabIndex = 26;
            this.lblNcontraseña.Text = "Nueva Contraseña:";
            this.lblNcontraseña.Visible = false;
            // 
            // cboxnivel
            // 
            this.cboxnivel.Enabled = false;
            this.cboxnivel.FormattingEnabled = true;
            this.cboxnivel.Items.AddRange(new object[] {
            "--Selecionar Nivel---",
            "Administrador",
            "Operador"});
            this.cboxnivel.Location = new System.Drawing.Point(171, 143);
            this.cboxnivel.Name = "cboxnivel";
            this.cboxnivel.Size = new System.Drawing.Size(170, 24);
            this.cboxnivel.TabIndex = 20;
            this.cboxnivel.Text = "--Selecionar Nivel---";
            // 
            // txtVcontraseña
            // 
            this.txtVcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVcontraseña.Enabled = false;
            this.txtVcontraseña.Location = new System.Drawing.Point(171, 105);
            this.txtVcontraseña.Name = "txtVcontraseña";
            this.txtVcontraseña.PasswordChar = '*';
            this.txtVcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtVcontraseña.TabIndex = 18;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontraseña.Enabled = false;
            this.txtcontraseña.Location = new System.Drawing.Point(171, 70);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(170, 22);
            this.txtcontraseña.TabIndex = 16;
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Location = new System.Drawing.Point(171, 26);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(115, 22);
            this.txtusuario.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(126, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(24, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Verificar Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(80, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(104, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Usuario:";
            // 
            // Frm_IndiceAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 804);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_IndiceAuditoria";
            this.Text = "Frm_IndiceAuditoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.RUsuario.ResumeLayout(false);
            this.RUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RUsuario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbcamviarcontraseña;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txtVNcontraseña;
        private System.Windows.Forms.Label lblVcontraseña;
        private System.Windows.Forms.TextBox txtNcontraseña;
        private System.Windows.Forms.Label lblNcontraseña;
        private System.Windows.Forms.ComboBox cboxnivel;
        private System.Windows.Forms.TextBox txtVcontraseña;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}