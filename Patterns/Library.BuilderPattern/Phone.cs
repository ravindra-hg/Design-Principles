using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BuilderPattern
{
	/// <summary>
	/// Product
	/// </summary>
    public class MobilePhone
    {
		public string Name { get; set; }
		public Memory Memory { get; set; }
		public OS OperatingSystem { get; set; }
		public Screen Screen { get; set; }
		public bool Stylus { get; set; }
    }

	public enum Memory
	{
		OneGB,
		FiveGB
	}

	public enum OS
	{
		Andriod,
		Windows,
		iOs,
		Symbion
	}

	public enum Screen
	{
		CapicitiveTouch,
		Resistive,
		NonTouch
	}
}