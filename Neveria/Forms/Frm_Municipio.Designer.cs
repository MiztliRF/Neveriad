namespace Neveria.Forms
{
    partial class Frm_Municipio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Municipio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.bttneliminar = new System.Windows.Forms.Button();
            this.bttnactualizar = new System.Windows.Forms.Button();
            this.bttnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Municipio_ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(184, 18);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(59, 22);
            this.txtid.TabIndex = 2;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(184, 68);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 22);
            this.txtnombre.TabIndex = 3;
            // 
            // bttneliminar
            // 
            this.bttneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttneliminar.BackgroundImage")));
            this.bttneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttneliminar.Location = new System.Drawing.Point(427, 120);
            this.bttneliminar.Name = "bttneliminar";
            this.bttneliminar.Size = new System.Drawing.Size(126, 59);
            this.bttneliminar.TabIndex = 6;
            this.bttneliminar.UseVisualStyleBackColor = true;
            this.bttneliminar.Click += new System.EventHandler(this.bttneliminar_Click);
            // 
            // bttnactualizar
            // 
            this.bttnactualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnactualizar.BackgroundImage")));
            this.bttnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnactualizar.Location = new System.Drawing.Point(308, 120);
            this.bttnactualizar.Name = "bttnactualizar";
            this.bttnactualizar.Size = new System.Drawing.Size(113, 59);
            this.bttnactualizar.TabIndex = 5;
            this.bttnactualizar.UseVisualStyleBackColor = true;
            this.bttnactualizar.Click += new System.EventHandler(this.bttnactualizar_Click);
            // 
            // bttnbuscar
            // 
            this.bttnbuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnbuscar.BackgroundImage")));
            this.bttnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnbuscar.Location = new System.Drawing.Point(259, 12);
            this.bttnbuscar.Name = "bttnbuscar";
            this.bttnbuscar.Size = new System.Drawing.Size(99, 30);
            this.bttnbuscar.TabIndex = 4;
            this.bttnbuscar.UseVisualStyleBackColor = true;
            this.bttnbuscar.Click += new System.EventHandler(this.bttnbuscar_Click);
            // 
            // Frm_Municipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 191);
            this.Controls.Add(this.bttneliminar);
            this.Controls.Add(this.bttnactualizar);
            this.Controls.Add(this.bttnbuscar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Municipio";
            this.Text = "Frm_Municipio";
            this.Load += new System.EventHandler(this.Frm_Municipio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button bttnbuscar;
        private System.Windows.Forms.Button bttnactualizar;
        private System.Windows.Forms.Button bttneliminar;
    }
}