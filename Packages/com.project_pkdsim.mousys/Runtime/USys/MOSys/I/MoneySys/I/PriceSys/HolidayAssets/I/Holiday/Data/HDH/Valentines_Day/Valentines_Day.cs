using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Valentines_Day
{
	public class Valentines_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadValentines_DayHAssets()
		{
			// Load Valentines Day Assets
		}

		public void LoadValentines_DaySales()
		{
			// Load Valentines Day Sales
			ChangePrices.LoadValentines_DayPrices();
		}
	}
}