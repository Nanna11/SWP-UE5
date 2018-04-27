using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    abstract class State : IState
    {
        protected string _GameName;

        public State(string GameName)
        {
            _GameName = GameName;
        }

        public IState Buy()
        {
            Console.WriteLine(_GameName + "cannot be bought bought - you already own it");
            return this;
        }

        public IState Download()
        {
            Console.WriteLine(_GameName + "cannot be downloaded until you bought or lended it.");
            return this;
        }

        public IState Install()
        {
            Console.WriteLine(_GameName + "cannot be installed until you downloaded it.");
            return this;
        }

        public IState Lend(User lendTo)
        {
            Console.WriteLine(_GameName + "cannot be lended until you buy it.");
            return this;
        }

        public IState Retrieve()
        {
            Console.WriteLine(_GameName + "cannot be retrieved - you did not lend it to someone.");
            return this;
        }

        public IState Return()
        {
            Console.WriteLine(_GameName + "cannot be returned - you did not lend it from someone.");
            return this;
        }

        public IState Start()
        {
            Console.WriteLine(_GameName + "cannot be started until you installed it.");
            return this;
        }

        public IState Uninstall()
        {
            Console.WriteLine(_GameName + "cannot be uninstalled - you need to install it first.");
            return this;
        }
    }
}
