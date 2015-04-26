using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstProj_DB
{
    public class CouponRank
    {
        public Dictionary<string, Dictionary<string, int>> couponRanks = new Dictionary<string,Dictionary<string,int>>();
        public Dictionary<string, Dictionary<string, int>> customerRanks = new Dictionary<string,Dictionary<string,int>>();
      
        public Dictionary<string, int> getCouponRanks(string couponId)
        {
            if (couponRanks.ContainsKey(couponId))
                return couponRanks[couponId];
            else
                return null;
        }

        public Dictionary<string, int> getCustomerRanks(string customerId)
        {
            if (customerRanks.ContainsKey(customerId))
                return customerRanks[customerId];
            else
                return null;
        }

        public void add(string customerId, string couponId, int rank)
        {
            if (rank > 0 && rank < 6)
            {
                if (customerRanks.ContainsKey(customerId))
                    customerRanks[customerId][couponId] = rank;
                else
                {
                    customerRanks[customerId] = new Dictionary<string, int>();
                    customerRanks[customerId][couponId] = rank;
                }
                if (couponRanks.ContainsKey(couponId))
                    couponRanks[couponId][customerId] = rank;
                else
                {
                    couponRanks[couponId] = new Dictionary<string, int>();
                    couponRanks[couponId][customerId] = rank;
                }
            }
        }

    }
}
