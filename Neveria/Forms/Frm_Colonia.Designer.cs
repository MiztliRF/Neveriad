namespace Neveria.Forms
{
    partial class Frm_Colonia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Colonia));
            this.label3 = new System.Windows.Forms.Label();
            this.txtidlocalidad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttneliminar = new System.Windows.Forms.Button();
            this.bttnactualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "ID_Localidad:";
            // 
            // txtidlocalidad
            // 
            this.txtidlocalidad.Location = new System.Drawing.Point(130, 127);
            this.txtidlocalidad.Name = "txtidlocalidad";
            this.txtidlocalidad.Size = new System.Drawing.Size(59, 22);
            this.txtidlocalidad.TabIndex = 32;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(130, 61);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 22);
            this.txtnombre.TabIndex = 28;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(130, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(59, 22);
            this.txtid.TabIndex = 27;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Colonia_ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre:";
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(130, 94);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(164, 22);
            this.txtcp.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Codigo Postal:";
            // 
            // bttneliminar
            // 
            this.bttneliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttneliminar.BackgroundImage")));
            this.bttneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttneliminar.Location = new System.Drawing.Point(340, 132);
            this.bttneliminar.Name = "bttneliminar";
            this.bttneliminar.Size = new System.Drawing.Size(147, 74);
            this.bttneliminar.TabIndex = 31;
            this.bttneliminar.UseVisualStyleBackColor = true;
            this.bttneliminar.Click += new System.EventHandler(this.bttneliminar_Click);
            // 
            // bttnactualizar
            // 
            this.bttnactualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnactualizar.BackgroundImage")));
            this.bttnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bttnactualizar.Location = new System.Drawing.Point(205, 132);
            this.bttnactualizar.Name = "bttnactualizar";
            this.bttnactualizar.Size = new System.Drawing.Size(129, 74);
            this.bttnactualizar.TabIndex = 30;
            this.bttnactualizar.UseVisualStyleBackColor = true;
            this.bttnactualizar.Click += new System.EventHandler(this.bttnactualizar_Click);
            // 
            // Frm_Colonia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 218);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidlocalidad);
            this.Controls.Add(this.bttneliminar);
            this.Controls.Add(this.bttnactualizar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Colonia";
            this.Text = "Colonia ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidlocalidad;
        private System.Windows.Forms.Button bttneliminar;
        private System.Windows.Forms.Button bttnactualizar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.Label label4;
    }
}