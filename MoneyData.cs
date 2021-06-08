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

                   var data = "[Month]\t[Income]\t\t[Outcome]\n";

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

           int activity = 0;
           while (activity != -1)
           {
               Console.WriteLine("Ingin memasukkan pengeluaran atau pemasukkan?");
               Console.WriteLine("1. Pemasukkan");
               Console.WriteLine("2. Pengeluaran");
               activity = Convert.ToInt16(Console.ReadLine());

               switch (activity)
               {
                   case 1:
                   Income income = new Income();
                   income.InputIncome();
                   break;

                   case 2:
                   TotalOutcome outcome = new TotalOutcome();
                   outcome.CalculateTotalOutcome();
                   break;

                   default:
                   Console.WriteLine("Pilihan tidak tersedia!");
                   break;
               }
           }
       }
    }
}