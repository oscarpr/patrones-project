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
    public partial class frmAddAccesorios : Form
    {
        public frmAddAccesorios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroCliente.databaseUsuarios.NotifyObservers("Hemos añadido un nuevo vehiculo: " + txtNombreAuto.Text + " " + txtMarcaAuto.Text);                      
        }

        private void frmAddAccesorios_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
