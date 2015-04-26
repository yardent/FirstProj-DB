using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Business
    {
        public  string name {get; set;}
        public  string city { get; set; }
        public  string address { get; set; }
        public  string description { get; set; }
        public virtual Category category { get; set; }
        public virtual List<Coupon> coupons { get; set; }
        public virtual Business_manager manager { get; set; }
       
    }
}
