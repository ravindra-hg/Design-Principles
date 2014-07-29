using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.ObserverPattern
{
	public interface IObserver
	{
		void Update(decimal price);
	}
}
