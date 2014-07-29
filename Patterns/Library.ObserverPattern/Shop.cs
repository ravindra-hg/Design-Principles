using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.ObserverPattern
{
	public class Shop : IObserver
	{
		public string Name { get; private set; }
		public decimal Price { get; private set; }
		public Shop(string name)
		{
			this.Name = name;
		}
		public void Update(decimal price)
		{
			this.Price = price;
		}

	}
}
