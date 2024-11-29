using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Mothers_Day
{
	public class Mothers_Day_IAssetsLoader : MonoBehaviour 
	{
		private ChangePricesI ChangePrices;
		public static void LoadMothers_DayHAssets()
		{
			//Load Mother's Day Assets
		}

		public static void LoadMothers_DaySales()
		{
			//Load Mother's Day Sales
			ChangePricesI.LoadMothers_DayPrices();
		}
	}
}