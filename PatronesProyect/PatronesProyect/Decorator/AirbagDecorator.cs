﻿using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class AirbagDecorator : AbstractAccessoriesDecorator
    {
        public AirbagDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Nitro";
            return (s);
        }
    }
}