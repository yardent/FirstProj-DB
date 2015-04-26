using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class Notification
    {
        public string cause { get; set; }
        public string description { get; set; }
        public bool hasBeenRead { get; set; }
        public DateTime date { get; set; }
        public DateTime time { get; set; }
        public Coupon coupon { get; set; }
    }   
}       
        
        