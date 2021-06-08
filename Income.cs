using System;

namespace Nabung_Yuk
{
    public class Income
    {        

        public double nominal { get; set; }      

        public double InputIncome()
        {
            Console.WriteLine("Masukkan pendapatanmu bulan ini : ");
            double nominal = Convert.ToDouble(Console.ReadLine());

            return nominal;
        }

    }
}