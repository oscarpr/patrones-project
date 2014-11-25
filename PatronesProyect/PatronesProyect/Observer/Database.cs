using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesProyecto.Observer
{
    public class Database : ISubject
    {
        private List<IObserver> Observers;

        public Database()
        {
            Observers = new List<IObserver>();
        }


        public void NotifyObservers(string eventInfo)
        {
            Observers.ForEach(o => o.Update(eventInfo));
        }
        public string UpdateRecord()
        {
            NotifyObservers("update");
            return ("El registro ha sido actualizado");
        }
        public string DeleteRecord()
        {
            NotifyObservers("delete");
            return ("El registro ha sido borrado");
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}