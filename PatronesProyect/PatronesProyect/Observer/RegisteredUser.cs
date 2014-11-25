using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesProyecto.Observer
{
    public class RegisteredUser : IObserver
    {
        string mail;

        public RegisteredUser(string mymail)
        {
            mail = mymail;
        }
        public string Update(string eventInfo)
        {
            string DocumentoNotificacion = "Hola " + mail;
            DocumentoNotificacion += System.Environment.NewLine;
            DocumentoNotificacion += eventInfo;

            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.File.WriteAllText(@mydocpath + "\\" + mail + ".txt", DocumentoNotificacion);

            return ("El usuario" + mail + "ha sido notificado del " + eventInfo);
        }
    }
}