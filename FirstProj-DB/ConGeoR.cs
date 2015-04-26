using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Entity;
    
    public class ConGeoR : DbContext
    {
        public DbSet<Business> businesses { get; set; }
        public DbSet<Business_manager> managers { get; set; }
        public DbSet<Coupon> coupons { get; set; }
        public DbSet<CouponRank> couponRanks { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Notification> notifications { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<User_Preference> userPreferences { get; set; }
    }
}
