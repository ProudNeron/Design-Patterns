using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.DesignPatterns.Behavioural.Command.GoodExample
{
    // "Invoker": the remote control
    public class RemoteControl
    {
        private ICommand _command;

        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButtom()
        {
            _command.Execute();
        }
    }
}