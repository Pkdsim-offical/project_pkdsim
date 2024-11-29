
using project_pkdsim.Assets.USys.PriceSys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.Models.SCRIPTS.USys.HDSys.ULoader.Holidays.AssetsSorter.Halloween
{
	public class Halloween_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI changePrice;
		public static void LoadHalloweenHAssetLoader()
		{

		}
		public static void LoadHalloweenSales()
		{
			//Load Halloween
			ChangePricesI.LoadHalloweenPrices();
		}
	}
}