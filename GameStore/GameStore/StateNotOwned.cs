using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class StateNotOwned : State
    {
        public StateNotOwned(string GameName) : base(GameName)
        {
        }

        public new IState Buy()
        {
            Console.WriteLine(_GameName + "has been bought.");
            return new StateOwned(_GameName);
        }
    }
}
