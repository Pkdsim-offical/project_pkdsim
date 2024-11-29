using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.MartinLutherKing_Day
{
	public class MartinLutherKing_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public static void LoadMartinLutherKingDayHAssets()
		{
			// Load Martin Luther King Day
		}

		public static void LoadMartinLutherKingDaySales()
		{
			ChangePricesI.LoadMartinLutherKingDayPrices();
		}
	}
}