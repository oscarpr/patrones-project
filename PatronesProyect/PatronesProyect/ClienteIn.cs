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
    public partial class ClienteIn : Form
    {
        public ClienteIn()
        {
            InitializeComponent();
            Archivo archivo = new Archivo();
            comboAutos.DataSource = null;
            comboAutos.DataSource = archivo.getAutomoviles();
            comboAutos.DisplayMember = "name";
            comboAutos.ValueMember = "codigo";
        }

        
    }
}
