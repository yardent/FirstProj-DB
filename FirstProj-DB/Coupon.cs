using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public enum Category
    {
        RESTAURANT,
        CONSUMERISM,
        ENTERTAIMENT,
        SHOWS,
        TOURISM,
        PROFFESIONALS,
        HEALTH_AND_FITNESS,
        CARE_AND_SPA
    }
    public class Coupon
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public virtual Category category { get; set; }
        public int originalPrice { get; set; }
        public double averageRank { get; set; }
        public DateTime lastDate { get; set; }
        public virtual List<Order> orders { get; set; }
        public virtual List<Notification> notifications { get; set; }
        public virtual Business business { get; set; }
    }
}
