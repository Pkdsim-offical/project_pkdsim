using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Christmas
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