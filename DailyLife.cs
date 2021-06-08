using System;
using System.Collections.Generic;
using System.Text;

namespace Nabung_Yuk
{
    public class DailyLife : Outcome
    {
        public double nomDL { get; set; }  

        public double nominalDL
        {
            get
            {
                return nomDL;
            }
        }
    }
}
