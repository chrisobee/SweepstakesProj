using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstakes> queue;
        public Queue<Sweepstakes> Queue
        {
            get
            {
                return queue;
            }
        }
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            if(!queue.TryDequeue(out Sweepstakes result))
            {
                throw new InvalidOperationException("The queue is empty");
            }
            else
            {
                return result;
            }
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
    }
}
