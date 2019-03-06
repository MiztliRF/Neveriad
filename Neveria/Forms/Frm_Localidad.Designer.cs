namespace Neveria.Forms
{
    partial class Frm_Localidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Localidad));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidmunicipio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bttneliminar = new System.Windows.Forms.Button();
            this.bttnactualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(133, 74);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 22);
            this.txtnombre.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(133, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(59, 22);
            this.txtid.TabIndex = 9;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Localidad_ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // txtidmunicipio
            // 
            this.txtidmunicipio.Location = new System.Drawing.Point(133, 113);
            this.txtidmunicipio.Name = "txtidmunicipio";
            this.txtidmunicipio.Size = new System.Drawing.Size(59, 22);
            this.txtidmunicipio.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID_Municipio:";
            // 
            // bttneliminar
            // 
            this.bttneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttneliminar.BackgroundImage")));
            this.bttneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttneliminar.Location = new System.Drawing.Point(376, 126);
            this.bttneliminar.Name = "bttneliminar";
            this.bttneliminar.Size = new System.Drawing.Size(126, 59);
            this.bttneliminar.TabIndex = 13;
            this.bttneliminar.UseVisualStyleBackColor = true;
            this.bttneliminar.Click += new System.EventHandler(this.bttneliminar_Click);
            // 
            // bttnactualizar
            // 
            this.bttnactualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnactualizar.BackgroundImage")));
            this.bttnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnactualizar.Location = new System.Drawing.Point(257, 126);
            this.bttnactualizar.Name = "bttnactualizar";
            this.bttnactualizar.Size = new System.Drawing.Size(113, 59);
            this.bttnactualizar.TabIndex = 12;
            this.bttnactualizar.UseVisualStyleBackColor = true;
            this.bttnactualizar.Click += new System.EventHandler(this.bttnactualizar_Click);
            // 
            // Frm_Localidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 200);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidmunicipio);
            this.Controls.Add(this.bttneliminar);
            this.Controls.Add(this.bttnactualizar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Localidad";
            this.Text = "Localidad";
            this.Load += new System.EventHandler(this.Frm_Localidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttneliminar;
        private System.Windows.Forms.Button bttnactualizar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidmunicipio;
        private System.Windows.Forms.Label label3;
    }
}