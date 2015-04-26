using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Customer : User
    {
        public virtual List<Notification> inbox { get; set; }
        public virtual List<Order> orders { get; set; }
        public virtual List<Coupon> sharedCoupons { get; set; }
    }   
}       
        
        
        
        
        