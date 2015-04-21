using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Business
    {
        string name {get; set;}
        string city { get; set; }
        string address { get; set; }
        string description { get; set; }
        Category category { get; set; }
        List<Coupon> coupons { get; set; }
        Business_manager manager { get; set; }

    }
}
