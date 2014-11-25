using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class ColorGreenDecorator : AbstractAccessoriesDecorator
    {
        public ColorGreenDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Verde";
            return (s);
        }
    }
}