using System;
using System.Collections.Generic;
using Library.VisitorPattern.VisitorWay;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.VisitorPattern
{
    [TestClass]
    public class VisitorWay
    {
        private List<object> orders = null;
        BookingAgentOrderManager bookingAgentOrderManager = null;
        [TestInitialize]
        public void Initialize()
        {
            bookingAgentOrderManager = new BookingAgentOrderManager();

            orders = new List<object>{
                 new KSRTCOrders(){ Count = 100},
                 new VRLOrders(){ TotalNumbers =120},
                 new PrivateOrders(){ TotalCount =20}
            };
        }

        [TestMethod]
        public void VisitorWay_GetTotalOrdersCount()
        {
            int totalOrdersCount = 240;
            int result = bookingAgentOrderManager.GetTotalOrdersCount(orders);
            Assert.AreEqual(totalOrdersCount, result);
        }
    }
}
