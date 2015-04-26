using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Customer : User
    {
        public List<Notification> inbox { get; set; }
        public List<Order> orders { get; set; }
        public List<Coupon> sharedCoupons { get; set; }
    }   
}       
        
        
        
        
        