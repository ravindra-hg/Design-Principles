using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DecoratorPattern
{
	public class HatchBackCar : Decorator
	{
		public HatchBackCar(ICarBase carBase)
			: base(carBase)
		{
			this.name = "HatchBack";
			this.price = 80.00m;
		}
	}
}
