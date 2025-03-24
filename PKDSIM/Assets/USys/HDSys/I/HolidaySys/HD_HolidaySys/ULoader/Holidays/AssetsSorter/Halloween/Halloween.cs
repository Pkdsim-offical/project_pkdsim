using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Halloween
{
	public class Halloween_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadHalloweenHAssetLoader()
		{
			// Load Halloween Asset
		}
		public void LoadHalloweenSales()
		{
			// Load Halloween Sales
			ChangePrices.LoadHalloweenPrices();
		}
	}
}