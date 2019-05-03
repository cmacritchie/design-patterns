﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandApp
{
    class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
