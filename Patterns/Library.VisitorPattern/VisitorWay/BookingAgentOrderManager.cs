using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VisitorPattern.VisitorWay
{
    public class BookingAgentOrderManager
    {
        public int GetTotalOrdersCount(List<object> orders)
        {
            OrdersVisitor orderVisitor = new OrdersVisitor();
            foreach (var item in orders)
            {
                IAccept acceptor = (IAccept)item;
                acceptor.Accept(orderVisitor);
            }

            return orderVisitor.TotalOrdersCount;
        }
    }
}
