using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class NitroDecorator : AbstractAccessoriesDecorator
    {
        public NitroDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Nitro";
            return (s);
        }
    }
}