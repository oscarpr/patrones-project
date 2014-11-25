using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public abstract class AbstractAccessoriesDecorator : IAddAccessorie
    {
        protected IAddAccessorie AddAccessorie;

        public AbstractAccessoriesDecorator(IAddAccessorie accesorie)
        {
            AddAccessorie = accesorie;
        }

        public virtual string Add()
        {
            return null;
        }
    }
}