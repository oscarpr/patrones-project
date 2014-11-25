using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto
{
    public abstract class Usuario
    {
        private string nombre;
        private string password;      

        
        #region "Propiedades"
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
#endregion

    }
}
