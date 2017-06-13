using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;


namespace ServiceQuery
{
    abstract public class Query : IQuery
    {
        protected List<IMainObserver> observers = new List<IMainObserver>();
        protected static int timeoutMilliseconds = 4000;

        public void RegisterObs(IMainObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegisterObs(IMainObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyObs()
        {
            foreach (IMainObserver ob in observers)
            {
                ob.UpdateElement();
            }
        }

        /**
        * Genera una conexion remota a un servidor
        * para poder utlizar ManagementObject
        * */
       public ManagementScope ConectToServer(string serverName)
        {
            ConnectionOptions conectionsOptions = new ConnectionOptions();
            //se determina la ruta a administrar
            ManagementScope scope = new ManagementScope(@"\\" + serverName + @"\root\cimv2");
            scope.Options =  conectionsOptions;
            return scope;
        }
    }
}
