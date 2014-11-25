using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto
{
    public class Administrador : Usuario
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Administrador(string codigo, string nombre, string password)
            : base()
        {
            this.codigo = codigo;
        }        
    }
}
