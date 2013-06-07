using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VisitorPattern.VisitorWay
{
    public interface IVisitor
    {
        void Visit(KSRTCOrders orders);
        void Visit(VRLOrders orders);
        void Visit(PrivateOrders orders);
    }
}
