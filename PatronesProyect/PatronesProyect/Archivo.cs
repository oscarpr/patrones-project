using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto
{
    public class Archivo
    {
        public Archivo () { }
        private List<Automovil> list = new List<Automovil>();
        private List<Accesorios> accesorios = new List<Accesorios>();
        private Administrador administrador = new Administrador("0001", "Admin", "Admin");
        private List<Cliente> clientes = new List<Cliente>();

      

        public List<Automovil> getAutomoviles()
        {
            Archivo archivo = new Archivo();            
            Automovil mercedes1 = new Automovil("Mercedes A", "Mercedes Benz","2010", archivo.getAccesorios(), "90.000.000");
            Automovil Ferrari1 = new Automovil("Ferrari Z20", "Ferrari", "2012", archivo.getAccesorios(), "100.000.000");
            Automovil Kia1 = new Automovil("Kia W32", "Kia", "2015", archivo.getAccesorios(), "50.000.000");
            list.Add(mercedes1);
            list.Add(Ferrari1);
            list.Add(Kia1);
            return list;
        }
        
        public List<Accesorios> getAccesorios()
        {
            Accesorios vidriosElectricos = new Accesorios("Vidrios Electricos");
            Accesorios nitro = new Accesorios("Nitro");
            Accesorios vidriosPolarizados = new Accesorios("vidriosPolarizados");
            Accesorios retrovisoresElectricos = new Accesorios("retrovisoresElectricos");
            Accesorios airbag = new Accesorios("airbag");

            accesorios.Add(vidriosElectricos);
            accesorios.Add(nitro);
            accesorios.Add(vidriosPolarizados);
            accesorios.Add(retrovisoresElectricos);
            accesorios.Add(airbag);

            return accesorios;
        }               
        
        public Administrador Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

    }
}
