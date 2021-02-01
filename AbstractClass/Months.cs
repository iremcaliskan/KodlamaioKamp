using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class January : Month
    {
        public override int WhatMonthOfYear()
        {
            return 1;
        }
    }

    public class February : Month
    {
        public override int HowManyDays()
        {
            return 28;  //base.HowManyDays();
        }

        public override int WhatMonthOfYear()
        {
            return 2;
        }
    }

    public class December : Month
    {
        public override int WhatMonthOfYear()
        {
            return 12;
        }
    }
}
