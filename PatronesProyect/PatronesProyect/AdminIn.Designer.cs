namespace PatronesProyect
{
    partial class AdminIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIn));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreAuto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarcaAuto = new System.Windows.Forms.TextBox();
            this.CBLAccesorios = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreAuto
            // 
            this.txtNombreAuto.Location = new System.Drawing.Point(19, 43);
            this.txtNombreAuto.Name = "txtNombreAuto";
            this.txtNombreAuto.Size = new System.Drawing.Size(151, 20);
            this.txtNombreAuto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtMarcaAuto
            // 
            this.txtMarcaAuto.Location = new System.Drawing.Point(19, 96);
            this.txtMarcaAuto.Name = "txtMarcaAuto";
            this.txtMarcaAuto.Size = new System.Drawing.Size(148, 20);
            this.txtMarcaAuto.TabIndex = 3;
            // 
            // CBLAccesorios
            // 
            this.CBLAccesorios.FormattingEnabled = true;
            this.CBLAccesorios.Items.AddRange(new object[] {
            "Vidrios Electricos",
            "Nitro",
            "Retrovisores Polarizados",
            "Vidrios Electricos",
            "Airbag"});
            this.CBLAccesorios.Location = new System.Drawing.Point(19, 158);
            this.CBLAccesorios.Name = "CBLAccesorios";
            this.CBLAccesorios.Size = new System.Drawing.Size(148, 79);
            this.CBLAccesorios.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ir al inicio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Accesorios";
            // 
            // AdminIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CBLAccesorios);
            this.Controls.Add(this.txtMarcaAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreAuto);
            this.Controls.Add(this.label1);
            this.Name = "AdminIn";
            this.Text = "AdminIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarcaAuto;
        private System.Windows.Forms.CheckedListBox CBLAccesorios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}