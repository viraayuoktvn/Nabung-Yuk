﻿using System;
using MySql.Data.MySqlClient;

namespace Nabung_Yuk
{
    class LogIn
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void loginUser()
        {
            ConnectDB conn = new ConnectDB();
            using (conn.connection)
            {
                conn.connection.Open();
                Console.WriteLine("Enter username: ");
                Username = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                Password = Console.ReadLine();

                MySqlCommand cmd = conn.connection.CreateCommand();
                cmd.CommandText = System.Data.CommandType.Text.ToString();
                cmd.CommandText = "Select * from login where username = '"+Username+"' and password = '"+Password+"'";

                MySqlDataReader check = cmd.ExecuteReader();
                
                if(check.HasRows)
                {
                    Console.WriteLine("Login success!");
                    conn.connection.Close();
                    MoneyData recMoney = new MoneyData();
                    recMoney.InputUpdate();
                }
                else
                {
                    Console.WriteLine("Login failed! Try again.");
                    conn.connection.Close();
                    LogIn newlogin = new LogIn();
                    newlogin.loginUser();
                }
            }
        }
    }
}