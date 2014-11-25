using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesProyecto.Observer
{
    public class TransactionLog : IObserver
    {
        public string Update(string eventInfo)
        {
            return ("El log ha sido actualizado con una operación " + eventInfo);
        }
    }
}
