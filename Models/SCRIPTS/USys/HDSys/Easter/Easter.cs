using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Easter
{
	public class Easter_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI changePrices;
		public static void LoadEasterHAssets()
		{
			//Load Easter Assets
		}
		public static void LoadEasterSales()
		{
			// Load Easter Sales
			ChangePricesI.LoadEasterPrices();
		}
	}
}