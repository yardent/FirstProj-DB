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
        string id { get; set; }
        string name { get; set; }
        string description { get; set; }
        Category category { get; set; }
        int originalPrice { get; set; }
        double averageRank { get; set; }
        DateTime lastDate { get; set; }
        List<Order> orders { get; set; }
        List<Notification> notifications { get; set; }
        Business business { get; set; }
    }
}
