using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VisitorPattern.VisitorWay
{
    public class PrivateOrders:IAccept
    {
        public int TotalCount { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
