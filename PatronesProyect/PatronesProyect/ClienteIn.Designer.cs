namespace PatronesProyecto
{
    partial class ClienteIn
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
            this.comboAutos = new System.Windows.Forms.ComboBox();
            this.archivoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PBAuto = new System.Windows.Forms.PictureBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboAutos
            // 
            this.comboAutos.DataSource = this.archivoBindingSource1;
            this.comboAutos.FormattingEnabled = true;
            this.comboAutos.Location = new System.Drawing.Point(13, 29);
            this.comboAutos.Name = "comboAutos";
            this.comboAutos.Size = new System.Drawing.Size(335, 21);
            this.comboAutos.TabIndex = 0;
            // 
            // archivoBindingSource1
            // 
            this.archivoBindingSource1.DataSource = typeof(PatronesProyecto.Archivo);
            // 
            // archivoBindingSource
            // 
            this.archivoBindingSource.DataSource = typeof(PatronesProyecto.Archivo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(65, 85);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(0, 13);
            this.lblModelo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(65, 111);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(0, 13);
            this.lblMarca.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(61, 155);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 6;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(61, 133);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblPrecio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio:";
            // 
            // PBAuto
            // 
            this.PBAuto.Location = new System.Drawing.Point(213, 85);
            this.PBAuto.Name = "PBAuto";
            this.PBAuto.Size = new System.Drawing.Size(135, 83);
            this.PBAuto.TabIndex = 9;
            this.PBAuto.TabStop = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(378, 150);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(378, 170);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "Ir al inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(378, 26);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 12;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // ClienteIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 221);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.PBAuto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAutos);
            this.Name = "ClienteIn";
            this.Text = "ClienteIn";
            this.Load += new System.EventHandler(this.ClienteIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PBAuto;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.BindingSource archivoBindingSource;
        private System.Windows.Forms.BindingSource archivoBindingSource1;
        private System.Windows.Forms.Button btnVer;

    }
}