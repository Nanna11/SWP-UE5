using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    class Game
    {
        IState _State;

        IState State
        {
            get
            {
                return _State;
            }

            set
            {
                _State = value;
            }
        }
    }
}
