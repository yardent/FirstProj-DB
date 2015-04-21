using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Order
    {
        string serialKey { get; set; }
        DateTime date { get; set; }
        int amount { get; set; }
        string paypal_userName { get; set; }
        bool hasBeenUsed { get; set; }
        Coupon coupon { get; set; }
    }
}
