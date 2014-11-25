using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class ColorBlackDecorator : AbstractAccessoriesDecorator
    {
        public ColorBlackDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Negro";
            return (s);
        }
    }
}