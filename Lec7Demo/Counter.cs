using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7Demo
{
    class Counter
    {
        private const int THRESHOLD = 10;
        private int total;

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

        public void Add(int value)
        {
            total += value;
            if (total >= THRESHOLD)
            {
                //
                var args = new ThresholdReachedEventArgs();
                args.Threshold = THRESHOLD;
                args.TimeReached = DateTime.Now;

                ThresholdReached?.Invoke(this, args);
            }
        }
    }
}
