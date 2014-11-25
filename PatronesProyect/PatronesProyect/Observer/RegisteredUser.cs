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
            string DocumentoNotificacion = eventInfo;
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.File.WriteAllText(@mydocpath + "\\" + name + ".txt", DocumentoNotificacion);

            return ("El usuario" + name + "ha sido notificado del " + eventInfo);
        }
    }
}