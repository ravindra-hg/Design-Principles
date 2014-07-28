using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BuilderPattern
{
	public class WindowsPhoneBuilder:IMobileBuilder
	{
		private MobilePhone mobilePhone;
		public WindowsPhoneBuilder()
		{
			this.mobilePhone = new MobilePhone();
			this.mobilePhone.Name = "Windows";
		}
		public void MemoryBuilder()
		{
			this.mobilePhone.Memory = Memory.FiveGB;
		}

		public void OperatingSystemBuilder()
		{
			this.mobilePhone.OperatingSystem = OS.Windows;
		}

		public void ScreenBuilder()
		{
			this.mobilePhone.Screen = Screen.Resistive;
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
