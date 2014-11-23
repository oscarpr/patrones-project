using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyect
{
    public class Accesorios
    {
        private string codigo;
        private string nombre;        

        public Accesorios(string nombre)
        {
            this.codigo = System.Guid.NewGuid().ToString();
            this.nombre = nombre;
        }

        #region"Propiedades"
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion
    }
}
