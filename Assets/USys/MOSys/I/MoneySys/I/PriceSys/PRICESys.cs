using System;
using UnityEngine;
using project_pkdsim.Assets.USys.HolidaySys.Base;
using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I.LoadPrices;

namespace project_pkdsim.Assets.USys.MoneySys.I.PRICESys
{
	public class PriceSys : MonoBehaviour
	{
		private Load_Prices LoadPrices;

		private Holiday_Base Holiday;

		private DateTime dateToCheck = DateTime.Today;
		// Use this for initialization
		public void LoadPriceSys()
		{
			if (Holiday.IsHoliday(dateToCheck, DateTime.Today) == true)
			{
				LoadPrices.LoadPrices();
			}

			else if (Holiday.IsHoliday(dateToCheck,DateTime.Today) == false)
			{
				LoadPrices.Load_Normal_Prices();
			}
		}
		public void PriceSysI()
		{
			LoadPriceSys();
		}
	}
}