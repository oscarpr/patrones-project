﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatronesProyecto
{
    public partial class AdministradorForm : Form
    {
        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            if (archivo.Administrador.Codigo.Equals(txtUsuarioLogin.Text))
            {
                if (txtContrasennalogin.Text == "Admin")
                {
                    frmAddAccesorios admin = new frmAddAccesorios();
                    admin.Show();
                    this.Close();
                }
                else
                {
                    lblError.Text = "Contraseña incorrecta";
                }
            }
            else
            {
                lblError.Text = "El usuario no existe";
            }
        }

        private void AdministradorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
