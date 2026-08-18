using project_pkdsim.USys.MOSys.Modules.MONEYSys.Modules.PRICESys.ChangePrices.Modules;
using UnityEngine;

namespace project_pkdsim.USys.HDSys.Modules.HOLIDAYSys.ULoader.Holidays.AssetsSorter.Presidents_Day
{
	public class Presidents_Day_IAssetsLoader : MonoBehaviour
	{
		private ChangePricesI ChangePrices;
		public void loadPresidents_DayHAssets()
		{
			//Load Presidents Day Assets
		}

		public void LoadPresidents_DaySales()
		{
			//Load Presidents Day Sales
			ChangePrices.LoadPresidents_DayPrices();
		}
	}
}