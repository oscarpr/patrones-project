namespace PatronesProyect
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIAdministrador = new System.Windows.Forms.Button();
            this.btnICliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 224);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIAdministrador
            // 
            this.btnIAdministrador.Location = new System.Drawing.Point(304, 74);
            this.btnIAdministrador.Name = "btnIAdministrador";
            this.btnIAdministrador.Size = new System.Drawing.Size(111, 43);
            this.btnIAdministrador.TabIndex = 1;
            this.btnIAdministrador.Text = "Ingresar como administrador";
            this.btnIAdministrador.UseVisualStyleBackColor = true;
            this.btnIAdministrador.Click += new System.EventHandler(this.btnIAdministrador_Click);
            // 
            // btnICliente
            // 
            this.btnICliente.Location = new System.Drawing.Point(304, 123);
            this.btnICliente.Name = "btnICliente";
            this.btnICliente.Size = new System.Drawing.Size(111, 38);
            this.btnICliente.TabIndex = 2;
            this.btnICliente.Text = "Ingresar como cliente";
            this.btnICliente.UseVisualStyleBackColor = true;
            this.btnICliente.Click += new System.EventHandler(this.btnICliente_Click);
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 260);
            this.Controls.Add(this.btnICliente);
            this.Controls.Add(this.btnIAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Venta";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIAdministrador;
        private System.Windows.Forms.Button btnICliente;
    }
}

