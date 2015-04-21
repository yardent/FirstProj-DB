using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Customer : User
    {
        List<Notification> inbox { get; set; }
        List<Order> orders { get; set; }
        List<Coupon> sharedCoupons { get; set; }
    }
}
