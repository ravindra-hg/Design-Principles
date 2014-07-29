using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.ObserverPattern;

namespace UnitTest.ObserverPattern
{
	[TestClass]
	public class ObserverPatternTests
	{
		[TestInitialize]
		public void Init()
		{

		}
		[TestMethod]
		public void check_all_the_shops_notified_with_latest_price()
		{
			Book yaanaBook = new Book();

			Shop jayangarShop = new Shop("Jayanagar Shop");
			yaanaBook.Attach(jayangarShop);
			Shop jpNagarShop = new Shop("JP Nagar Shop");
			yaanaBook.Attach(jpNagarShop);
			Shop krRoadShop = new Shop("KR Road Shop");
			yaanaBook.Attach(krRoadShop);

			decimal latestPrice = 250m;
			yaanaBook.UpdatePrice(latestPrice);

			Assert.AreEqual(latestPrice, jayangarShop.Price);
			Assert.AreEqual(latestPrice, jpNagarShop.Price);
			Assert.AreEqual(latestPrice, krRoadShop.Price);

		}
	}
}
