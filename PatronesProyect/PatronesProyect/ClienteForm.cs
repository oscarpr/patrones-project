using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatronesProyect
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            Archivo archivo = new Archivo();
            foreach (Cliente c in archivo.Clientes)
            {
                if (c.NombreUsuario.Equals(txtNomUsuario))
                {
                    if (c.Password.Equals(txtPasswordClient))
                    {

                    }
                    else
                    {
                        lblErrorClient.Text = "Error en la contraseña";
                    }
                }
                else
                {
                    lblErrorClient.Text = "No se encontro el usuario";
                }
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RegistroCliente registro = new RegistroCliente();
            registro.Show();
        }
    }
}
