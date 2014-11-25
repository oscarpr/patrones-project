using System.Linq;
using System.Text;

namespace PatronesProyecto.Decorator
{
    public class VidriosElectricosDecorator : AbstractAccessoriesDecorator
    {
        public VidriosElectricosDecorator(IAddAccessorie accesories) : base(accesories)
        {
        }

        public override string Add()
        {
            string s = this.AddAccessorie.Add() + " Vidrios electricos";
            return (s);
        }
    }
}