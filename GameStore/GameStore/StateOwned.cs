using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class StateOwned : State
    {
        public StateOwned(string GameName) : base(GameName)
        {
        }

        public new IState Download()
        {
            Console.WriteLine(_GameName + "has been downloaded.");
            
        }

        public new IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "has been lent to " + lendTo.Name);
            
        }
    }
}
