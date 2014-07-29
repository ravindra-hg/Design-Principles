using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.ObserverPattern
{
	public class Book : AbstractBook
	{
		public void UpdatePrice(decimal price)
		{
			Notify(price);
		}
	}
}
