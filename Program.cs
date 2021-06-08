using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Nabung_Yuk
{
    class Program
    { 
        public static void Main(string[] args)
        {
            LogIn login = new LogIn();
            login.loginUser();
        }

        public static double inputTarget()
        {
            Console.WriteLine("Masukkan target pengeluaran yang Anda inginkan: ");
            double targetOutcome = Convert.ToDouble(Console.ReadLine());

            return targetOutcome;
        }

        private static double getReachTarget()
        {
            TotalOutcome outcome = new TotalOutcome();
            double totalOutcome = outcome.CalculateTotalOutcome();
            double targetOutcome = inputTarget();

            double reachTarget = (totalOutcome/targetOutcome) * 100;

            return reachTarget;
        }

        public static void mustBeSaved()
        {
            TotalOutcome outcome = new TotalOutcome();
            double totalOutcome = outcome.CalculateTotalOutcome();
            double targetOutcome = inputTarget();
            double reachTarget = getReachTarget();

            double mustBeSaved = totalOutcome - targetOutcome;

            Console.WriteLine("Realisasi target pengeluaranmu bulan ini mencapai persentase " + reachTarget);
            Console.WriteLine("Kamu harus menghemat pengeluaran di bulan depan sebanyak " + mustBeSaved);

            Console.WriteLine("Semangat menabung!");
        }
    }
}