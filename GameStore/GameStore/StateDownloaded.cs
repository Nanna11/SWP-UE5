using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class StateDownloaded : State
    {
        public StateDownloaded(string GameName) : base(GameName)
        {
        }

        public new IState Install()
        {
            Console.WriteLine(_GameName + "has been installed.");
            return new StateInstalled(_GameName);
        }

        public IState Download()
        {
            Console.WriteLine(_GameName + "cannot be downloaded - you already downloaded it.");
            return this;
        }

        public new IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "has been lent to " + lendTo.Name);
            return new StateLent(_GameName, lendTo, this);
        }

    }
}
