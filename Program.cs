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

        public void FinalResult()
        {
            MoneyData datauang = new MoneyData();
            datauang.InputUpdate();
        }
    }
}
