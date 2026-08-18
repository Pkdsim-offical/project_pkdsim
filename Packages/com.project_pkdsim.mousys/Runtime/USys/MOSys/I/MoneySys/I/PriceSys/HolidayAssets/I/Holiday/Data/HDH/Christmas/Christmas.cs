using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Christmas
{
	public class Christmas_IAssetLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadChristmasIAssetsLoader()
		{
			// Load Christmas Assets
		}

		public void LoadChristmasSales()
		{
			// Load Christmas Sales
			ChangePrices.LoadChristmasPrices();
		}
	}
}