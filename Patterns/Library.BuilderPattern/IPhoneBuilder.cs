using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BuilderPattern
{
	/// <summary>
	/// Builder
	/// </summary>
	public interface IMobileBuilder
	{
		void MemoryBuilder();
		void OperatingSystemBuilder();
		void ScreenBuilder();
		void StylesBuilder();
		MobilePhone MobilePhone();
	}
}
