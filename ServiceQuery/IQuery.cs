using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceQuery
{
    public interface IQuery
    {
        void RegisterObs(IMainObserver o);
        void UnRegisterObs(IMainObserver o);
        void NotifyObs();
    }
}
