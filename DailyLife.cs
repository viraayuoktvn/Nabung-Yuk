using System;
using System.Collections.Generic;
using System.Text;

namespace Nabung_Yuk
{
    public class DailyLife : Outcome
    {        
        public double nominalDL()
        {
            Console.WriteLine("Masukkan pengeluaran kategori Daily Life : ");
            double nomDL = Convert.ToDouble(Console.ReadLine());

            return nomDL;
        }
    }
}
