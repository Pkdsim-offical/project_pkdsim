using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Labor_Day
{
	public class Labor_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadLabor_DayHAssetsLoader()
		{
			// Load Labor Day Assets
		}
		public void LoadLabor_DaySales()
		{
			// Load Labor Day Sales
			ChangePrices.LoadLabor_DayPrices();
		}
	}
}