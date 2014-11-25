using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class ColorBlueDecorator : AbstractAccessoriesDecorator
    {
        public ColorBlueDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Azul";
            return (s);
        }
    }
}