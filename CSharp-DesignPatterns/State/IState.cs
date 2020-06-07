using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_DesignPatterns.State
{
    public interface IState
    {
        public void SetContext(StateContext context);
        public void DoWork();
        public void ChangeState();
    }
}
