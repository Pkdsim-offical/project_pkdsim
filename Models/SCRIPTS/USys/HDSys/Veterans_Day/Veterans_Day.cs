using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Veterans_Day
{
	public class Veterans_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void loadVeterans_DayHAssets()
		{
			//Load Veterans Day Assets
		}

		public static void LoadVeterans_DaySales()
		{
			//Load Veterans Day Sales
			ChangePricesI.LoadVeterans_DayPrice();
		}
	}
}