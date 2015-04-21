using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Notification
    {
        string cause { get; set; }
        string description { get; set; }
        bool hasBeenRead { get; set; }
        DateTime date { get; set; }
        DateTime time { get; set; }
        Coupon coupon { get; set; }
    }
}
