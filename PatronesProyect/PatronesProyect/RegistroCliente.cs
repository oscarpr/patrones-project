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
    public partial class RegistroCliente : Form
    {

        public static Observer.Database databaseUsuarios = new Observer.Database();


        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblREmail.Text == "")
            {
                MessageBox.Show("Debes ingresar un email");
            }
            else
            {
                Observer.IObserver clienteNuevo = new Observer.RegisteredUser(lblREmail.Text);
                databaseUsuarios.RegisterObserver(clienteNuevo);

                //Notifiacion a un usuario especifico
                clienteNuevo.Update("Te hemos agregado a nuestra lista de notifiación para que estes enterado de las ultimas actualizaciones de nuestros vehiculos");
            }          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            if (LblRPass.Text == LblRPass2.Text)
            {
                foreach (Cliente c in archivo.Clientes)
                {
                    if (lblRNombreUsuario.Text == c.NombreUsuario)
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
        }*/
    }
}
