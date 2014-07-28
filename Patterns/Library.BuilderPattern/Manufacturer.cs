using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BuilderPattern
{
	/// <summary>
	/// Constructor
	/// </summary>
	public class Manufacturer
	{
		public void Construct(IMobileBuilder mobileBuilder)
		{
			mobileBuilder.MemoryBuilder();
			mobileBuilder.OperatingSystemBuilder();
			mobileBuilder.ScreenBuilder();
			mobileBuilder.StylesBuilder();
		}
	}
}
