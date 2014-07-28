using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DecoratorPattern
{
	public class CarBase : ICarBase
	{
		private string name = "Car Base";
		private decimal price = 100.00m;

		public virtual string Name
		{
			get { return this.name; }
		}

		public virtual decimal Price
		{
			get { return this.price; }
		}
	}
}