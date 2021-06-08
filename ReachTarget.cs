using System;
using System.Collections.Generic;

namespace Nabung_Yuk
{
    public class ReachTarget
    {
        public double getReachTarget()
        {
            TotalOutcome outcome = new TotalOutcome();
            double totalOutcome = outcome.CalculateTotalOutcome();

            InpTarget target_input = new InpTarget();
            double targetOutcome = target_input.inputTarget();

            double reachTarget = (totalOutcome/targetOutcome) * 100;

            return reachTarget;
        }
    }
}
