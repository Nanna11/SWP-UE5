using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class StateLent : State
    {
        User currentUser;
        IState before;
        public StateLent(string GameName, User lendTo, State Before) : base(GameName)
        {
            currentUser = lendTo;
            before = Before;
        }

        public IState Buy()
        {
            Console.WriteLine(_GameName + "cannot be bought bought - you already own it");
            return this;
        }

        public IState Download()
        {
            before = before.Download();
            return this;
        }

        public IState Install()
        {
            before = before.Install();
            return this;
        }

        public IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "cannot be lended - you already lent it to " + currentUser.Name);
            return this;
        }

        public IState Retrieve()
        {
            Console.WriteLine(_GameName + "has been retrieved.");
            return before;
        }

        public IState Start()
        {
            Console.WriteLine(_GameName + "cannot be started - you lent it to " + currentUser.Name);
            return this;
        }

        public IState Uninstall()
        {
            before = before.Unistall();
            return this;
        }
    }
}
