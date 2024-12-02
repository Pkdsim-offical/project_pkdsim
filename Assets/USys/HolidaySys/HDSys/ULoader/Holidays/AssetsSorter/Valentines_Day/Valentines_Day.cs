using project_pkdsim.Assets.USys.MONEYSys.PRICESys.ChangePrices.I;
using UnityEngine;

namespace project_pkdsim.Assets.USys.HDSys.ULoader.Holidays.AssetsSorter.Valentines_Day
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