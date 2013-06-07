using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VisitorPattern.VisitorWay
{
    public class VRLOrders : IAccept
    {
        public int TotalNumbers { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
