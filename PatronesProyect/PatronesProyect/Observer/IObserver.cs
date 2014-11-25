using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesProyecto.Observer
{
    public interface IObserver
    {
        string Update(string eventInfo);
    }
}