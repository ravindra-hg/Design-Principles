using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.BuilderPattern;

namespace UnitTest.BuilderPattern
{
	[TestClass]
	public class AndriodPhoneTests
	{
		private AndriodPhoneBuilder mobileBuilder = new AndriodPhoneBuilder();
		[TestInitialize]
		public void Init()
		{
			Manufacturer manufacturer = new Manufacturer();
			manufacturer.Construct(mobileBuilder);
		}
		[TestMethod]
		public void check_phone_with_andriod_os()
		{
			Assert.IsTrue(mobileBuilder.MobilePhone().OperatingSystem == OS.Andriod);
		}
		[TestMethod]
		public void check_phone_with_1_gb_memory()
		{
			Assert.IsTrue(mobileBuilder.MobilePhone().Memory == Memory.OneGB);
		}
	}
}
