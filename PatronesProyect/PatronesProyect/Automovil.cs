using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyect
{
    public class Automovil
    {
        private string name;
        private string marca;
        private List<Accesorios> listaAccesorios;
        private string codigo;
        private string precio;
        

        public Automovil(string name, string marca, List<Accesorios> accesorios, string precio)
        {
            this.codigo = System.Guid.NewGuid().ToString();
            this.name = name;
            this.marca = marca;
            this.listaAccesorios = accesorios;
            this.precio = precio;
        }

        #region "Propiedades"
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public List<Accesorios> ListaAccesorios
        {
            get { return listaAccesorios; }
            set { listaAccesorios = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        #endregion

        public bool AgregarAccesorio(Accesorios accesorio){
            listaAccesorios.Add(accesorio);
            return true;
        }
    }
}
