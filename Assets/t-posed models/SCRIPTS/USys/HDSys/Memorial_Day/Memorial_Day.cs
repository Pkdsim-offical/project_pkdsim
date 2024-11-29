using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Memorial_Day
{
	public class Memorial_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadMemorial_DayHAssetLoader()
		{
			// Load Memorial Day assets
		}

		public static void LoadMemorial_DaySales()
		{
			// Load Memorial Day sales
			ChangePricesI.LoadMemorial_DayPrices();
		}
	}
}