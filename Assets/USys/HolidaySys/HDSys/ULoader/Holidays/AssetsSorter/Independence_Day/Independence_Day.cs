using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Independence_Day
{
	public class Independence_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void LoadIndependence_DayHAssetLoader()
		{
			// Load Independence Day Assets
		}

		public void LoadIndependence_DaySales()
		{
			// Load Independence Day Sales
			ChangePrices.LoadIndependence_DayPrices();
		}
	}
}