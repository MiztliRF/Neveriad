namespace Neveria.Forms
{
    partial class frmrespaldo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmrespaldo));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btngenerar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(539, 100);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 177);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(574, 49);
            this.progressBar1.TabIndex = 2;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(262, 291);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(151, 23);
            this.btngenerar.TabIndex = 1;
            this.btngenerar.Text = "Generar Respaldo";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmrespaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmrespaldo";
            this.Text = "Respaldo";
            this.Load += new System.EventHandler(this.frmrespaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}