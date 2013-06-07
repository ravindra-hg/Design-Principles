using System;
using System.Collections.Generic;
using Library.VisitorPattern;
using Library.VisitorPattern.NonVisitorWay;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.VisitorPattern
{
    /// <summary>
    /// This is to test Non-Visitor pattern code (note: it works fine but how do we achieve this by visitor pattern?)
    /// </summary>
    [TestClass]
    public class NonVisitorWay
    {
        List<object> orders = null;
        Library.VisitorPattern.NonVisitorWay.BookingAgentOrderManager bookingManager;
        [TestInitialize]
        public void Initialize()
        {
            bookingManager = new Library.VisitorPattern.NonVisitorWay.BookingAgentOrderManager();

            orders = new List<object>{
                 new KSRTCOrders(){ Count = 100},
                 new VRLOrders(){ TotalNumbers =120},
                 new PrivateOrders(){ TotalCount =20}
            };
        }

        [TestMethod]
        public void NonVisitorWay_GetTotalOrdersCount()
        {
            int totalOrdersCount = 240;
            int result = bookingManager.GetTotalBookedOrders(orders);

            Assert.AreEqual(totalOrdersCount, result);
        }
    }
}
