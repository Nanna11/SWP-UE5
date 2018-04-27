using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    interface IState
    {
        IState Buy();
        IState Download();
        IState Install();
        IState Start();
        IState Lend(User lendTo);
        IState Return();
        IState Retrieve();
    }
}
