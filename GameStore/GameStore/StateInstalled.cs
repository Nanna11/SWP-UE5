using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class StateInstalled : State
    {
        public StateInstalled(string GameName) : base(GameName)
        {
        }

        public new IState Start()
        {
            Console.WriteLine("You played " + _GameName + ". That was fun.");
            return this;
        }

        public IState Download()
        {
            Console.WriteLine(_GameName + "cannot be downloaded - you already downloaded it.");
            return this;
        }

        public new IState Uninstall()
        {
            Console.WriteLine(_GameName + "has been unistalled.");
            return new StateDownloaded(_GameName);
        }


        public new IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "has been lent to " + lendTo.Name);
            return new StateLent(_GameName, lendTo, this);
        }
    }
}
