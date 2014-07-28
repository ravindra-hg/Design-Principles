using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DecoratorPattern
{
	public abstract class Decorator:ICarBase
	{
		protected string name = "Generic Decorator";
		protected decimal price = 0.0m;
		private ICarBase carBase;
		protected Decorator(ICarBase carBase)
		{
			this.carBase = carBase;
		}

		public virtual string Name
		{
			get { return string.Format("{0}, {1}", this.carBase.Name, name); }
		}

		public virtual decimal Price
		{
			get { return this.carBase.Price + price; }
		}
	}
}
