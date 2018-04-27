﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore
{
    public class Game
    {
        public Game() { }

        IState State { get; set; }

        public void Buy()
        {
            State = State.Buy();
        }

        public void Download()
        {
            State = State.Download();
        }

        public void Install()
        {
            State = State.Install();
        }

        public void Start()
        {
            State = State.Start();
        }

        public void Lend(User lendTo)
        {
            State = State.Lend(lendTo);
        }

        public void Retrieve()
        {
            State = State.Retrieve();
        }

        public void Return()
        {
            State = State.Return();
        }
    }
}
