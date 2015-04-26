using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Order
    {
        public string serialKey { get; set; }
        public DateTime date { get; set; }
        public int amount { get; set; }
        public string paypal_userName { get; set; }
        public bool hasBeenUsed { get; set; }
        public virtual Coupon coupon { get; set; }
    }    
}        
         
         