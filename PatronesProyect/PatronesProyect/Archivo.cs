using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyect
{
    public class Archivo
    {
        public List<Automovil> getAutomoviles()
        {
            Archivo archivo = new Archivo();

            List<Automovil> list = new List<Automovil>();
            

            Automovil mercedes1 = new Automovil("Mercedes", "Mercedes Benz", archivo.getAccesorios(), "90.000.000");
            Automovil Ferrari1 = new Automovil("Ferrari", "Ferrari", archivo.getAccesorios(), "100.000.000");
            Automovil Kia1 = new Automovil("Kia", "Kia", archivo.getAccesorios(), "50.000.000");
            return list;
        }

       
       
        

        public List<Accesorios> getAccesorios()
        {
            List<Accesorios> accesorios = new List<Accesorios>();

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
        
       
        
        

        List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        Administrador administrador = new Administrador("0001", "Admin", "Admin");

        public Administrador Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

    }
}
