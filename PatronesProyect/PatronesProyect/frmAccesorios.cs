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
    public partial class frmAccesorios : Form
    {
        
        Decorator.IAddAccessorie MyAccessorie = new Decorator.AddAccessorieClient();

        public frmAccesorios()
        {
            InitializeComponent();
        }

        private void frmAccesorios_Load(object sender, EventArgs e)
        {
            
        }

        private void CBLAccesorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = MyAccessorie.Add();
            ClienteIn._Mensaje = message;
            //MessageBox.Show(message);
            MessageBox.Show("Cambios han sido guardados");
            Close();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CBLAccesorios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedIndex = CBLAccesorios.SelectedIndex;
            Object selectedItem = CBLAccesorios.SelectedItem;

            if (e.NewValue == CheckState.Checked)
            {
                switch (selectedIndex)
                {
                    case 0:
                        MyAccessorie = new Decorator.VidriosElectricosDecorator(MyAccessorie);
                        break;
                    case 1:
                        MyAccessorie = new Decorator.NitroDecorator(MyAccessorie);
                        break;
                    case 2:
                        MyAccessorie = new Decorator.RinesLujoDecorator(MyAccessorie);
                        break;
                    case 3:
                        MyAccessorie = new Decorator.VidriosPolariazdosDecorator(MyAccessorie);
                        break;
                    case 4:
                        MyAccessorie = new Decorator.AirbagDecorator(MyAccessorie);
                        break;
                }
            }
        }

        private void frmAccesorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        MyAccessorie = new Decorator.ColorRedDecorator(MyAccessorie);
                        break;
                    case 1:
                        MyAccessorie = new Decorator.ColorGreenDecorator(MyAccessorie);
                        break;
                    case 2:
                        MyAccessorie = new Decorator.ColorBlackDecorator(MyAccessorie);
                        break;
                    case 3:
                        MyAccessorie = new Decorator.ColorBlueDecorator(MyAccessorie);
                        break;
                }
        }
    }
}
