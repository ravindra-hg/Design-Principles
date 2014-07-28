using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BuilderPattern
{
	/// <summary>
	/// Concrete Builder
	/// </summary>
	public class AndriodPhoneBuilder:IMobileBuilder
	{
		private MobilePhone mobilePhone;
		public AndriodPhoneBuilder()
		{
			this.mobilePhone = new MobilePhone();
			this.mobilePhone.Name = "Andriod";
		}
		public void MemoryBuilder()
		{
			this.mobilePhone.Memory = Memory.OneGB;
		}

		public void OperatingSystemBuilder()
		{
			this.mobilePhone.OperatingSystem = OS.Andriod;
		}

		public void ScreenBuilder()
		{
			this.mobilePhone.Screen = Screen.CapicitiveTouch;
		}

		public void StylesBuilder()
		{
			this.mobilePhone.Stylus = true;
		}

		public MobilePhone MobilePhone()
		{
			return this.mobilePhone;
		}
	}
}
