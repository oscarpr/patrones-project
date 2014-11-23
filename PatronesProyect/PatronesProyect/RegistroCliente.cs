﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatronesProyect
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            if (LblRPass.Text == LblRPass2.Text)
            {
                foreach (Cliente c in archivo.Clientes)
                {
                    if (c.NombreUsuario == lblRNombreUsuario.Text)
                    {
                        lblRError.Text = "Nombre de usuario ya existe cambielo";
                        lblRNombreUsuario.Text = "";
                    }
                    else
                    {
                        archivo.Clientes.Add(new Cliente(
                        lblRNombre.Text,
                        LblRPass.Text,
                        lblRNombreUsuario.Text,
                        lblREmail.Text
                    ));
                        lblRError.Text = " a";
                        this.Close();
                    }
                }
            }
            else
            {
                lblRError.Text = "Contraseñas no coinciden";
            }
        }
    }
}
