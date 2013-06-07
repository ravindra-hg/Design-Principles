using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VisitorPattern.VisitorWay
{
    internal class OrdersVisitor:IVisitor
    {
        public int TotalOrdersCount { get; private set; }

        public void Visit(KSRTCOrders orders)
        {
            this.TotalOrdersCount += orders.Count;
        }

        public void Visit(VRLOrders orders)
        {
            this.TotalOrdersCount += orders.TotalNumbers;
        }

        public void Visit(PrivateOrders orders)
        {
            this.TotalOrdersCount += orders.TotalCount;
        }
    }
}
