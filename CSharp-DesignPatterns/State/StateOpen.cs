using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.State
{
    public class StateOpen : IState
    {
        private StateContext context;

        public void SetContext(StateContext context)
        {
            this.context = context;
        }

        public void ChangeState()
        {
           context.TransitionToState(new StateClosed());
        }

        public void DoWork()
        {
            Console.WriteLine("State=Open. Working!");
        }

    }
}
