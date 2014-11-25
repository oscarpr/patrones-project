using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto
{
    public class Automovil
    {
        private string name;
        private string marca;
        private List<Accesorios> listaAccesorios;
        private string codigo;
        private string precio;
        private string modelo;

        

        
        

        public Automovil(string name, string marca, string modelo, List<Accesorios> accesorios, string precio)
        {
            this.codigo = System.Guid.NewGuid().ToString();
            this.name = name;
            this.marca = marca;
            this.listaAccesorios = accesorios;
            this.precio = precio;
            this.modelo = modelo;
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
        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        #endregion

        public bool AgregarAccesorio(Accesorios accesorio){
            listaAccesorios.Add(accesorio);
            return true;
        }
    }
}
