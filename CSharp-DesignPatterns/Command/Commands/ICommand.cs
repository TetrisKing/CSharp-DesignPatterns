using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
