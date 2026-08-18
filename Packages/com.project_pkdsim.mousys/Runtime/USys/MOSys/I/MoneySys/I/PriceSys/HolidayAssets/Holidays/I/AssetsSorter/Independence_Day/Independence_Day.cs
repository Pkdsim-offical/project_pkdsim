using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.Modules.DataBase.ULoader.Holidays.AssetsSorter.Independence_Day
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