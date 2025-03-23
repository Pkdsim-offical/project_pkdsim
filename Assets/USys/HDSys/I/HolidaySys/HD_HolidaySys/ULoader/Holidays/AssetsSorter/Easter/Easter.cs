using project_pkdsim.Assets.USys.MoneySys.I.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HolidaySys.ULoader.Holidays.AssetsSorter.Easter
{
	public class Easter_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadEasterHAssets()
		{
			// Load Easter Assets
		}
		public void LoadEasterSales()
		{
			// Load Easter Sales
			ChangePrices.LoadEasterPrices();
		}
	}
}