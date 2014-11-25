using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class VidriosPolariazdosDecorator : AbstractAccessoriesDecorator
    {
        public VidriosPolariazdosDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Vidrios polarizados";
            return(s);
        }
    }
}