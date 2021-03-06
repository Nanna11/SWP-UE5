﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Commands
{
    class StartCommand : Command
    {
        public StartCommand(Game game) : base(game) { }

        public override void Execute()
        {
            _game.Start();
        }
    }
}
