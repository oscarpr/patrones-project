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
    public partial class ClienteIn : Form
    {
        Archivo archivo = new Archivo();

        public ClienteIn()
        {
            InitializeComponent();
        }

        private void ClienteIn_Load(object sender, EventArgs e)
        {
            comboAutos.DataSource = null;
            comboAutos.DataSource = archivo.getAutomoviles();
            comboAutos.DisplayMember = "name";
            comboAutos.ValueMember = "codigo";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            
            string codigoSelected = comboAutos.SelectedValue.ToString();
            foreach (Automovil a in archivo.getAutomoviles())
            {
                if (codigoSelected == a.Codigo)
                {
                    lblModelo.Text = a.Modelo;
                    lblMarca.Text = a.Marca;
                    lblCodigo.Text = a.Codigo;
                    lblPrecio.Text = a.Precio;
                }
            }
            
            
        }

        private void AddAccesorios_Click(object sender, EventArgs e)
        {

        }
    }
}
