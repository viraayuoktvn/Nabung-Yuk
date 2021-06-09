using System;
using MySql.Data.MySqlClient;

namespace Nabung_Yuk
{
    class MoneyData
    {
        public static void RecordedMoney()
        {
            Console.WriteLine("\nSelamat datang!\n");
           
            ConnectDB conn = new ConnectDB();
            using(conn.connection)
            {
                try
                {
                    conn.connection.Open();
                   
                    MySqlCommand command = conn.connection.CreateCommand();
                    command.CommandText = System.Data.CommandType.Text.ToString();
                    command.CommandText = "Select * from moneydata";

                    MySqlDataReader reader = command.ExecuteReader();
 
                    var data = "[Month]\t[Income]\t\t[Outcome]";
 
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            data += reader.GetInt32(0) + "\t" + reader.GetDouble(1) + "\t\t" + reader.GetDouble(2) +
                            Environment.NewLine;
                        }
                    }
                    Console.WriteLine(data);
 
                    reader.Close();
                    conn.connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException e)
                {
                    Console.WriteLine("Error : " + e.Message.ToString());
                }
            }
        } 

        public void InputUpdate()
        {
            RecordedMoney();

            Income income = new Income();
            double pemasukkan = income.InputIncome();

            Console.WriteLine("Masukkan pengeluaranmu bulan ini!");
            DailyLife dailyl = new DailyLife();
            double DLnom = dailyl.nominalDL();

            SocialSpending socials = new SocialSpending();
            double SSnom = socials.nominalSS();

            LifeStyle lstyle = new LifeStyle();
            double LSnom = lstyle.nominalLS();

            double totalout = DLnom + SSnom + LSnom;
            Console.WriteLine("Total pengeluaranmu bulan ini : " + totalout);

            Console.WriteLine("Masukkan target pengeluaran yang kamu inginkan: ");
            double targetOutcome = Convert.ToDouble(Console.ReadLine());           

            double reachTarget = (targetOutcome/totalout) * 100;

            double mustBeSaved = totalout - targetOutcome;

            Console.WriteLine("Realisasi target pengeluaranmu bulan ini mencapai persentase " + reachTarget);
            Console.WriteLine("Kamu harus menghemat pengeluaran di bulan depan sebanyak " + mustBeSaved);

            Console.WriteLine("Semangat menabung!");
        }

    }
}
