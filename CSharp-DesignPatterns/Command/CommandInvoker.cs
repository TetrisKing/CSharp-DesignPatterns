using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp_DesignPatterns.Command
{
    //Executes and tracks commands
    public class CommandInvoker
    {
        //Execute Commands, Track Command history allowing undo
        private Stack<ICommand> commands = new Stack<ICommand>();

        public void Invoke(ICommand command) {
            if (command.CanExecute()) {
                commands.Push(command);
                command.Execute();
            }
        }

        public void UndoLast() {
            if (commands.Count > 0)
            {
                var command = commands.Pop();
                command.Undo();
            }
        }

        public void UndoAll() {
            while (commands.Count > 0) {
                UndoLast();
            }
        }
    }
}
