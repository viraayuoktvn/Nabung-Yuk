using System;
using System.Collections.Generic;

namespace Nabung_Yuk
{
    public class Income
    {        
        public double InputIncome()
        {
            Console.WriteLine("Masukkan pendapatanmu bulan ini : ");
            double nominal = Convert.ToDouble(Console.ReadLine());

            return nominal;
        }
    }
}
