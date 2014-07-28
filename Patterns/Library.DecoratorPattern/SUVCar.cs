using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DecoratorPattern
{
	public class SUVCar : Decorator
	{
		public SUVCar(ICarBase carBase):base(carBase)
		{
			this.name = "SUV";
			this.price = 200.00m;
		}
	}
}
