namespace PatronesProyecto
{
    partial class frmAccesorios
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CBLAccesorios = new System.Windows.Forms.CheckedListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Accesorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(117, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CBLAccesorios
            // 
            this.CBLAccesorios.FormattingEnabled = true;
            this.CBLAccesorios.Items.AddRange(new object[] {
            "Vidrios Electricos",
            "Nitro",
            "Rines de Lujo",
            "Vidrios Polarizados",
            "Airbag"});
            this.CBLAccesorios.Location = new System.Drawing.Point(12, 61);
            this.CBLAccesorios.Name = "CBLAccesorios";
            this.CBLAccesorios.Size = new System.Drawing.Size(204, 79);
            this.CBLAccesorios.TabIndex = 13;
            this.CBLAccesorios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CBLAccesorios_ItemCheck);
            this.CBLAccesorios.SelectedIndexChanged += new System.EventHandler(this.CBLAccesorios_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 146);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Black",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(15, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Color";
            // 
            // frmAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 174);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.CBLAccesorios);
            this.Name = "frmAccesorios";
            this.Text = "frmAccesorios";
            this.Load += new System.EventHandler(this.frmAccesorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckedListBox CBLAccesorios;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}