using System;
using System.Collections.Generic;

namespace Nabung_Yuk
{
    public class TotalOutcome
    {
        public double getDLnom()
        {
            DailyLife dailyl = new DailyLife();
            double DLnom = dailyl.nominalDL;

            return DLnom;
        }

        public double getLSnom()
        {
            LifeStyle lstyle = new LifeStyle();
            double LSnom = lstyle.nominalLS;

            return LSnom;
        }

        public double getSSnom()
        {
            SocialSpending socials = new SocialSpending();
            double SSnom = socials.nominalSS;

            return SSnom;
        }

        public double CalculateTotalOutcome()
        {
            double nom_dailylife = getDLnom();
            double nom_socialspend = getSSnom();
            double nom_lifestyle = getLSnom();

            double TotalOut = nom_dailylife + nom_socialspend + nom_lifestyle;

            return TotalOut;
        }

    }
}
