using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        private Stack<Sweepstakes> stack;
        public Stack<Sweepstakes> Stack
        {
            get
            {
                return stack;
            }
        }
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            if (!stack.TryPop(out Sweepstakes result))
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                return result;
            }
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
