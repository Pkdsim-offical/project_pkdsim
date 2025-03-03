using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Easter
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