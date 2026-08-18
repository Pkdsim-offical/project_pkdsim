using System;
using UnityEngine;
using project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.Base;
using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules.LoadPrices;

namespace project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys
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