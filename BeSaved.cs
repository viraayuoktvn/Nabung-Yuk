using System;
using System.Collections.Generic;

namespace Nabung_Yuk
{
    public class BeSaved
    {
        public void mustBeSaved()
        {
            TotalOutcome outcome = new TotalOutcome();
            double totalOutcome = outcome.CalculateTotalOutcome();

            InpTarget target_input = new InpTarget();
            double targetOutcome = target_input.inputTarget();

            ReachTarget target_reach = new ReachTarget();
            double reachTarget = target_reach.getReachTarget();

            double mustBeSaved = totalOutcome - targetOutcome;

            Console.WriteLine("Realisasi target pengeluaranmu bulan ini mencapai persentase " + reachTarget);
            Console.WriteLine("Kamu harus menghemat pengeluaran di bulan depan sebanyak " + mustBeSaved);

            Console.WriteLine("Semangat menabung!");
        }
    }
}
