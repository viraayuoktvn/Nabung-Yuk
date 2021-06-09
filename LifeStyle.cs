using System;
using System.Collections.Generic;

namespace Nabung_Yuk
{
    public class LifeStyle : Outcome
    {
        private double nomLS;

        public double nominalLS()
        {
            Console.WriteLine("Masukkan pengeluaran kategori Life Style : ");
            double nomLS = Convert.ToDouble(Console.ReadLine());

            return nomLS;
        }
    }
}
