using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class ColorRedDecorator : AbstractAccessoriesDecorator
    {
        public ColorRedDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Rojo";
            return (s);
        }
    }
}