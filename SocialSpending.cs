using System;
using System.Collections.Generic;

namespace Nabung_Yuk
{
    public class SocialSpending : Outcome
    {
        public double nominalSS()
        {
            Console.WriteLine("Masukkan pengeluaran kategori Social Spending : ");
            double nomSS = Convert.ToDouble(Console.ReadLine());

            return nomSS;
        }
    }
}
