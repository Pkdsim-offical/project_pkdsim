using System;
using project_pkdsim.Assets.USys.HSys.Base;
using project_pkdsim.Assets.USys.PriceSys.LoadPrices;
using UnityEngine;

namespace project_pkdsim.Assets.USys.PriceSys
{
	public class PriceSys : MonoBehaviour
	{
		private Load_Prices LoadPrice;

		private Holiday_Base Holiday;

		private DateTime dateToCheck = DateTime.Today;
		// Use this for initialization
		public void LoadPriceSys()
		{
			if (Holiday.IsHoliday(dateToCheck, DateTime.Today) == true)
			{
				Load_Prices.LoadPrices();
			}

			else if (Holiday.IsHoliday(dateToCheck,DateTime.Today) == false)
			{
				Load_Prices.Load_Normal_Prices();
			}
		}
		public void PriceSysI()
		{
			LoadPriceSys();
		}
	}
}