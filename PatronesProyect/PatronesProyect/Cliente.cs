using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyect
{
    public class Cliente : Usuario
    {
        private string nombreUsuario;
        private string eMail;


        public Cliente(string nombre, string password, string nombreUsuario, string eMail)
            : base()
        {
            this.NombreUsuario = nombreUsuario;
            this.eMail = eMail;
        }
        
        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public bool Comprar(Automovil auto)
        {
            return true;
        }

    }
}
