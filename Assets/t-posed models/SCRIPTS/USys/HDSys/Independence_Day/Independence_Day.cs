using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Independence_Day
{
	public class Independence_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadIndependence_DayHAssetLoader()
		{
			// load Independence Day Assets
		}

		public static void LoadIndependence_DaySales()
		{
			// load Independence Day Sales
			ChangePricesI.LoadIndependence_DayPrices();
		}
	}
}