using System;
using System.Collections.Generic;

namespace Nabung_Yuk
{
    public class InpTarget
    {
        public double inputTarget()
        {
            Console.WriteLine("Masukkan target pengeluaran yang Anda inginkan: ");
            double targetOutcome = Convert.ToDouble(Console.ReadLine());

            return targetOutcome;
        }
    }
}
