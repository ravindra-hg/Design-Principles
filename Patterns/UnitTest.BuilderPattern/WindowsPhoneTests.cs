using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.BuilderPattern;

namespace UnitTest.BuilderPattern
{
	[TestClass]
	public class WindowsPhoneTests
	{
		private WindowsPhoneBuilder mobileBuilder = new WindowsPhoneBuilder();
		[TestInitialize]
		public void Init()
		{
			Manufacturer manufacturer = new Manufacturer();
			manufacturer.Construct(mobileBuilder);
		}
		[TestMethod]
		public void check_phone_with_windows_os()
		{
			Assert.IsTrue(mobileBuilder.MobilePhone().OperatingSystem == OS.Windows);
		}
		[TestMethod]
		public void check_phone_with_1_gb_memory()
		{
			Assert.IsTrue(mobileBuilder.MobilePhone().Memory == Memory.FiveGB);
		}
	}
}
