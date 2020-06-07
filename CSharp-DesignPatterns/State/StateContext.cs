using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.State
{
    public class StateContext
    {
        private IState state;

        public StateContext(IState state)
        {
            TransitionToState(state);
        }

        public void TransitionToState(IState state) {
            this.state = state;
            this.state.SetContext(this);
        }

        public void DoWork()
        {
            state.DoWork();
        }

        public void ChangeState()
        {
            state.ChangeState();
        }
    }
}
