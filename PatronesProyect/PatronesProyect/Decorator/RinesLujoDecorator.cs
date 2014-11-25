using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class RinesLujoDecorator : AbstractAccessoriesDecorator
    {
        public RinesLujoDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Rines de lujo";
            return(s);
        }
    }
}