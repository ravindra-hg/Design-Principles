using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VisitorPattern.NonVisitorWay
{
    public class BookingAgentOrderManager
    {
        public int GetTotalBookedOrders(List<object> orders)
        {
            int totalCount = 0;
            foreach (var item in orders)
            {
                if (item.GetType() == typeof(KSRTCOrders))
                {
                    totalCount += ((KSRTCOrders)item).Count;
                }
                if (item.GetType() == typeof(VRLOrders))
                {
                    totalCount += ((VRLOrders)item).TotalNumbers;
                }
                if (item.GetType() == typeof(PrivateOrders))
                {
                    totalCount += ((PrivateOrders)item).TotalCount;
                }
            }

            return totalCount;
        }
    }
}
