using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesProyecto.Observer
{
    public class RegisteredUser : IObserver
    {
        string name;

        public RegisteredUser(string myname)
        {
            name = myname;
        }
        public string Update(string eventInfo)
        {
            return ("El usuario" + name + "ha sido notificado del " + eventInfo);
        }
    }
}