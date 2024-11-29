
using project_pkdsim.Assets.USys.PriceSys.ChangePrices;
using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.BlackFriday
{
	public class BlackFriday_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI changePrice;
		public static void loadBlackFridayHAssetLoader()
		{
			//Load Black Friday
		}
		public static void LoadBlackFridaySales()
		{
			//Load Black Friday
			ChangePricesI.LoadBlackFridayPrices();
		}
	}
}