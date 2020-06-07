using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.State
{
    public class StateClosed : IState
    {
        private StateContext context;

        public void SetContext(StateContext context)
        {
            this.context = context;
        }
        public void ChangeState()
        {
            context.TransitionToState(new StateOpen());
        }

        public void DoWork()
        {
            Console.WriteLine("State=Closed. Can't do work");
        }
    }
}
