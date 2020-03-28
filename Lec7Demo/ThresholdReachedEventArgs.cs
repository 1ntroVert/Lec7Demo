using System;
using System.Collections.Generic;
using System.Text;

namespace Lec7Demo
{
    class ThresholdReachedEventArgs
    {
        //пороговое значение счетчика
        public int Threshold { get; set; }
        // время достижения порогового значения
        public DateTime TimeReached { get; set; }
    }
}
