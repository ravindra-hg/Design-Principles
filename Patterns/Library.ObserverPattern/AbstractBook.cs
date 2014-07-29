using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ObserverPattern
{
    public abstract class AbstractBook
    {
		private List<Shop> shops = new List<Shop>();

		private delegate void Notifier(decimal price);
		private Notifier priceNotifier;
		public void Attach(Shop shop)
		{
			shops.Add(shop);
			priceNotifier += new Notifier(shop.Update);
		}
		public void Detach(Shop shop)
		{
			shops.Remove(shop);

			if (priceNotifier == null)
				return;
			priceNotifier -= new Notifier(shop.Update);
		}

		protected void Notify(decimal price)
		{
			if (priceNotifier == null)
				return;
			priceNotifier(price);
		}

    }
}
