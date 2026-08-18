using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Halloween
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