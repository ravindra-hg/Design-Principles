using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.DecoratorPattern;

namespace UnitTest.DecoratorPattern
{
	[TestClass]
	public class DecoratorTests
	{
		ICarBase carBase = null;
		[TestInitialize]
		public void Init()
		{
			this.carBase = new CarBase();
		}
		[TestMethod]
		public void check_hatch_back_car_features()
		{
			HatchBackCar hatchBackCar = new HatchBackCar(this.carBase);

			Assert.AreEqual("Car Base, HatchBack", hatchBackCar.Name);
			Assert.AreEqual(180.00m, hatchBackCar.Price);
		}

		[TestMethod]
		public void check_suv_car_features()
		{
			SUVCar suvCar = new SUVCar(this.carBase);

			Assert.AreEqual("Car Base, SUV", suvCar.Name);
			Assert.AreEqual(300.00m, suvCar.Price);
		}
	}
}
