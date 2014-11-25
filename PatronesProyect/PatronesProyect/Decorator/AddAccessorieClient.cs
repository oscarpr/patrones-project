using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class AddAccessorieClient : IAddAccessorie
    {

        public string Add()
        {
            return("Soy un carro");
        }
    }
}