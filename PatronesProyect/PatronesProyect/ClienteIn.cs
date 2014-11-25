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
        public static string _Mensaje;


        Archivo archivo = new Archivo();

        public ClienteIn()
        {
            InitializeComponent();
        }

        private void ClienteIn_Load(object sender, EventArgs e)
        {

            _Mensaje = "";

            comboAutos.DataSource = null;
            comboAutos.DataSource = archivo.getAutomoviles();
            comboAutos.DisplayMember = "name";
            comboAutos.ValueMember = "codigo";        

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            imgRines.Visible = false;
            imgTurbo.Visible = false;

            // Transparent background...  
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            imgRines.BackColor = Color.Transparent;
            imgTurbo.BackColor = Color.Transparent;

            // Change parent for overlay PictureBox...
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            pictureBox5.Parent = pictureBox1;
            imgRines.Parent = pictureBox1;
            imgTurbo.Parent = pictureBox1;


            // Change overlay PictureBox position in new parent...
            pictureBox2.Location = new Point(0, 0);
            pictureBox3.Location = new Point(0, 0);
            pictureBox4.Location = new Point(0, 0);
            pictureBox5.Location = new Point(0, 0);
            imgRines.Location = new Point(0, 0);
            imgTurbo.Location = new Point(0, 0);
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

            pictureBox1.Visible = true;
            MessageBox.Show(_Mensaje);

            int firstCharacter = -1;
            firstCharacter = _Mensaje.IndexOf("Nitro");

            if (_Mensaje.IndexOf("Nitro") != -1)
            {
                imgTurbo.Visible = true;
            } 
            if(_Mensaje.IndexOf("Rines de lujo") != -1)
            {
                imgRines.Visible = true;
            }
            if (_Mensaje.IndexOf("Rojo") != -1)
            {
                pictureBox4.Visible = true;
            }
            if (_Mensaje.IndexOf("Verde") != -1)
            {
                pictureBox3.Visible = true;
            }
            if (_Mensaje.IndexOf("Negro") != -1)
            {
                pictureBox5.Visible = true;
            }
            if (_Mensaje.IndexOf("Azul") != -1)
            {
                pictureBox2.Visible = true;
            }
            
        }

        private void AddAccesorios_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            imgRines.Visible = false;
            imgTurbo.Visible = false;


            frmAccesorios accesorios = new frmAccesorios();
            accesorios.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroCliente registro = new RegistroCliente();
            //registro.Show();
            registro.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
