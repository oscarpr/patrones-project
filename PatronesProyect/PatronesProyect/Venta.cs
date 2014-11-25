using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PatronesProyecto
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void btnIAdministrador_Click(object sender, EventArgs e)
        {
            AdministradorForm admForm = new AdministradorForm();
            admForm.Show();
        }

        private void btnICliente_Click(object sender, EventArgs e)
        {
            ClienteIn client = new ClienteIn();
            client.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
