using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Presidents_Day
{
	public class Presidents_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void loadPresidents_DayHAssets()
		{
			//Load Presidents Day Assets
		}

		public static void LoadPresidents_DaySales()
		{
			//Load Presidents Day Sales
			ChangePricesI.LoadPresidents_DayPrice();
		}
	}
}