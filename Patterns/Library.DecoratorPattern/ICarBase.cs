using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DecoratorPattern
{
	public interface ICarBase
	{
		string Name { get; }
		decimal Price { get; }
	}
}
